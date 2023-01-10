using MailKit;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System.ComponentModel;

namespace Notify
{
    public class EmailSender : IEmailSender
    {
        public delegate void MessageSent(object sender, EventArgs eventArgs);
        public event MessageSent? OnMessageSent = null;

        private EmailConfiguration _emailConfig;
        private SmtpClient _smtpClient; //MailKit.Net.Smtp.SmtpClient

        public EmailSender(EmailConfiguration emailConfig)
        {
            _emailConfig = emailConfig;
            _smtpClient = new SmtpClient(); //MailKit.Net.Smtp.SmtpClientç_smt
            _smtpClient.MessageSent += _smtpClient_MessageSent;
        }

        public void SendEmail(Message message)
        {
            var emailMessage = CreateEmailMessage(message);

            Send(emailMessage);
        }

        public async Task SendEmailAsync(Message message)
        {
            var mailMessage = CreateEmailMessage(message);

            await SendAsync(mailMessage);
        }

        private MimeMessage CreateEmailMessage(Message message)
        {
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress("David Fernández", _emailConfig.From));
            emailMessage.To.AddRange(message.To);
            emailMessage.Subject = message.Subject;

            var bodyBuilder = new BodyBuilder { HtmlBody = string.Format("<h2>{0}</h2>", message.Content) };

            emailMessage.Body = bodyBuilder.ToMessageBody();
            return emailMessage;
        }

        private void Send(MimeMessage mailMessage)
        {
            try
            {
                if (_smtpClient == null)
                {
                    _smtpClient = new SmtpClient();
                }

                if (!_smtpClient.IsConnected)
                {
                    //_logger.LogInformation("Trying to connect mail server: {0} at port: {1}", _emailConfig.SmtpServer, _emailConfig.Port);
                    _smtpClient.Connect(_emailConfig.SmtpServer, _emailConfig.Port, SecureSocketOptions.StartTls);

                    if (_smtpClient.IsConnected && !_smtpClient.IsAuthenticated)
                    {
                        //_logger.LogInformation("Connected to mail server: {0} at port: {1}", _emailConfig.SmtpServer, _emailConfig.Port);
                        //_logger.LogInformation("Trying to authenticate with username: {0} and paswd: {1}", _emailConfig.UserName, _emailConfig.Password);
                        //_smtpClient.AuthenticationMechanisms.Remove("XOAUTH2");
                        _smtpClient.Authenticate(_emailConfig.UserName, _emailConfig.Password);
                        //_logger.LogInformation("Seems to be authenticated with username: {0} and paswd: {1}", _emailConfig.UserName, _emailConfig.Password);
                    }
                }
                //_logger.LogInformation("Trying to send mail message:{0}", mailMessage.Subject);
                _smtpClient.Send(mailMessage);
                //_logger.LogInformation("Mail sent successfully:{0}", mailMessage.Subject);

            }
            catch (Exception ex)
            {
                //log an error message or throw an exception, or both.
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                _smtpClient.Disconnect(true);
                _smtpClient.Dispose();
            }
        }

        private async Task SendAsync(MimeMessage mailMessage)
        {
            try
            {
                _smtpClient.SslProtocols = System.Security.Authentication.SslProtocols.Tls12;
                _smtpClient.DeliveryStatusNotificationType = DeliveryStatusNotificationType.Full;
                await _smtpClient.ConnectAsync(_emailConfig.SmtpServer, _emailConfig.Port, SecureSocketOptions.StartTls);
                await _smtpClient.AuthenticateAsync(_emailConfig.UserName, _emailConfig.Password);
                await _smtpClient.SendAsync(mailMessage);
            }
            catch (Exception ex)
            {
                //log an error message or throw an exception, or both.
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                await _smtpClient.DisconnectAsync(true);
                _smtpClient.Dispose();
            }
        }

        #region Event Handlers
        private void _smtpClient_MessageSent(object? sender, MailKit.MessageSentEventArgs e)
        {
            if (OnMessageSent != null)
            {
                OnMessageSent(this, new EventArgs());
            }
        }

        #endregion Event Handlers
    }
}

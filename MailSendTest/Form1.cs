using Notify;
using static System.Net.Mime.MediaTypeNames;

namespace MailSendTest
{
    public partial class FormMain : Form
    {
        private delegate void SetLabelCallback(string text, Color color);

        public FormMain()
        {
            InitializeComponent();
        }

        private async void buttonSend_Click(object sender, EventArgs e)
        {
            EmailConfiguration emailConfiguration = new EmailConfiguration();
            emailConfiguration.From = textBoxSender.Text;
            emailConfiguration.SmtpServer = textBoxSMTPServer.Text;
            emailConfiguration.Port = Int32.Parse(textBoxPort.Text);
            emailConfiguration.UserName = textBoxUserId.Text;
            emailConfiguration.Password = textBoxPassword.Text;

            Notify.Message message = new Notify.Message(new string[] { textBoxRecipients.Text }, textBoxMailSubject.Text, textBoxMailBody.Text);

            EmailSender emailSender = new EmailSender(emailConfiguration);
            emailSender.OnMessageSent += EmailSender_OnMessageSent;

            try
            {
                labelStatus.ForeColor = Color.Black;
                labelStatus.Text = "Sending...";
                await emailSender.SendEmailAsync(message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                labelStatus.ForeColor = Color.Red;
                labelStatus.Text = "Fail";
            }
        }

        private void SetLabel(string text, Color color)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (labelStatus.InvokeRequired)
            {
                SetLabelCallback setLabelCallback = new SetLabelCallback(SetLabel);
                this.Invoke(setLabelCallback, new object[] { text, color });
            }
            else
            {
                labelStatus.Text = text;
                labelStatus.ForeColor = color;
            }
        }

        private void EmailSender_OnMessageSent(object sender, EventArgs eventArgs)
        {
            SetLabel("Message Sent", Color.Green);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            textBoxSender.Text = "example@example.com";
            textBoxSMTPServer.Text = "mail.example.com";
            textBoxPort.Text = 587.ToString();
            textBoxUserId.Text = "example@example.com";
            textBoxPassword.Text = "password";
            textBoxRecipients.Text = "example@example.com";
            textBoxMailSubject.Text = "Windows form test subject";
            textBoxMailBody.Text = "Windows form test body";
        }
    }
}
namespace MailSendTest
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelSMTPServer = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelUserId = new System.Windows.Forms.Label();
            this.textBoxSMTPServer = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxSender = new System.Windows.Forms.TextBox();
            this.labelSender = new System.Windows.Forms.Label();
            this.labelRecipients = new System.Windows.Forms.Label();
            this.textBoxRecipients = new System.Windows.Forms.TextBox();
            this.labelMailSubject = new System.Windows.Forms.Label();
            this.textBoxMailSubject = new System.Windows.Forms.TextBox();
            this.labelMailBody = new System.Windows.Forms.Label();
            this.textBoxMailBody = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(580, 303);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(92, 32);
            this.buttonSend.TabIndex = 0;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // labelSMTPServer
            // 
            this.labelSMTPServer.AutoSize = true;
            this.labelSMTPServer.Location = new System.Drawing.Point(24, 23);
            this.labelSMTPServer.Name = "labelSMTPServer";
            this.labelSMTPServer.Size = new System.Drawing.Size(72, 15);
            this.labelSMTPServer.TabIndex = 2;
            this.labelSMTPServer.Text = "SMTP Server";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(24, 57);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(29, 15);
            this.labelPort.TabIndex = 3;
            this.labelPort.Text = "Port";
            // 
            // labelUserId
            // 
            this.labelUserId.AutoSize = true;
            this.labelUserId.Location = new System.Drawing.Point(24, 89);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Size = new System.Drawing.Size(43, 15);
            this.labelUserId.TabIndex = 4;
            this.labelUserId.Text = "User Id";
            // 
            // textBoxSMTPServer
            // 
            this.textBoxSMTPServer.Location = new System.Drawing.Point(103, 19);
            this.textBoxSMTPServer.Name = "textBoxSMTPServer";
            this.textBoxSMTPServer.Size = new System.Drawing.Size(243, 23);
            this.textBoxSMTPServer.TabIndex = 5;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(103, 54);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(243, 23);
            this.textBoxPort.TabIndex = 6;
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.Location = new System.Drawing.Point(103, 89);
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.Size = new System.Drawing.Size(243, 23);
            this.textBoxUserId.TabIndex = 7;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(103, 125);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(243, 23);
            this.textBoxPassword.TabIndex = 9;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(24, 128);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(57, 15);
            this.labelPassword.TabIndex = 8;
            this.labelPassword.Text = "Password";
            // 
            // textBoxSender
            // 
            this.textBoxSender.Location = new System.Drawing.Point(103, 164);
            this.textBoxSender.Name = "textBoxSender";
            this.textBoxSender.Size = new System.Drawing.Size(243, 23);
            this.textBoxSender.TabIndex = 11;
            // 
            // labelSender
            // 
            this.labelSender.AutoSize = true;
            this.labelSender.Location = new System.Drawing.Point(24, 167);
            this.labelSender.Name = "labelSender";
            this.labelSender.Size = new System.Drawing.Size(43, 15);
            this.labelSender.TabIndex = 10;
            this.labelSender.Text = "Sender";
            // 
            // labelRecipients
            // 
            this.labelRecipients.AutoSize = true;
            this.labelRecipients.Location = new System.Drawing.Point(24, 213);
            this.labelRecipients.Name = "labelRecipients";
            this.labelRecipients.Size = new System.Drawing.Size(61, 15);
            this.labelRecipients.TabIndex = 12;
            this.labelRecipients.Text = "Recipients";
            // 
            // textBoxRecipients
            // 
            this.textBoxRecipients.Location = new System.Drawing.Point(103, 210);
            this.textBoxRecipients.Multiline = true;
            this.textBoxRecipients.Name = "textBoxRecipients";
            this.textBoxRecipients.Size = new System.Drawing.Size(243, 49);
            this.textBoxRecipients.TabIndex = 13;
            // 
            // labelMailSubject
            // 
            this.labelMailSubject.AutoSize = true;
            this.labelMailSubject.Location = new System.Drawing.Point(385, 23);
            this.labelMailSubject.Name = "labelMailSubject";
            this.labelMailSubject.Size = new System.Drawing.Size(46, 15);
            this.labelMailSubject.TabIndex = 14;
            this.labelMailSubject.Text = "Subject";
            // 
            // textBoxMailSubject
            // 
            this.textBoxMailSubject.Location = new System.Drawing.Point(385, 54);
            this.textBoxMailSubject.Name = "textBoxMailSubject";
            this.textBoxMailSubject.Size = new System.Drawing.Size(287, 23);
            this.textBoxMailSubject.TabIndex = 15;
            // 
            // labelMailBody
            // 
            this.labelMailBody.AutoSize = true;
            this.labelMailBody.Location = new System.Drawing.Point(385, 89);
            this.labelMailBody.Name = "labelMailBody";
            this.labelMailBody.Size = new System.Drawing.Size(57, 15);
            this.labelMailBody.TabIndex = 16;
            this.labelMailBody.Text = "MailBody";
            // 
            // textBoxMailBody
            // 
            this.textBoxMailBody.Location = new System.Drawing.Point(385, 125);
            this.textBoxMailBody.Multiline = true;
            this.textBoxMailBody.Name = "textBoxMailBody";
            this.textBoxMailBody.Size = new System.Drawing.Size(287, 134);
            this.textBoxMailBody.TabIndex = 17;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(284, 303);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 15);
            this.labelStatus.TabIndex = 18;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 347);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.textBoxMailBody);
            this.Controls.Add(this.labelMailBody);
            this.Controls.Add(this.textBoxMailSubject);
            this.Controls.Add(this.labelMailSubject);
            this.Controls.Add(this.textBoxRecipients);
            this.Controls.Add(this.labelRecipients);
            this.Controls.Add(this.textBoxSender);
            this.Controls.Add(this.labelSender);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxUserId);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.textBoxSMTPServer);
            this.Controls.Add(this.labelUserId);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.labelSMTPServer);
            this.Controls.Add(this.buttonSend);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 386);
            this.MinimumSize = new System.Drawing.Size(700, 386);
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Email send test";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSend;
        private Label labelSMTPServer;
        private Label labelPort;
        private Label labelUserId;
        private TextBox textBoxSMTPServer;
        private TextBox textBoxPort;
        private TextBox textBoxUserId;
        private TextBox textBoxPassword;
        private Label labelPassword;
        private TextBox textBoxSender;
        private Label labelSender;
        private Label labelRecipients;
        private TextBox textBoxRecipients;
        private Label labelMailSubject;
        private TextBox textBoxMailSubject;
        private Label labelMailBody;
        private TextBox textBoxMailBody;
        private Label labelStatus;
    }
}
namespace SCTAttendanceSystemUI.Forms
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSettings = new System.Windows.Forms.Label();
            this.panelBg = new System.Windows.Forms.Panel();
            this.verifyBtn = new System.Windows.Forms.Button();
            this.sendBtn = new System.Windows.Forms.Button();
            this.code = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxIDNo = new System.Windows.Forms.TextBox();
            this.textBoxCurrentPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.labelCurrentPassword = new System.Windows.Forms.Label();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelIDNo = new System.Windows.Forms.Label();
            this.labelAccountNumber = new System.Windows.Forms.Label();
            this.labelAccountSettings = new System.Windows.Forms.Label();
            this.panelBg.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSettings
            // 
            this.labelSettings.AutoSize = true;
            this.labelSettings.BackColor = System.Drawing.Color.Transparent;
            this.labelSettings.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSettings.Location = new System.Drawing.Point(38, 32);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(149, 31);
            this.labelSettings.TabIndex = 7;
            this.labelSettings.Text = "SETTINGS";
            // 
            // panelBg
            // 
            this.panelBg.BackColor = System.Drawing.SystemColors.Control;
            this.panelBg.BackgroundImage = global::SCTAttendanceSystemUI.Properties.Resources.white1bg;
            this.panelBg.Controls.Add(this.verifyBtn);
            this.panelBg.Controls.Add(this.sendBtn);
            this.panelBg.Controls.Add(this.code);
            this.panelBg.Controls.Add(this.email);
            this.panelBg.Controls.Add(this.label2);
            this.panelBg.Controls.Add(this.label3);
            this.panelBg.Controls.Add(this.label1);
            this.panelBg.Controls.Add(this.buttonSave);
            this.panelBg.Controls.Add(this.buttonLogin);
            this.panelBg.Controls.Add(this.textBoxIDNo);
            this.panelBg.Controls.Add(this.textBoxCurrentPassword);
            this.panelBg.Controls.Add(this.textBoxNewPassword);
            this.panelBg.Controls.Add(this.labelCurrentPassword);
            this.panelBg.Controls.Add(this.labelNewPassword);
            this.panelBg.Controls.Add(this.labelPassword);
            this.panelBg.Controls.Add(this.labelIDNo);
            this.panelBg.Controls.Add(this.labelAccountNumber);
            this.panelBg.Controls.Add(this.labelAccountSettings);
            this.panelBg.Location = new System.Drawing.Point(51, 100);
            this.panelBg.Name = "panelBg";
            this.panelBg.Size = new System.Drawing.Size(1561, 739);
            this.panelBg.TabIndex = 8;
            this.panelBg.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // verifyBtn
            // 
            this.verifyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(208)))), ((int)(((byte)(2)))));
            this.verifyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verifyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verifyBtn.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.verifyBtn.Location = new System.Drawing.Point(501, 365);
            this.verifyBtn.Name = "verifyBtn";
            this.verifyBtn.Size = new System.Drawing.Size(150, 40);
            this.verifyBtn.TabIndex = 17;
            this.verifyBtn.Text = "Verify";
            this.verifyBtn.UseVisualStyleBackColor = false;
            this.verifyBtn.Click += new System.EventHandler(this.verifyBtn_Click);
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(208)))), ((int)(((byte)(2)))));
            this.sendBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendBtn.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sendBtn.Location = new System.Drawing.Point(501, 293);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(150, 40);
            this.sendBtn.TabIndex = 16;
            this.sendBtn.Text = "SEND";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // code
            // 
            this.code.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.code.Location = new System.Drawing.Point(181, 365);
            this.code.MaxLength = 100;
            this.code.Multiline = true;
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(290, 40);
            this.code.TabIndex = 15;
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email.Location = new System.Drawing.Point(181, 293);
            this.email.MaxLength = 100;
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(290, 40);
            this.email.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(62, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Enter Code:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(62, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "Enter Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(120, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "VERIFICATION";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(208)))), ((int)(((byte)(2)))));
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.Location = new System.Drawing.Point(783, 597);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(150, 40);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(208)))), ((int)(((byte)(2)))));
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.Location = new System.Drawing.Point(1561, 739);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(150, 40);
            this.buttonLogin.TabIndex = 9;
            this.buttonLogin.Text = "SAVE";
            this.buttonLogin.UseVisualStyleBackColor = false;
            // 
            // textBoxIDNo
            // 
            this.textBoxIDNo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxIDNo.Location = new System.Drawing.Point(181, 135);
            this.textBoxIDNo.MaxLength = 100;
            this.textBoxIDNo.Multiline = true;
            this.textBoxIDNo.Name = "textBoxIDNo";
            this.textBoxIDNo.Size = new System.Drawing.Size(290, 40);
            this.textBoxIDNo.TabIndex = 8;
            // 
            // textBoxCurrentPassword
            // 
            this.textBoxCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCurrentPassword.Location = new System.Drawing.Point(181, 594);
            this.textBoxCurrentPassword.MaxLength = 100;
            this.textBoxCurrentPassword.Multiline = true;
            this.textBoxCurrentPassword.Name = "textBoxCurrentPassword";
            this.textBoxCurrentPassword.Size = new System.Drawing.Size(290, 40);
            this.textBoxCurrentPassword.TabIndex = 7;
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNewPassword.Location = new System.Drawing.Point(181, 522);
            this.textBoxNewPassword.MaxLength = 100;
            this.textBoxNewPassword.Multiline = true;
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(290, 40);
            this.textBoxNewPassword.TabIndex = 6;
            // 
            // labelCurrentPassword
            // 
            this.labelCurrentPassword.AutoSize = true;
            this.labelCurrentPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentPassword.Location = new System.Drawing.Point(24, 601);
            this.labelCurrentPassword.Name = "labelCurrentPassword";
            this.labelCurrentPassword.Size = new System.Drawing.Size(151, 28);
            this.labelCurrentPassword.TabIndex = 5;
            this.labelCurrentPassword.Text = "Verify Password:";
            this.labelCurrentPassword.Click += new System.EventHandler(this.labelCurrentPassword_Click);
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelNewPassword.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNewPassword.Location = new System.Drawing.Point(37, 528);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(141, 28);
            this.labelNewPassword.TabIndex = 4;
            this.labelNewPassword.Text = "New Password:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.Location = new System.Drawing.Point(120, 474);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(144, 26);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "PASSWORD";
            // 
            // labelIDNo
            // 
            this.labelIDNo.AutoSize = true;
            this.labelIDNo.BackColor = System.Drawing.Color.Transparent;
            this.labelIDNo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIDNo.Location = new System.Drawing.Point(37, 138);
            this.labelIDNo.Name = "labelIDNo";
            this.labelIDNo.Size = new System.Drawing.Size(138, 28);
            this.labelIDNo.TabIndex = 2;
            this.labelIDNo.Text = "Your ID No. is: ";
            // 
            // labelAccountNumber
            // 
            this.labelAccountNumber.AutoSize = true;
            this.labelAccountNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelAccountNumber.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAccountNumber.Location = new System.Drawing.Point(120, 77);
            this.labelAccountNumber.Name = "labelAccountNumber";
            this.labelAccountNumber.Size = new System.Drawing.Size(243, 26);
            this.labelAccountNumber.TabIndex = 1;
            this.labelAccountNumber.Text = "ACCOUNT NUMBER";
            // 
            // labelAccountSettings
            // 
            this.labelAccountSettings.AutoSize = true;
            this.labelAccountSettings.BackColor = System.Drawing.Color.Transparent;
            this.labelAccountSettings.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAccountSettings.Location = new System.Drawing.Point(625, 17);
            this.labelAccountSettings.Name = "labelAccountSettings";
            this.labelAccountSettings.Size = new System.Drawing.Size(294, 31);
            this.labelAccountSettings.TabIndex = 0;
            this.labelAccountSettings.Text = "ACCOUNT SETTINGS";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::SCTAttendanceSystemUI.Properties.Resources.BG_LOW_OPACITY;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panelBg);
            this.Controls.Add(this.labelSettings);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            this.panelBg.ResumeLayout(false);
            this.panelBg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelSettings;
        private Panel panelBg;
        private Label labelCurrentPassword;
        private Label labelNewPassword;
        private Label labelPassword;
        private Label labelIDNo;
        private Label labelAccountNumber;
        private Label labelAccountSettings;
        private TextBox textBoxIDNo;
        private TextBox textBoxCurrentPassword;
        private TextBox textBoxNewPassword;
        private Button buttonLogin;
        private Button buttonSave;
        private Label label1;
        private TextBox code;
        private TextBox email;
        private Label label2;
        private Label label3;
        private Button sendBtn;
        private Button verifyBtn;
    }
}
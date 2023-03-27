namespace SCTAttendanceSystemUI
{
    partial class Form1
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
            this.panelColorBg = new System.Windows.Forms.Panel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxIDNum = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelIdNo = new System.Windows.Forms.Label();
            this.labelGreet = new System.Windows.Forms.Label();
            this.labelTaytay = new System.Windows.Forms.Label();
            this.labelSiena = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelColorBg.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelColorBg
            // 
            this.panelColorBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.panelColorBg.Controls.Add(this.buttonLogin);
            this.panelColorBg.Controls.Add(this.textBoxPassword);
            this.panelColorBg.Controls.Add(this.textBoxIDNum);
            this.panelColorBg.Controls.Add(this.labelPassword);
            this.panelColorBg.Controls.Add(this.labelIdNo);
            this.panelColorBg.Controls.Add(this.labelGreet);
            this.panelColorBg.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelColorBg.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelColorBg.Location = new System.Drawing.Point(976, 0);
            this.panelColorBg.Name = "panelColorBg";
            this.panelColorBg.Size = new System.Drawing.Size(690, 822);
            this.panelColorBg.TabIndex = 2;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(208)))), ((int)(((byte)(2)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.Location = new System.Drawing.Point(306, 563);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(150, 40);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "LOGIN";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxPassword.Location = new System.Drawing.Point(224, 498);
            this.textBoxPassword.MaxLength = 100;
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(290, 40);
            this.textBoxPassword.TabIndex = 4;
            // 
            // textBoxIDNum
            // 
            this.textBoxIDNum.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxIDNum.Location = new System.Drawing.Point(224, 395);
            this.textBoxIDNum.MaxLength = 100;
            this.textBoxIDNum.Multiline = true;
            this.textBoxIDNum.Name = "textBoxIDNum";
            this.textBoxIDNum.Size = new System.Drawing.Size(290, 40);
            this.textBoxIDNum.TabIndex = 3;
            this.textBoxIDNum.TextChanged += new System.EventHandler(this.textBoxIDNum_TextChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(197, 450);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(133, 25);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "PASSWORD";
            this.labelPassword.Click += new System.EventHandler(this.labelPassword_Click);
            // 
            // labelIdNo
            // 
            this.labelIdNo.AutoSize = true;
            this.labelIdNo.BackColor = System.Drawing.Color.Transparent;
            this.labelIdNo.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIdNo.ForeColor = System.Drawing.Color.White;
            this.labelIdNo.Location = new System.Drawing.Point(197, 350);
            this.labelIdNo.Name = "labelIdNo";
            this.labelIdNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelIdNo.Size = new System.Drawing.Size(82, 25);
            this.labelIdNo.TabIndex = 1;
            this.labelIdNo.Text = "ID NO.";
            // 
            // labelGreet
            // 
            this.labelGreet.AutoSize = true;
            this.labelGreet.BackColor = System.Drawing.Color.Transparent;
            this.labelGreet.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGreet.ForeColor = System.Drawing.Color.White;
            this.labelGreet.Location = new System.Drawing.Point(45, 261);
            this.labelGreet.Name = "labelGreet";
            this.labelGreet.Size = new System.Drawing.Size(411, 45);
            this.labelGreet.TabIndex = 0;
            this.labelGreet.Text = "WELCOME, ADMIN!";
            // 
            // labelTaytay
            // 
            this.labelTaytay.AutoSize = true;
            this.labelTaytay.BackColor = System.Drawing.Color.Transparent;
            this.labelTaytay.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTaytay.Location = new System.Drawing.Point(504, 613);
            this.labelTaytay.Name = "labelTaytay";
            this.labelTaytay.Size = new System.Drawing.Size(215, 31);
            this.labelTaytay.TabIndex = 7;
            this.labelTaytay.Text = "TAYTAY, RIZAL";
            // 
            // labelSiena
            // 
            this.labelSiena.AutoSize = true;
            this.labelSiena.BackColor = System.Drawing.Color.Transparent;
            this.labelSiena.Font = new System.Drawing.Font("Times New Roman", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSiena.Location = new System.Drawing.Point(374, 541);
            this.labelSiena.Name = "labelSiena";
            this.labelSiena.Size = new System.Drawing.Size(469, 62);
            this.labelSiena.TabIndex = 6;
            this.labelSiena.Text = "SIENA COLLEGE";
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelLogo.BackgroundImage = global::SCTAttendanceSystemUI.Properties.Resources.bw_logo;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLogo.Location = new System.Drawing.Point(504, 369);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 169);
            this.panelLogo.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SCTAttendanceSystemUI.Properties.Resources.BG_LOW_OPACITY;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1666, 822);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.labelTaytay);
            this.Controls.Add(this.labelSiena);
            this.Controls.Add(this.panelColorBg);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1682, 861);
            this.Name = "Form1";
            this.Text = "SCT ATTENDANCE SYSTEM";
            this.panelColorBg.ResumeLayout(false);
            this.panelColorBg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelColorBg;
        private Button buttonLogin;
        private TextBox textBoxPassword;
        private TextBox textBoxIDNum;
        private Label labelPassword;
        private Label labelIdNo;
        private Label labelGreet;
        private Label labelTaytay;
        private Label labelSiena;
        private Panel panelLogo;
    }
}
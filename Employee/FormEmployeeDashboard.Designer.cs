namespace SCTAttendanceSystemUI.Employee
{
    partial class FormEmployeeDashboard
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
            components = new System.ComponentModel.Container();
            labelLoginAs = new Label();
            labelEmployeeName = new Label();
            labelDate = new Label();
            labelTime = new Label();
            panel1 = new Panel();
            logout_tb = new TextBox();
            login_tb = new TextBox();
            RequestLeaveBtn = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelLoginAs
            // 
            labelLoginAs.AutoSize = true;
            labelLoginAs.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelLoginAs.ForeColor = Color.White;
            labelLoginAs.Location = new Point(161, 27);
            labelLoginAs.Name = "labelLoginAs";
            labelLoginAs.Size = new Size(258, 31);
            labelLoginAs.TabIndex = 6;
            labelLoginAs.Text = "You are logged in as:";
            // 
            // labelEmployeeName
            // 
            labelEmployeeName.AutoSize = true;
            labelEmployeeName.Location = new Point(219, 18);
            labelEmployeeName.Name = "labelEmployeeName";
            labelEmployeeName.Size = new Size(0, 15);
            labelEmployeeName.TabIndex = 7;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelDate.ForeColor = Color.Black;
            labelDate.Location = new Point(136, 45);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(73, 23);
            labelDate.TabIndex = 9;
            labelDate.Text = "DATE: ";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelTime.ForeColor = Color.Black;
            labelTime.Location = new Point(136, 92);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(70, 23);
            labelTime.TabIndex = 10;
            labelTime.Text = "TIME: ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(logout_tb);
            panel1.Controls.Add(login_tb);
            panel1.Controls.Add(RequestLeaveBtn);
            panel1.Controls.Add(labelTime);
            panel1.Controls.Add(labelDate);
            panel1.Controls.Add(labelEmployeeName);
            panel1.Location = new Point(116, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(564, 323);
            panel1.TabIndex = 13;
            // 
            // logout_tb
            // 
            logout_tb.Location = new Point(329, 189);
            logout_tb.Name = "logout_tb";
            logout_tb.Size = new Size(100, 23);
            logout_tb.TabIndex = 15;
            logout_tb.TextChanged += logout_tb_TextChanged;
            logout_tb.KeyPress += logout_tb_KeyPress;
            // 
            // login_tb
            // 
            login_tb.Location = new Point(106, 184);
            login_tb.Name = "login_tb";
            login_tb.Size = new Size(100, 23);
            login_tb.TabIndex = 14;
            login_tb.TextChanged += login_tb_TextChanged;
            login_tb.KeyPress += login_tb_KeyPress;
            // 
            // RequestLeaveBtn
            // 
            RequestLeaveBtn.BackColor = Color.FromArgb(255, 121, 0);
            RequestLeaveBtn.FlatStyle = FlatStyle.Flat;
            RequestLeaveBtn.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            RequestLeaveBtn.Location = new Point(192, 247);
            RequestLeaveBtn.Name = "RequestLeaveBtn";
            RequestLeaveBtn.Size = new Size(167, 51);
            RequestLeaveBtn.TabIndex = 13;
            RequestLeaveBtn.Text = "REQUEST LEAVE";
            RequestLeaveBtn.UseVisualStyleBackColor = false;
            RequestLeaveBtn.Click += RequestLeaveBtn_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(425, 36);
            label1.Name = "label1";
            label1.Size = new Size(0, 21);
            label1.TabIndex = 14;
            // 
            // FormEmployeeDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(164, 16, 52);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(labelLoginAs);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEmployeeDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EMPLOYEE DASHBOARD";
            Load += FormEmployeeDashboard_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLoginAs;
        private Label labelEmployeeName;
        private Label labelDate;
        private Label labelTime;
        private Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Button button1;
        private Button RequestLeaveBtn;
        private TextBox login_tb;
        private TextBox logout_tb;
    }
}
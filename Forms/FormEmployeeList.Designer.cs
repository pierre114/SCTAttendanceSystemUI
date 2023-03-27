namespace SCTAttendanceSystemUI.Forms
{
    partial class FormEmployeeList
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
            this.labelEmployeeList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelEmployeeList
            // 
            this.labelEmployeeList.AutoSize = true;
            this.labelEmployeeList.BackColor = System.Drawing.Color.Transparent;
            this.labelEmployeeList.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmployeeList.Location = new System.Drawing.Point(38, 32);
            this.labelEmployeeList.Name = "labelEmployeeList";
            this.labelEmployeeList.Size = new System.Drawing.Size(237, 31);
            this.labelEmployeeList.TabIndex = 9;
            this.labelEmployeeList.Text = "EMPLOYEE LIST";
            // 
            // FormEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::SCTAttendanceSystemUI.Properties.Resources.BG_LOW_OPACITY;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.labelEmployeeList);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "FormEmployeeList";
            this.Text = "FormEmployeeList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelEmployeeList;
    }
}
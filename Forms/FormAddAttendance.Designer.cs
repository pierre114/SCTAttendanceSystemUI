namespace SCTAttendanceSystemUI.Forms
{
    partial class FormAddAttendance
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
            this.panelManualInputs = new System.Windows.Forms.Panel();
            this.textBoxManualClockOut = new System.Windows.Forms.TextBox();
            this.labelManualClockOut = new System.Windows.Forms.Label();
            this.buttonSaveManualInput = new System.Windows.Forms.Button();
            this.textBoxManualClockIn = new System.Windows.Forms.TextBox();
            this.labelManualClockIn = new System.Windows.Forms.Label();
            this.textBoxManualDate = new System.Windows.Forms.TextBox();
            this.labelManualDate = new System.Windows.Forms.Label();
            this.textBoxManualDepartment = new System.Windows.Forms.TextBox();
            this.labelManualName = new System.Windows.Forms.Label();
            this.textBoxManualName = new System.Windows.Forms.TextBox();
            this.labelManualDepartment = new System.Windows.Forms.Label();
            this.labelManualEmployeeNumber = new System.Windows.Forms.Label();
            this.textBoxManualEmployeeNumber = new System.Windows.Forms.TextBox();
            this.labelManualInput = new System.Windows.Forms.Label();
            this.panelAutomaticInputs = new System.Windows.Forms.Panel();
            this.labelAutomaticInputDate = new System.Windows.Forms.Label();
            this.buttonSaveAutomaticInput = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAutomaticClockOut = new System.Windows.Forms.TextBox();
            this.labelAutomaticClockOut = new System.Windows.Forms.Label();
            this.textBoxAutomaticClockIn = new System.Windows.Forms.TextBox();
            this.labelAutomaticClockIn = new System.Windows.Forms.Label();
            this.labelAutomaticDate = new System.Windows.Forms.Label();
            this.textBoxAutomaticDepartment = new System.Windows.Forms.TextBox();
            this.labelAutomaticName = new System.Windows.Forms.Label();
            this.textBoxAutomaticName = new System.Windows.Forms.TextBox();
            this.labelAutomaticDepartment = new System.Windows.Forms.Label();
            this.labelAutomaticEmployeeNumber = new System.Windows.Forms.Label();
            this.textBoxAutomaticEmployeeNumber = new System.Windows.Forms.TextBox();
            this.labelAutomaticInput = new System.Windows.Forms.Label();
            this.panelManualInputs.SuspendLayout();
            this.panelAutomaticInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelManualInputs
            // 
            this.panelManualInputs.AutoScroll = true;
            this.panelManualInputs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.panelManualInputs.Controls.Add(this.textBoxManualClockOut);
            this.panelManualInputs.Controls.Add(this.labelManualClockOut);
            this.panelManualInputs.Controls.Add(this.buttonSaveManualInput);
            this.panelManualInputs.Controls.Add(this.textBoxManualClockIn);
            this.panelManualInputs.Controls.Add(this.labelManualClockIn);
            this.panelManualInputs.Controls.Add(this.textBoxManualDate);
            this.panelManualInputs.Controls.Add(this.labelManualDate);
            this.panelManualInputs.Controls.Add(this.textBoxManualDepartment);
            this.panelManualInputs.Controls.Add(this.labelManualName);
            this.panelManualInputs.Controls.Add(this.textBoxManualName);
            this.panelManualInputs.Controls.Add(this.labelManualDepartment);
            this.panelManualInputs.Controls.Add(this.labelManualEmployeeNumber);
            this.panelManualInputs.Controls.Add(this.textBoxManualEmployeeNumber);
            this.panelManualInputs.Location = new System.Drawing.Point(66, 162);
            this.panelManualInputs.Name = "panelManualInputs";
            this.panelManualInputs.Size = new System.Drawing.Size(717, 462);
            this.panelManualInputs.TabIndex = 3;
            this.panelManualInputs.Paint += new System.Windows.Forms.PaintEventHandler(this.panelManualInputs_Paint);
            // 
            // textBoxManualClockOut
            // 
            this.textBoxManualClockOut.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxManualClockOut.Location = new System.Drawing.Point(280, 300);
            this.textBoxManualClockOut.Name = "textBoxManualClockOut";
            this.textBoxManualClockOut.Size = new System.Drawing.Size(358, 34);
            this.textBoxManualClockOut.TabIndex = 16;
            // 
            // labelManualClockOut
            // 
            this.labelManualClockOut.AutoSize = true;
            this.labelManualClockOut.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelManualClockOut.Location = new System.Drawing.Point(80, 300);
            this.labelManualClockOut.Name = "labelManualClockOut";
            this.labelManualClockOut.Size = new System.Drawing.Size(102, 28);
            this.labelManualClockOut.TabIndex = 15;
            this.labelManualClockOut.Text = "Clock Out:";
            // 
            // buttonSaveManualInput
            // 
            this.buttonSaveManualInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(208)))), ((int)(((byte)(2)))));
            this.buttonSaveManualInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveManualInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveManualInput.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveManualInput.Location = new System.Drawing.Point(270, 376);
            this.buttonSaveManualInput.Name = "buttonSaveManualInput";
            this.buttonSaveManualInput.Size = new System.Drawing.Size(150, 40);
            this.buttonSaveManualInput.TabIndex = 11;
            this.buttonSaveManualInput.Text = "SAVE";
            this.buttonSaveManualInput.UseVisualStyleBackColor = false;
            this.buttonSaveManualInput.Click += new System.EventHandler(this.buttonSaveManualInput_Click);
            // 
            // textBoxManualClockIn
            // 
            this.textBoxManualClockIn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxManualClockIn.Location = new System.Drawing.Point(280, 250);
            this.textBoxManualClockIn.Name = "textBoxManualClockIn";
            this.textBoxManualClockIn.Size = new System.Drawing.Size(358, 34);
            this.textBoxManualClockIn.TabIndex = 14;
            // 
            // labelManualClockIn
            // 
            this.labelManualClockIn.AutoSize = true;
            this.labelManualClockIn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelManualClockIn.Location = new System.Drawing.Point(80, 250);
            this.labelManualClockIn.Name = "labelManualClockIn";
            this.labelManualClockIn.Size = new System.Drawing.Size(85, 28);
            this.labelManualClockIn.TabIndex = 13;
            this.labelManualClockIn.Text = "Clock In:";
            // 
            // textBoxManualDate
            // 
            this.textBoxManualDate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxManualDate.Location = new System.Drawing.Point(280, 200);
            this.textBoxManualDate.Name = "textBoxManualDate";
            this.textBoxManualDate.Size = new System.Drawing.Size(358, 34);
            this.textBoxManualDate.TabIndex = 8;
            // 
            // labelManualDate
            // 
            this.labelManualDate.AutoSize = true;
            this.labelManualDate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelManualDate.Location = new System.Drawing.Point(80, 200);
            this.labelManualDate.Name = "labelManualDate";
            this.labelManualDate.Size = new System.Drawing.Size(57, 28);
            this.labelManualDate.TabIndex = 7;
            this.labelManualDate.Text = "Date:";
            // 
            // textBoxManualDepartment
            // 
            this.textBoxManualDepartment.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxManualDepartment.Location = new System.Drawing.Point(280, 150);
            this.textBoxManualDepartment.Name = "textBoxManualDepartment";
            this.textBoxManualDepartment.Size = new System.Drawing.Size(358, 34);
            this.textBoxManualDepartment.TabIndex = 6;
            // 
            // labelManualName
            // 
            this.labelManualName.AutoSize = true;
            this.labelManualName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelManualName.Location = new System.Drawing.Point(80, 100);
            this.labelManualName.Name = "labelManualName";
            this.labelManualName.Size = new System.Drawing.Size(68, 28);
            this.labelManualName.TabIndex = 5;
            this.labelManualName.Text = "Name:";
            // 
            // textBoxManualName
            // 
            this.textBoxManualName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxManualName.Location = new System.Drawing.Point(280, 100);
            this.textBoxManualName.Name = "textBoxManualName";
            this.textBoxManualName.Size = new System.Drawing.Size(358, 34);
            this.textBoxManualName.TabIndex = 4;
            // 
            // labelManualDepartment
            // 
            this.labelManualDepartment.AutoSize = true;
            this.labelManualDepartment.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelManualDepartment.Location = new System.Drawing.Point(80, 150);
            this.labelManualDepartment.Name = "labelManualDepartment";
            this.labelManualDepartment.Size = new System.Drawing.Size(121, 28);
            this.labelManualDepartment.TabIndex = 3;
            this.labelManualDepartment.Text = "Department:";
            // 
            // labelManualEmployeeNumber
            // 
            this.labelManualEmployeeNumber.AutoSize = true;
            this.labelManualEmployeeNumber.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelManualEmployeeNumber.Location = new System.Drawing.Point(80, 50);
            this.labelManualEmployeeNumber.Name = "labelManualEmployeeNumber";
            this.labelManualEmployeeNumber.Size = new System.Drawing.Size(179, 28);
            this.labelManualEmployeeNumber.TabIndex = 2;
            this.labelManualEmployeeNumber.Text = "Employee Number:";
            this.labelManualEmployeeNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxManualEmployeeNumber
            // 
            this.textBoxManualEmployeeNumber.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxManualEmployeeNumber.Location = new System.Drawing.Point(280, 50);
            this.textBoxManualEmployeeNumber.Name = "textBoxManualEmployeeNumber";
            this.textBoxManualEmployeeNumber.Size = new System.Drawing.Size(358, 34);
            this.textBoxManualEmployeeNumber.TabIndex = 1;
            this.textBoxManualEmployeeNumber.TextChanged += new System.EventHandler(this.textBoxManualEmployeeNumber_TextChanged);
            // 
            // labelManualInput
            // 
            this.labelManualInput.AutoSize = true;
            this.labelManualInput.BackColor = System.Drawing.Color.Transparent;
            this.labelManualInput.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelManualInput.Location = new System.Drawing.Point(66, 101);
            this.labelManualInput.Name = "labelManualInput";
            this.labelManualInput.Size = new System.Drawing.Size(176, 31);
            this.labelManualInput.TabIndex = 0;
            this.labelManualInput.Text = "Manual Input";
            // 
            // panelAutomaticInputs
            // 
            this.panelAutomaticInputs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.panelAutomaticInputs.Controls.Add(this.labelAutomaticInputDate);
            this.panelAutomaticInputs.Controls.Add(this.buttonSaveAutomaticInput);
            this.panelAutomaticInputs.Controls.Add(this.label2);
            this.panelAutomaticInputs.Controls.Add(this.textBoxAutomaticClockOut);
            this.panelAutomaticInputs.Controls.Add(this.labelAutomaticClockOut);
            this.panelAutomaticInputs.Controls.Add(this.textBoxAutomaticClockIn);
            this.panelAutomaticInputs.Controls.Add(this.labelAutomaticClockIn);
            this.panelAutomaticInputs.Controls.Add(this.labelAutomaticDate);
            this.panelAutomaticInputs.Controls.Add(this.textBoxAutomaticDepartment);
            this.panelAutomaticInputs.Controls.Add(this.labelAutomaticName);
            this.panelAutomaticInputs.Controls.Add(this.textBoxAutomaticName);
            this.panelAutomaticInputs.Controls.Add(this.labelAutomaticDepartment);
            this.panelAutomaticInputs.Controls.Add(this.labelAutomaticEmployeeNumber);
            this.panelAutomaticInputs.Controls.Add(this.textBoxAutomaticEmployeeNumber);
            this.panelAutomaticInputs.Location = new System.Drawing.Point(869, 162);
            this.panelAutomaticInputs.Name = "panelAutomaticInputs";
            this.panelAutomaticInputs.Size = new System.Drawing.Size(717, 462);
            this.panelAutomaticInputs.TabIndex = 4;
            // 
            // labelAutomaticInputDate
            // 
            this.labelAutomaticInputDate.AutoSize = true;
            this.labelAutomaticInputDate.BackColor = System.Drawing.Color.Transparent;
            this.labelAutomaticInputDate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAutomaticInputDate.Location = new System.Drawing.Point(295, 200);
            this.labelAutomaticInputDate.Name = "labelAutomaticInputDate";
            this.labelAutomaticInputDate.Size = new System.Drawing.Size(67, 28);
            this.labelAutomaticInputDate.TabIndex = 18;
            this.labelAutomaticInputDate.Text = "DATE: ";
            // 
            // buttonSaveAutomaticInput
            // 
            this.buttonSaveAutomaticInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(208)))), ((int)(((byte)(2)))));
            this.buttonSaveAutomaticInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveAutomaticInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveAutomaticInput.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveAutomaticInput.Location = new System.Drawing.Point(295, 376);
            this.buttonSaveAutomaticInput.Name = "buttonSaveAutomaticInput";
            this.buttonSaveAutomaticInput.Size = new System.Drawing.Size(150, 40);
            this.buttonSaveAutomaticInput.TabIndex = 12;
            this.buttonSaveAutomaticInput.Text = "SAVE";
            this.buttonSaveAutomaticInput.UseVisualStyleBackColor = false;
            this.buttonSaveAutomaticInput.Click += new System.EventHandler(this.buttonSaveAutomaticInput_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 850);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 33;
            // 
            // textBoxAutomaticClockOut
            // 
            this.textBoxAutomaticClockOut.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAutomaticClockOut.Location = new System.Drawing.Point(295, 300);
            this.textBoxAutomaticClockOut.Name = "textBoxAutomaticClockOut";
            this.textBoxAutomaticClockOut.Size = new System.Drawing.Size(358, 34);
            this.textBoxAutomaticClockOut.TabIndex = 16;
            // 
            // labelAutomaticClockOut
            // 
            this.labelAutomaticClockOut.AutoSize = true;
            this.labelAutomaticClockOut.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAutomaticClockOut.Location = new System.Drawing.Point(80, 300);
            this.labelAutomaticClockOut.Name = "labelAutomaticClockOut";
            this.labelAutomaticClockOut.Size = new System.Drawing.Size(102, 28);
            this.labelAutomaticClockOut.TabIndex = 15;
            this.labelAutomaticClockOut.Text = "Clock Out:";
            // 
            // textBoxAutomaticClockIn
            // 
            this.textBoxAutomaticClockIn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAutomaticClockIn.Location = new System.Drawing.Point(295, 250);
            this.textBoxAutomaticClockIn.Name = "textBoxAutomaticClockIn";
            this.textBoxAutomaticClockIn.Size = new System.Drawing.Size(358, 34);
            this.textBoxAutomaticClockIn.TabIndex = 14;
            // 
            // labelAutomaticClockIn
            // 
            this.labelAutomaticClockIn.AutoSize = true;
            this.labelAutomaticClockIn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAutomaticClockIn.Location = new System.Drawing.Point(80, 250);
            this.labelAutomaticClockIn.Name = "labelAutomaticClockIn";
            this.labelAutomaticClockIn.Size = new System.Drawing.Size(85, 28);
            this.labelAutomaticClockIn.TabIndex = 13;
            this.labelAutomaticClockIn.Text = "Clock In:";
            // 
            // labelAutomaticDate
            // 
            this.labelAutomaticDate.AutoSize = true;
            this.labelAutomaticDate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAutomaticDate.Location = new System.Drawing.Point(80, 200);
            this.labelAutomaticDate.Name = "labelAutomaticDate";
            this.labelAutomaticDate.Size = new System.Drawing.Size(57, 28);
            this.labelAutomaticDate.TabIndex = 7;
            this.labelAutomaticDate.Text = "Date:";
            // 
            // textBoxAutomaticDepartment
            // 
            this.textBoxAutomaticDepartment.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAutomaticDepartment.Location = new System.Drawing.Point(295, 150);
            this.textBoxAutomaticDepartment.Name = "textBoxAutomaticDepartment";
            this.textBoxAutomaticDepartment.Size = new System.Drawing.Size(358, 34);
            this.textBoxAutomaticDepartment.TabIndex = 6;
            // 
            // labelAutomaticName
            // 
            this.labelAutomaticName.AutoSize = true;
            this.labelAutomaticName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAutomaticName.Location = new System.Drawing.Point(80, 100);
            this.labelAutomaticName.Name = "labelAutomaticName";
            this.labelAutomaticName.Size = new System.Drawing.Size(68, 28);
            this.labelAutomaticName.TabIndex = 5;
            this.labelAutomaticName.Text = "Name:";
            // 
            // textBoxAutomaticName
            // 
            this.textBoxAutomaticName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAutomaticName.Location = new System.Drawing.Point(295, 100);
            this.textBoxAutomaticName.Name = "textBoxAutomaticName";
            this.textBoxAutomaticName.Size = new System.Drawing.Size(358, 34);
            this.textBoxAutomaticName.TabIndex = 4;
            // 
            // labelAutomaticDepartment
            // 
            this.labelAutomaticDepartment.AutoSize = true;
            this.labelAutomaticDepartment.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAutomaticDepartment.Location = new System.Drawing.Point(80, 150);
            this.labelAutomaticDepartment.Name = "labelAutomaticDepartment";
            this.labelAutomaticDepartment.Size = new System.Drawing.Size(121, 28);
            this.labelAutomaticDepartment.TabIndex = 3;
            this.labelAutomaticDepartment.Text = "Department:";
            // 
            // labelAutomaticEmployeeNumber
            // 
            this.labelAutomaticEmployeeNumber.AutoSize = true;
            this.labelAutomaticEmployeeNumber.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAutomaticEmployeeNumber.Location = new System.Drawing.Point(80, 50);
            this.labelAutomaticEmployeeNumber.Name = "labelAutomaticEmployeeNumber";
            this.labelAutomaticEmployeeNumber.Size = new System.Drawing.Size(179, 28);
            this.labelAutomaticEmployeeNumber.TabIndex = 2;
            this.labelAutomaticEmployeeNumber.Text = "Employee Number:";
            // 
            // textBoxAutomaticEmployeeNumber
            // 
            this.textBoxAutomaticEmployeeNumber.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAutomaticEmployeeNumber.Location = new System.Drawing.Point(295, 40);
            this.textBoxAutomaticEmployeeNumber.Name = "textBoxAutomaticEmployeeNumber";
            this.textBoxAutomaticEmployeeNumber.Size = new System.Drawing.Size(358, 34);
            this.textBoxAutomaticEmployeeNumber.TabIndex = 1;
            // 
            // labelAutomaticInput
            // 
            this.labelAutomaticInput.AutoSize = true;
            this.labelAutomaticInput.BackColor = System.Drawing.Color.Transparent;
            this.labelAutomaticInput.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAutomaticInput.Location = new System.Drawing.Point(869, 101);
            this.labelAutomaticInput.Name = "labelAutomaticInput";
            this.labelAutomaticInput.Size = new System.Drawing.Size(207, 31);
            this.labelAutomaticInput.TabIndex = 13;
            this.labelAutomaticInput.Text = "Automatic Input";
            // 
            // FormAddAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SCTAttendanceSystemUI.Properties.Resources.BG_LOW_OPACITY;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.labelAutomaticInput);
            this.Controls.Add(this.panelAutomaticInputs);
            this.Controls.Add(this.panelManualInputs);
            this.Controls.Add(this.labelManualInput);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "FormAddAttendance";
            this.Text = "FormAddAttendance";
            this.Load += new System.EventHandler(this.FormAddAttendance_Load);
            this.panelManualInputs.ResumeLayout(false);
            this.panelManualInputs.PerformLayout();
            this.panelAutomaticInputs.ResumeLayout(false);
            this.panelAutomaticInputs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelManualInput;
        private Label labelManualEmployeeNumber;
        private TextBox textBoxManualEmployeeNumber;
        private Panel panelManualInputs;
        private Label labelManualDepartment;
        private Label labelManualName;
        private TextBox textBoxManualName;
        private TextBox textBoxManualDate;
        private Label labelManualDate;
        private TextBox textBoxManualClockIn;
        private Label labelManualClockIn;
        private TextBox textBoxManualClockOut;
        private Label labelManualClockOut;
        private Panel panelAutomaticInputs;
        private Label label2;
        private TextBox textBoxAutomaticClockOut;
        private Label labelAutomaticClockOut;
        private TextBox textBoxAutomaticClockIn;
        private Label labelAutomaticClockIn;
        private Label labelAutomaticDate;
        private Label labelAutomaticName;
        private TextBox textBoxAutomaticName;
        private Label labelAutomaticDepartment;
        private Label labelAutomaticEmployeeNumber;
        private TextBox textBoxAutomaticEmployeeNumber;
        private Button buttonSaveManualInput;
        private Button buttonSaveAutomaticInput;
        private Label labelAutomaticInput;
        private Label labelAutomaticInputDate;
        private TextBox textBoxAutomaticDepartment;
        private TextBox textBoxManualDepartment;
    }
}
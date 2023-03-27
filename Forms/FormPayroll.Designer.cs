namespace SCTAttendanceSystemUI.Forms
{
    partial class FormPayroll
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
            this.labelPayroll = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonDateTimePicker = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.labelSort = new System.Windows.Forms.Label();
            this.sortENcomboBox = new System.Windows.Forms.ComboBox();
            this.buttonOvertimeAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelFormOvertime = new System.Windows.Forms.Panel();
            this.labelNetPay = new System.Windows.Forms.Label();
            this.labelCashAdvance = new System.Windows.Forms.Label();
            this.labelDeduction = new System.Windows.Forms.Label();
            this.labelGrossPay = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelEmployeeNo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelFormOvertime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPayroll
            // 
            this.labelPayroll.AutoSize = true;
            this.labelPayroll.BackColor = System.Drawing.Color.Transparent;
            this.labelPayroll.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPayroll.Location = new System.Drawing.Point(38, 32);
            this.labelPayroll.Name = "labelPayroll";
            this.labelPayroll.Size = new System.Drawing.Size(143, 31);
            this.labelPayroll.TabIndex = 8;
            this.labelPayroll.Text = "PAYROLL";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelFrom.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFrom.Location = new System.Drawing.Point(870, 16);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(46, 17);
            this.labelFrom.TabIndex = 35;
            this.labelFrom.Text = "From:";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelTo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTo.Location = new System.Drawing.Point(870, 48);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(27, 17);
            this.labelTo.TabIndex = 36;
            this.labelTo.Text = "To:";
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.CustomFormat = "MM/dd/yyyy";
            this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDateTimePicker.Location = new System.Drawing.Point(919, 13);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(88, 23);
            this.fromDateTimePicker.TabIndex = 37;
            this.fromDateTimePicker.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.CustomFormat = "MM/dd/yyyy";
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDateTimePicker.Location = new System.Drawing.Point(919, 42);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(88, 23);
            this.toDateTimePicker.TabIndex = 38;
            this.toDateTimePicker.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // buttonDateTimePicker
            // 
            this.buttonDateTimePicker.BackColor = System.Drawing.Color.White;
            this.buttonDateTimePicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDateTimePicker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDateTimePicker.Location = new System.Drawing.Point(1015, 13);
            this.buttonDateTimePicker.Name = "buttonDateTimePicker";
            this.buttonDateTimePicker.Size = new System.Drawing.Size(49, 23);
            this.buttonDateTimePicker.TabIndex = 39;
            this.buttonDateTimePicker.Text = "Filter";
            this.buttonDateTimePicker.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(1015, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1094, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Sort:";
            // 
            // sortComboBox
            // 
            this.sortComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.sortComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortComboBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "None",
            "A - Z",
            "Z - A"});
            this.sortComboBox.Location = new System.Drawing.Point(1138, 13);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(142, 23);
            this.sortComboBox.TabIndex = 42;
            this.sortComboBox.Text = "NAME";
            // 
            // labelSort
            // 
            this.labelSort.AutoSize = true;
            this.labelSort.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelSort.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSort.Location = new System.Drawing.Point(1094, 42);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(39, 17);
            this.labelSort.TabIndex = 43;
            this.labelSort.Text = "Sort:";
            // 
            // sortENcomboBox
            // 
            this.sortENcomboBox.BackColor = System.Drawing.SystemColors.Control;
            this.sortENcomboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortENcomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortENcomboBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sortENcomboBox.FormattingEnabled = true;
            this.sortENcomboBox.Items.AddRange(new object[] {
            "None",
            "Highest",
            "Lowest"});
            this.sortENcomboBox.Location = new System.Drawing.Point(1138, 42);
            this.sortENcomboBox.Name = "sortENcomboBox";
            this.sortENcomboBox.Size = new System.Drawing.Size(142, 23);
            this.sortENcomboBox.TabIndex = 44;
            this.sortENcomboBox.Text = "EMPLOYEE NUMBER";
            // 
            // buttonOvertimeAdd
            // 
            this.buttonOvertimeAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(221)))), ((int)(((byte)(132)))));
            this.buttonOvertimeAdd.FlatAppearance.BorderSize = 0;
            this.buttonOvertimeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOvertimeAdd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonOvertimeAdd.Image = global::SCTAttendanceSystemUI.Properties.Resources.export;
            this.buttonOvertimeAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOvertimeAdd.Location = new System.Drawing.Point(609, 29);
            this.buttonOvertimeAdd.Name = "buttonOvertimeAdd";
            this.buttonOvertimeAdd.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonOvertimeAdd.Size = new System.Drawing.Size(100, 30);
            this.buttonOvertimeAdd.TabIndex = 45;
            this.buttonOvertimeAdd.Text = "  PAYROLL";
            this.buttonOvertimeAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOvertimeAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOvertimeAdd.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(191)))), ((int)(((byte)(227)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = global::SCTAttendanceSystemUI.Properties.Resources.export;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(732, 29);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 46;
            this.button2.Text = "   PAYSLIP";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panelFormOvertime
            // 
            this.panelFormOvertime.BackColor = System.Drawing.Color.White;
            this.panelFormOvertime.Controls.Add(this.labelNetPay);
            this.panelFormOvertime.Controls.Add(this.labelCashAdvance);
            this.panelFormOvertime.Controls.Add(this.labelDeduction);
            this.panelFormOvertime.Controls.Add(this.labelGrossPay);
            this.panelFormOvertime.Controls.Add(this.labelFullName);
            this.panelFormOvertime.Controls.Add(this.labelEmployeeNo);
            this.panelFormOvertime.Location = new System.Drawing.Point(51, 90);
            this.panelFormOvertime.Name = "panelFormOvertime";
            this.panelFormOvertime.Size = new System.Drawing.Size(1237, 80);
            this.panelFormOvertime.TabIndex = 47;
            // 
            // labelNetPay
            // 
            this.labelNetPay.AutoSize = true;
            this.labelNetPay.BackColor = System.Drawing.Color.Transparent;
            this.labelNetPay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNetPay.ForeColor = System.Drawing.Color.Gray;
            this.labelNetPay.Location = new System.Drawing.Point(1090, 29);
            this.labelNetPay.Name = "labelNetPay";
            this.labelNetPay.Size = new System.Drawing.Size(74, 21);
            this.labelNetPay.TabIndex = 28;
            this.labelNetPay.Text = "NET PAY";
            // 
            // labelCashAdvance
            // 
            this.labelCashAdvance.AutoSize = true;
            this.labelCashAdvance.BackColor = System.Drawing.Color.Transparent;
            this.labelCashAdvance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCashAdvance.ForeColor = System.Drawing.Color.Gray;
            this.labelCashAdvance.Location = new System.Drawing.Point(857, 29);
            this.labelCashAdvance.Name = "labelCashAdvance";
            this.labelCashAdvance.Size = new System.Drawing.Size(132, 21);
            this.labelCashAdvance.TabIndex = 27;
            this.labelCashAdvance.Text = "CASH ADVANCE";
            // 
            // labelDeduction
            // 
            this.labelDeduction.AutoSize = true;
            this.labelDeduction.BackColor = System.Drawing.Color.Transparent;
            this.labelDeduction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDeduction.ForeColor = System.Drawing.Color.Gray;
            this.labelDeduction.Location = new System.Drawing.Point(652, 29);
            this.labelDeduction.Name = "labelDeduction";
            this.labelDeduction.Size = new System.Drawing.Size(104, 21);
            this.labelDeduction.TabIndex = 26;
            this.labelDeduction.Text = "DEDUCTION";
            // 
            // labelGrossPay
            // 
            this.labelGrossPay.AutoSize = true;
            this.labelGrossPay.BackColor = System.Drawing.Color.Transparent;
            this.labelGrossPay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGrossPay.ForeColor = System.Drawing.Color.Gray;
            this.labelGrossPay.Location = new System.Drawing.Point(448, 29);
            this.labelGrossPay.Name = "labelGrossPay";
            this.labelGrossPay.Size = new System.Drawing.Size(94, 21);
            this.labelGrossPay.TabIndex = 25;
            this.labelGrossPay.Text = "GROSS PAY";
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.BackColor = System.Drawing.Color.Transparent;
            this.labelFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFullName.ForeColor = System.Drawing.Color.Gray;
            this.labelFullName.Location = new System.Drawing.Point(255, 29);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(98, 21);
            this.labelFullName.TabIndex = 24;
            this.labelFullName.Text = "FULL NAME";
            // 
            // labelEmployeeNo
            // 
            this.labelEmployeeNo.AutoSize = true;
            this.labelEmployeeNo.BackColor = System.Drawing.Color.Transparent;
            this.labelEmployeeNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmployeeNo.ForeColor = System.Drawing.Color.Gray;
            this.labelEmployeeNo.Location = new System.Drawing.Point(54, 29);
            this.labelEmployeeNo.Name = "labelEmployeeNo";
            this.labelEmployeeNo.Size = new System.Drawing.Size(124, 21);
            this.labelEmployeeNo.TabIndex = 23;
            this.labelEmployeeNo.Text = "EMPLOYEE NO.";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1237, 514);
            this.dataGridView1.TabIndex = 48;
            // 
            // FormPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::SCTAttendanceSystemUI.Properties.Resources.BG_LOW_OPACITY;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelFormOvertime);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonOvertimeAdd);
            this.Controls.Add(this.sortENcomboBox);
            this.Controls.Add(this.labelSort);
            this.Controls.Add(this.sortComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDateTimePicker);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.labelPayroll);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "FormPayroll";
            this.Text = "FormPayroll";
            this.panelFormOvertime.ResumeLayout(false);
            this.panelFormOvertime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelPayroll;
        private Label labelFrom;
        private Label labelTo;
        private DateTimePicker fromDateTimePicker;
        private DateTimePicker toDateTimePicker;
        private Button buttonDateTimePicker;
        private Button button1;
        private Label label1;
        private ComboBox sortComboBox;
        private Label labelSort;
        private ComboBox sortENcomboBox;
        private Button buttonOvertimeAdd;
        private Button button2;
        private Panel panelFormOvertime;
        private Label labelEmployeeNo;
        private Label labelNetPay;
        private Label labelCashAdvance;
        private Label labelDeduction;
        private Label labelGrossPay;
        private Label labelFullName;
        private DataGridView dataGridView1;
    }
}
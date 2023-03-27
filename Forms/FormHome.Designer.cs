namespace SCTAttendanceSystemUI.Forms
{
    partial class FormHome
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
            this.labelDashboard = new System.Windows.Forms.Label();
            this.panelFormHome = new System.Windows.Forms.Panel();
            this.buttonExport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSheet = new System.Windows.Forms.ComboBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.labelDashboardDate = new System.Windows.Forms.Label();
            this.sortENcomboBox = new System.Windows.Forms.ComboBox();
            this.labelSort = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewDashboard = new System.Windows.Forms.DataGridView();
            this.buttonDateTimePicker = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.panelFormHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDashboard
            // 
            this.labelDashboard.AutoSize = true;
            this.labelDashboard.BackColor = System.Drawing.Color.Transparent;
            this.labelDashboard.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDashboard.Location = new System.Drawing.Point(38, 32);
            this.labelDashboard.Name = "labelDashboard";
            this.labelDashboard.Size = new System.Drawing.Size(187, 31);
            this.labelDashboard.TabIndex = 3;
            this.labelDashboard.Text = "DASHBOARD";
            // 
            // panelFormHome
            // 
            this.panelFormHome.Controls.Add(this.buttonExport);
            this.panelFormHome.Controls.Add(this.label3);
            this.panelFormHome.Controls.Add(this.cboSheet);
            this.panelFormHome.Controls.Add(this.btnBrowse);
            this.panelFormHome.Controls.Add(this.label2);
            this.panelFormHome.Controls.Add(this.txtFilename);
            this.panelFormHome.Location = new System.Drawing.Point(62, 83);
            this.panelFormHome.Name = "panelFormHome";
            this.panelFormHome.Size = new System.Drawing.Size(1237, 80);
            this.panelFormHome.TabIndex = 10;
            this.panelFormHome.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFormHome_Paint);
            // 
            // buttonExport
            // 
            this.buttonExport.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExport.Location = new System.Drawing.Point(1138, 32);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 23);
            this.buttonExport.TabIndex = 38;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(962, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Sheet:";
            // 
            // cboSheet
            // 
            this.cboSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSheet.FormattingEnabled = true;
            this.cboSheet.Location = new System.Drawing.Point(1006, 32);
            this.cboSheet.Name = "cboSheet";
            this.cboSheet.Size = new System.Drawing.Size(121, 23);
            this.cboSheet.TabIndex = 24;
            this.cboSheet.SelectedIndexChanged += new System.EventHandler(this.cboSheet_SelectedIndexChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(858, 32);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "File Name:";
            // 
            // txtFilename
            // 
            this.txtFilename.BackColor = System.Drawing.SystemColors.Control;
            this.txtFilename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilename.Location = new System.Drawing.Point(111, 32);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.ReadOnly = true;
            this.txtFilename.Size = new System.Drawing.Size(726, 23);
            this.txtFilename.TabIndex = 24;
            // 
            // labelDashboardDate
            // 
            this.labelDashboardDate.AutoSize = true;
            this.labelDashboardDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDashboardDate.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDashboardDate.Location = new System.Drawing.Point(376, 38);
            this.labelDashboardDate.Name = "labelDashboardDate";
            this.labelDashboardDate.Size = new System.Drawing.Size(84, 25);
            this.labelDashboardDate.TabIndex = 17;
            this.labelDashboardDate.Text = "DATE: ";
            this.labelDashboardDate.Click += new System.EventHandler(this.labelDashboardDate_Click);
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
            this.sortENcomboBox.TabIndex = 18;
            this.sortENcomboBox.Text = "EMPLOYEE NUMBER";
            this.sortENcomboBox.SelectedIndexChanged += new System.EventHandler(this.sortENcomboBox_SelectedIndexChanged);
            // 
            // labelSort
            // 
            this.labelSort.AutoSize = true;
            this.labelSort.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelSort.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSort.Location = new System.Drawing.Point(1094, 42);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(39, 17);
            this.labelSort.TabIndex = 19;
            this.labelSort.Text = "Sort:";
            this.labelSort.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1094, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 20;
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
            this.sortComboBox.TabIndex = 21;
            this.sortComboBox.Text = "NAME";
            this.sortComboBox.SelectedIndexChanged += new System.EventHandler(this.sortCombBox_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(62, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1237, 514);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // dataGridViewDashboard
            // 
            this.dataGridViewDashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDashboard.Location = new System.Drawing.Point(62, 186);
            this.dataGridViewDashboard.Name = "dataGridViewDashboard";
            this.dataGridViewDashboard.RowTemplate.Height = 25;
            this.dataGridViewDashboard.Size = new System.Drawing.Size(1237, 514);
            this.dataGridViewDashboard.TabIndex = 5;
            // 
            // buttonDateTimePicker
            // 
            this.buttonDateTimePicker.BackColor = System.Drawing.Color.White;
            this.buttonDateTimePicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDateTimePicker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDateTimePicker.Location = new System.Drawing.Point(1015, 13);
            this.buttonDateTimePicker.Name = "buttonDateTimePicker";
            this.buttonDateTimePicker.Size = new System.Drawing.Size(49, 23);
            this.buttonDateTimePicker.TabIndex = 36;
            this.buttonDateTimePicker.Text = "Filter";
            this.buttonDateTimePicker.UseVisualStyleBackColor = false;
            this.buttonDateTimePicker.Click += new System.EventHandler(this.buttonDateTimePicker_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(870, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "To:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(870, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "From:";
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.CustomFormat = "MM/dd/yyyy";
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDateTimePicker.Location = new System.Drawing.Point(919, 42);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(88, 23);
            this.toDateTimePicker.TabIndex = 32;
            this.toDateTimePicker.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.CustomFormat = "MM/dd/yyyy";
            this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDateTimePicker.Location = new System.Drawing.Point(919, 13);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(88, 23);
            this.fromDateTimePicker.TabIndex = 33;
            this.fromDateTimePicker.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(1015, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::SCTAttendanceSystemUI.Properties.Resources.BG_LOW_OPACITY;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1666, 822);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sortComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSort);
            this.Controls.Add(this.sortENcomboBox);
            this.Controls.Add(this.labelDashboardDate);
            this.Controls.Add(this.panelFormHome);
            this.Controls.Add(this.dataGridViewDashboard);
            this.Controls.Add(this.labelDashboard);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1680, 821);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.BackgroundImageChanged += new System.EventHandler(this.FormHome_BackgroundImageChanged);
            this.panelFormHome.ResumeLayout(false);
            this.panelFormHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDashboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelDashboard;
        private Panel panelFormHome;
        private Label labelDashboardDate;
        private ComboBox sortENcomboBox;
        private Label labelSort;
        private Label label1;
        private ComboBox sortComboBox;
        private Label label3;
        private ComboBox cboSheet;
        private Button btnBrowse;
        private Label label2;
        private TextBox txtFilename;
        private DataGridView dataGridView1;
        private DataGridView dataGridViewDashboard;
        private Button buttonDateTimePicker;
        private Label label6;
        private Label label7;
        private DateTimePicker toDateTimePicker;
        private DateTimePicker fromDateTimePicker;
        private Button button1;
        private Button buttonExport;
    }
}
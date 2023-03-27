namespace SCTAttendanceSystemUI.Forms
{
    partial class FormIBED
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
            this.labelIbedDepartment = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelIbedDepartment = new System.Windows.Forms.Panel();
            this.buttonExport = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboSheet = new System.Windows.Forms.ComboBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSort = new System.Windows.Forms.Label();
            this.sortENcomboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelIbedDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIbedDepartment
            // 
            this.labelIbedDepartment.AutoSize = true;
            this.labelIbedDepartment.BackColor = System.Drawing.Color.Transparent;
            this.labelIbedDepartment.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIbedDepartment.Location = new System.Drawing.Point(38, 32);
            this.labelIbedDepartment.Name = "labelIbedDepartment";
            this.labelIbedDepartment.Size = new System.Drawing.Size(277, 31);
            this.labelIbedDepartment.TabIndex = 8;
            this.labelIbedDepartment.Text = "IBED DEPARTMENT";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(62, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1237, 514);
            this.dataGridView1.TabIndex = 10;
            // 
            // panelIbedDepartment
            // 
            this.panelIbedDepartment.Controls.Add(this.buttonExport);
            this.panelIbedDepartment.Controls.Add(this.label4);
            this.panelIbedDepartment.Controls.Add(this.cboSheet);
            this.panelIbedDepartment.Controls.Add(this.btnBrowse);
            this.panelIbedDepartment.Controls.Add(this.label3);
            this.panelIbedDepartment.Controls.Add(this.txtFilename);
            this.panelIbedDepartment.Location = new System.Drawing.Point(62, 83);
            this.panelIbedDepartment.Name = "panelIbedDepartment";
            this.panelIbedDepartment.Size = new System.Drawing.Size(1237, 80);
            this.panelIbedDepartment.TabIndex = 13;
            // 
            // buttonExport
            // 
            this.buttonExport.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExport.Location = new System.Drawing.Point(1138, 30);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 23);
            this.buttonExport.TabIndex = 39;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(962, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Sheet:";
            // 
            // cboSheet
            // 
            this.cboSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSheet.FormattingEnabled = true;
            this.cboSheet.Location = new System.Drawing.Point(1006, 31);
            this.cboSheet.Name = "cboSheet";
            this.cboSheet.Size = new System.Drawing.Size(121, 23);
            this.cboSheet.TabIndex = 32;
            this.cboSheet.SelectionChangeCommitted += new System.EventHandler(this.cboSheet_SelectionChangeCommitted);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(858, 31);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 30;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "File Name:";
            // 
            // txtFilename
            // 
            this.txtFilename.BackColor = System.Drawing.SystemColors.Control;
            this.txtFilename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilename.Location = new System.Drawing.Point(111, 32);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.ReadOnly = true;
            this.txtFilename.Size = new System.Drawing.Size(736, 23);
            this.txtFilename.TabIndex = 33;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(62, 186);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(1237, 514);
            this.dataGridView2.TabIndex = 32;
            this.dataGridView2.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView2_CellFormatting);
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
            this.sortComboBox.Location = new System.Drawing.Point(919, 12);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(124, 23);
            this.sortComboBox.TabIndex = 36;
            this.sortComboBox.Text = "NAME";
            this.sortComboBox.SelectedIndexChanged += new System.EventHandler(this.sortComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(875, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Sort:";
            // 
            // labelSort
            // 
            this.labelSort.AutoSize = true;
            this.labelSort.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelSort.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSort.Location = new System.Drawing.Point(875, 44);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(39, 17);
            this.labelSort.TabIndex = 34;
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
            this.sortENcomboBox.Location = new System.Drawing.Point(919, 41);
            this.sortENcomboBox.Name = "sortENcomboBox";
            this.sortENcomboBox.Size = new System.Drawing.Size(124, 23);
            this.sortENcomboBox.TabIndex = 33;
            this.sortENcomboBox.Text = "EMPLOYEE NO.";
            this.sortENcomboBox.SelectedIndexChanged += new System.EventHandler(this.sortENcomboBox_SelectedIndexChanged);
            // 
            // FormIBED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::SCTAttendanceSystemUI.Properties.Resources.BG_LOW_OPACITY;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.sortComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSort);
            this.Controls.Add(this.sortENcomboBox);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panelIbedDepartment);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelIbedDepartment);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "FormIBED";
            this.Text = "FormIBED";
            this.Load += new System.EventHandler(this.FormIBED_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelIbedDepartment.ResumeLayout(false);
            this.panelIbedDepartment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelIbedDepartment;
        private DataGridView dataGridView1;
        private Panel panelIbedDepartment;
        private Label label4;
        private ComboBox cboSheet;
        private Button btnBrowse;
        private Label label3;
        private TextBox txtFilename;
        private DataGridView dataGridView2;
        private ComboBox sortComboBox;
        private Label label1;
        private Label labelSort;
        private ComboBox sortENcomboBox;
        private Button buttonExport;
    }
}
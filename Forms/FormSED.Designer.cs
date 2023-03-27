namespace SCTAttendanceSystemUI.Forms
{
    partial class FormSED
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
            this.labelSedDepartment = new System.Windows.Forms.Label();
            this.panelSedDepartment = new System.Windows.Forms.Panel();
            this.buttonExport = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboSheet = new System.Windows.Forms.ComboBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSort = new System.Windows.Forms.Label();
            this.sortENcomboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panelSedDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSedDepartment
            // 
            this.labelSedDepartment.AutoSize = true;
            this.labelSedDepartment.BackColor = System.Drawing.Color.Transparent;
            this.labelSedDepartment.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSedDepartment.Location = new System.Drawing.Point(38, 32);
            this.labelSedDepartment.Name = "labelSedDepartment";
            this.labelSedDepartment.Size = new System.Drawing.Size(264, 31);
            this.labelSedDepartment.TabIndex = 5;
            this.labelSedDepartment.Text = "SED DEPARTMENT";
            // 
            // panelSedDepartment
            // 
            this.panelSedDepartment.Controls.Add(this.buttonExport);
            this.panelSedDepartment.Controls.Add(this.label4);
            this.panelSedDepartment.Controls.Add(this.cboSheet);
            this.panelSedDepartment.Controls.Add(this.btnBrowse);
            this.panelSedDepartment.Controls.Add(this.label3);
            this.panelSedDepartment.Controls.Add(this.txtFilename);
            this.panelSedDepartment.Location = new System.Drawing.Point(62, 83);
            this.panelSedDepartment.Name = "panelSedDepartment";
            this.panelSedDepartment.Size = new System.Drawing.Size(1237, 80);
            this.panelSedDepartment.TabIndex = 14;
            // 
            // buttonExport
            // 
            this.buttonExport.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExport.Location = new System.Drawing.Point(1138, 30);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 23);
            this.buttonExport.TabIndex = 42;
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
            this.label4.TabIndex = 39;
            this.label4.Text = "Sheet:";
            // 
            // cboSheet
            // 
            this.cboSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSheet.FormattingEnabled = true;
            this.cboSheet.Location = new System.Drawing.Point(1006, 31);
            this.cboSheet.Name = "cboSheet";
            this.cboSheet.Size = new System.Drawing.Size(121, 23);
            this.cboSheet.TabIndex = 37;
            this.cboSheet.SelectionChangeCommitted += new System.EventHandler(this.cboSheet_SelectionChangeCommitted);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(858, 31);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 35;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "File Name:";
            // 
            // txtFilename
            // 
            this.txtFilename.BackColor = System.Drawing.SystemColors.Control;
            this.txtFilename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilename.Location = new System.Drawing.Point(106, 31);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.ReadOnly = true;
            this.txtFilename.Size = new System.Drawing.Size(742, 23);
            this.txtFilename.TabIndex = 38;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(62, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1237, 514);
            this.dataGridView1.TabIndex = 15;
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
            this.sortComboBox.TabIndex = 40;
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
            this.label1.TabIndex = 39;
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
            this.labelSort.TabIndex = 38;
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
            this.sortENcomboBox.TabIndex = 37;
            this.sortENcomboBox.Text = "EMPLOYEE NO.";
            this.sortENcomboBox.SelectedIndexChanged += new System.EventHandler(this.sortENcomboBox_SelectedIndexChanged);
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
            this.dataGridView2.TabIndex = 41;
            this.dataGridView2.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView2_CellFormatting);
            // 
            // FormSED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SCTAttendanceSystemUI.Properties.Resources.BG_LOW_OPACITY;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.sortComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSort);
            this.Controls.Add(this.sortENcomboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelSedDepartment);
            this.Controls.Add(this.labelSedDepartment);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "FormSED";
            this.Text = "FormSED";
            this.Load += new System.EventHandler(this.FormSED_Load);
            this.panelSedDepartment.ResumeLayout(false);
            this.panelSedDepartment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelSedDepartment;
        private Panel panelSedDepartment;
        private DataGridView dataGridView1;
        private Label label4;
        private ComboBox cboSheet;
        private Button btnBrowse;
        private Label label3;
        private TextBox txtFilename;
        private ComboBox sortComboBox;
        private Label label1;
        private Label labelSort;
        private ComboBox sortENcomboBox;
        private DataGridView dataGridView2;
        private Button buttonExport;
    }
}
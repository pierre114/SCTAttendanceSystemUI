namespace SCTAttendanceSystemUI.Forms
{
    partial class FormViewRecords
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
            this.labelViewRecords = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelViewRecordsSort = new System.Windows.Forms.Label();
            this.sortComboBoxViewRecords = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelViewRecords
            // 
            this.labelViewRecords.AutoSize = true;
            this.labelViewRecords.BackColor = System.Drawing.Color.Transparent;
            this.labelViewRecords.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelViewRecords.Location = new System.Drawing.Point(38, 32);
            this.labelViewRecords.Name = "labelViewRecords";
            this.labelViewRecords.Size = new System.Drawing.Size(230, 31);
            this.labelViewRecords.TabIndex = 4;
            this.labelViewRecords.Text = "VIEW RECORDS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(62, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1490, 734);
            this.dataGridView1.TabIndex = 5;
            // 
            // labelViewRecordsSort
            // 
            this.labelViewRecordsSort.AutoSize = true;
            this.labelViewRecordsSort.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelViewRecordsSort.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelViewRecordsSort.Location = new System.Drawing.Point(1327, 45);
            this.labelViewRecordsSort.Name = "labelViewRecordsSort";
            this.labelViewRecordsSort.Size = new System.Drawing.Size(39, 17);
            this.labelViewRecordsSort.TabIndex = 21;
            this.labelViewRecordsSort.Text = "Sort:";
            // 
            // sortComboBoxViewRecords
            // 
            this.sortComboBoxViewRecords.BackColor = System.Drawing.SystemColors.Control;
            this.sortComboBoxViewRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortComboBoxViewRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortComboBoxViewRecords.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sortComboBoxViewRecords.FormattingEnabled = true;
            this.sortComboBoxViewRecords.Items.AddRange(new object[] {
            "Employee",
            "None"});
            this.sortComboBoxViewRecords.Location = new System.Drawing.Point(1372, 42);
            this.sortComboBoxViewRecords.Name = "sortComboBoxViewRecords";
            this.sortComboBoxViewRecords.Size = new System.Drawing.Size(142, 23);
            this.sortComboBoxViewRecords.TabIndex = 22;
            this.sortComboBoxViewRecords.Text = "Employee";
            // 
            // FormViewRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SCTAttendanceSystemUI.Properties.Resources.BG_LOW_OPACITY;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.sortComboBoxViewRecords);
            this.Controls.Add(this.labelViewRecordsSort);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelViewRecords);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "FormViewRecords";
            this.Text = "FormViewRecords";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelViewRecords;
        private DataGridView dataGridView1;
        private Label labelViewRecordsSort;
        private ComboBox sortComboBoxViewRecords;
    }
}
namespace SCTAttendanceSystemUI
{
    partial class Home1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home1));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelSiena = new System.Windows.Forms.Label();
            this.labelMenu = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonPayroll = new System.Windows.Forms.Button();
            this.buttonLeave = new System.Windows.Forms.Button();
            this.panelEmployeesSubMenu = new System.Windows.Forms.Panel();
            this.buttonDeduction = new System.Windows.Forms.Button();
            this.buttonOvertime = new System.Windows.Forms.Button();
            this.buttonSchedule1 = new System.Windows.Forms.Button();
            this.buttonCashAdvance = new System.Windows.Forms.Button();
            this.buttonEmployeeList = new System.Windows.Forms.Button();
            this.tableLayoutPanelEmployee = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEmployees = new System.Windows.Forms.Button();
            this.pictureBoxEmpDropdownBtn = new System.Windows.Forms.PictureBox();
            this.buttonAbsentees = new System.Windows.Forms.Button();
            this.panelDropdownDepartments = new System.Windows.Forms.Panel();
            this.buttonAsp = new System.Windows.Forms.Button();
            this.buttonIbed = new System.Windows.Forms.Button();
            this.buttonSed = new System.Windows.Forms.Button();
            this.tableLayoutPanelDepartment = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDepartment = new System.Windows.Forms.Button();
            this.pictureBoxDepDropdownBtn = new System.Windows.Forms.PictureBox();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelEmployeesSubMenu.SuspendLayout();
            this.tableLayoutPanelEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmpDropdownBtn)).BeginInit();
            this.panelDropdownDepartments.SuspendLayout();
            this.tableLayoutPanelDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepDropdownBtn)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.panelHeader.Controls.Add(this.panelSearch);
            this.panelHeader.Controls.Add(this.labelSiena);
            this.panelHeader.Controls.Add(this.labelMenu);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1666, 110);
            this.panelHeader.TabIndex = 3;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.buttonSearch);
            this.panelSearch.Location = new System.Drawing.Point(1096, 28);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(320, 45);
            this.panelSearch.TabIndex = 4;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackgroundImage = global::SCTAttendanceSystemUI.Properties.Resources.searchbox1;
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSearch.ForeColor = System.Drawing.Color.Gray;
            this.buttonSearch.Image = global::SCTAttendanceSystemUI.Properties.Resources.search1;
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.Location = new System.Drawing.Point(0, 0);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(320, 42);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "SEARCH";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelSiena
            // 
            this.labelSiena.AutoSize = true;
            this.labelSiena.BackColor = System.Drawing.Color.Transparent;
            this.labelSiena.Font = new System.Drawing.Font("Times New Roman", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSiena.ForeColor = System.Drawing.Color.White;
            this.labelSiena.Location = new System.Drawing.Point(220, 28);
            this.labelSiena.Name = "labelSiena";
            this.labelSiena.Size = new System.Drawing.Size(520, 53);
            this.labelSiena.TabIndex = 3;
            this.labelSiena.Text = "SCT Attendance  System";
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMenu.ForeColor = System.Drawing.Color.White;
            this.labelMenu.Location = new System.Drawing.Point(56, 70);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(98, 37);
            this.labelMenu.TabIndex = 0;
            this.labelMenu.Text = "MENU";
            this.labelMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.panelMenu.Controls.Add(this.buttonLogout);
            this.panelMenu.Controls.Add(this.buttonSettings);
            this.panelMenu.Controls.Add(this.buttonPayroll);
            this.panelMenu.Controls.Add(this.buttonLeave);
            this.panelMenu.Controls.Add(this.panelEmployeesSubMenu);
            this.panelMenu.Controls.Add(this.tableLayoutPanelEmployee);
            this.panelMenu.Controls.Add(this.buttonAbsentees);
            this.panelMenu.Controls.Add(this.panelDropdownDepartments);
            this.panelMenu.Controls.Add(this.tableLayoutPanelDepartment);
            this.panelMenu.Controls.Add(this.buttonHome);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 110);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(214, 712);
            this.panelMenu.TabIndex = 4;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonLogout.Image = global::SCTAttendanceSystemUI.Properties.Resources.logout;
            this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.Location = new System.Drawing.Point(0, 1081);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonLogout.Size = new System.Drawing.Size(197, 80);
            this.buttonLogout.TabIndex = 0;
            this.buttonLogout.Text = "     LOGOUT";
            this.buttonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click_1);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSettings.Image = global::SCTAttendanceSystemUI.Properties.Resources.settings1;
            this.buttonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.Location = new System.Drawing.Point(0, 1001);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonSettings.Size = new System.Drawing.Size(197, 80);
            this.buttonSettings.TabIndex = 0;
            this.buttonSettings.Text = "     SETTINGS";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click_1);
            // 
            // buttonPayroll
            // 
            this.buttonPayroll.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPayroll.FlatAppearance.BorderSize = 0;
            this.buttonPayroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPayroll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPayroll.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonPayroll.Image = global::SCTAttendanceSystemUI.Properties.Resources.payroll;
            this.buttonPayroll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPayroll.Location = new System.Drawing.Point(0, 921);
            this.buttonPayroll.Name = "buttonPayroll";
            this.buttonPayroll.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonPayroll.Size = new System.Drawing.Size(197, 80);
            this.buttonPayroll.TabIndex = 0;
            this.buttonPayroll.Text = "     PAYROLL";
            this.buttonPayroll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPayroll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPayroll.UseVisualStyleBackColor = true;
            this.buttonPayroll.Click += new System.EventHandler(this.buttonPayroll_Click_1);
            // 
            // buttonLeave
            // 
            this.buttonLeave.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLeave.FlatAppearance.BorderSize = 0;
            this.buttonLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLeave.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonLeave.Image = global::SCTAttendanceSystemUI.Properties.Resources.leave;
            this.buttonLeave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLeave.Location = new System.Drawing.Point(0, 841);
            this.buttonLeave.Name = "buttonLeave";
            this.buttonLeave.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonLeave.Size = new System.Drawing.Size(197, 80);
            this.buttonLeave.TabIndex = 0;
            this.buttonLeave.Text = "     LEAVE";
            this.buttonLeave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLeave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLeave.UseVisualStyleBackColor = true;
            this.buttonLeave.Click += new System.EventHandler(this.buttonLeave_Click_1);
            // 
            // panelEmployeesSubMenu
            // 
            this.panelEmployeesSubMenu.Controls.Add(this.buttonDeduction);
            this.panelEmployeesSubMenu.Controls.Add(this.buttonOvertime);
            this.panelEmployeesSubMenu.Controls.Add(this.buttonSchedule1);
            this.panelEmployeesSubMenu.Controls.Add(this.buttonCashAdvance);
            this.panelEmployeesSubMenu.Controls.Add(this.buttonEmployeeList);
            this.panelEmployeesSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEmployeesSubMenu.Location = new System.Drawing.Point(0, 519);
            this.panelEmployeesSubMenu.Name = "panelEmployeesSubMenu";
            this.panelEmployeesSubMenu.Size = new System.Drawing.Size(197, 322);
            this.panelEmployeesSubMenu.TabIndex = 0;
            // 
            // buttonDeduction
            // 
            this.buttonDeduction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeduction.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDeduction.FlatAppearance.BorderSize = 0;
            this.buttonDeduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeduction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDeduction.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonDeduction.Location = new System.Drawing.Point(0, 248);
            this.buttonDeduction.Name = "buttonDeduction";
            this.buttonDeduction.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonDeduction.Size = new System.Drawing.Size(197, 62);
            this.buttonDeduction.TabIndex = 5;
            this.buttonDeduction.Text = "DEDUCTION";
            this.buttonDeduction.UseVisualStyleBackColor = true;
            this.buttonDeduction.Click += new System.EventHandler(this.buttonDeduction_Click_1);
            // 
            // buttonOvertime
            // 
            this.buttonOvertime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOvertime.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOvertime.FlatAppearance.BorderSize = 0;
            this.buttonOvertime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOvertime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonOvertime.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonOvertime.Location = new System.Drawing.Point(0, 186);
            this.buttonOvertime.Name = "buttonOvertime";
            this.buttonOvertime.Size = new System.Drawing.Size(197, 62);
            this.buttonOvertime.TabIndex = 4;
            this.buttonOvertime.Text = "OVERTIME";
            this.buttonOvertime.UseVisualStyleBackColor = true;
            this.buttonOvertime.Click += new System.EventHandler(this.buttonOvertime_Click_1);
            // 
            // buttonSchedule1
            // 
            this.buttonSchedule1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSchedule1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSchedule1.FlatAppearance.BorderSize = 0;
            this.buttonSchedule1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSchedule1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSchedule1.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSchedule1.Location = new System.Drawing.Point(0, 124);
            this.buttonSchedule1.Name = "buttonSchedule1";
            this.buttonSchedule1.Size = new System.Drawing.Size(197, 62);
            this.buttonSchedule1.TabIndex = 3;
            this.buttonSchedule1.Text = "SCHEDULE";
            this.buttonSchedule1.UseVisualStyleBackColor = true;
            this.buttonSchedule1.Click += new System.EventHandler(this.buttonSchedule1_Click_1);
            // 
            // buttonCashAdvance
            // 
            this.buttonCashAdvance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCashAdvance.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCashAdvance.FlatAppearance.BorderSize = 0;
            this.buttonCashAdvance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCashAdvance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCashAdvance.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCashAdvance.Location = new System.Drawing.Point(0, 62);
            this.buttonCashAdvance.Name = "buttonCashAdvance";
            this.buttonCashAdvance.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonCashAdvance.Size = new System.Drawing.Size(197, 62);
            this.buttonCashAdvance.TabIndex = 2;
            this.buttonCashAdvance.Text = "CASH ADVANCE";
            this.buttonCashAdvance.UseVisualStyleBackColor = true;
            this.buttonCashAdvance.Click += new System.EventHandler(this.buttonCashAdvance_Click_1);
            // 
            // buttonEmployeeList
            // 
            this.buttonEmployeeList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEmployeeList.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEmployeeList.FlatAppearance.BorderSize = 0;
            this.buttonEmployeeList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployeeList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEmployeeList.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonEmployeeList.Location = new System.Drawing.Point(0, 0);
            this.buttonEmployeeList.Name = "buttonEmployeeList";
            this.buttonEmployeeList.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonEmployeeList.Size = new System.Drawing.Size(197, 62);
            this.buttonEmployeeList.TabIndex = 1;
            this.buttonEmployeeList.Text = "EMPLOYEE LIST";
            this.buttonEmployeeList.UseVisualStyleBackColor = true;
            this.buttonEmployeeList.Click += new System.EventHandler(this.buttonEmployeeList_Click_1);
            // 
            // tableLayoutPanelEmployee
            // 
            this.tableLayoutPanelEmployee.ColumnCount = 2;
            this.tableLayoutPanelEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanelEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelEmployee.Controls.Add(this.buttonEmployees, 0, 0);
            this.tableLayoutPanelEmployee.Controls.Add(this.pictureBoxEmpDropdownBtn, 1, 0);
            this.tableLayoutPanelEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelEmployee.Location = new System.Drawing.Point(0, 439);
            this.tableLayoutPanelEmployee.Name = "tableLayoutPanelEmployee";
            this.tableLayoutPanelEmployee.RowCount = 1;
            this.tableLayoutPanelEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelEmployee.Size = new System.Drawing.Size(197, 80);
            this.tableLayoutPanelEmployee.TabIndex = 22;
            // 
            // buttonEmployees
            // 
            this.buttonEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEmployees.FlatAppearance.BorderSize = 0;
            this.buttonEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEmployees.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonEmployees.Image = global::SCTAttendanceSystemUI.Properties.Resources.employees;
            this.buttonEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmployees.Location = new System.Drawing.Point(3, 3);
            this.buttonEmployees.Name = "buttonEmployees";
            this.buttonEmployees.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonEmployees.Size = new System.Drawing.Size(154, 74);
            this.buttonEmployees.TabIndex = 0;
            this.buttonEmployees.Text = "EMPLOYEES";
            this.buttonEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEmployees.UseVisualStyleBackColor = true;
            this.buttonEmployees.Click += new System.EventHandler(this.buttonEmployees_Click_1);
            // 
            // pictureBoxEmpDropdownBtn
            // 
            this.pictureBoxEmpDropdownBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxEmpDropdownBtn.BackgroundImage")));
            this.pictureBoxEmpDropdownBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxEmpDropdownBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxEmpDropdownBtn.Location = new System.Drawing.Point(163, 3);
            this.pictureBoxEmpDropdownBtn.Name = "pictureBoxEmpDropdownBtn";
            this.pictureBoxEmpDropdownBtn.Size = new System.Drawing.Size(31, 74);
            this.pictureBoxEmpDropdownBtn.TabIndex = 1;
            this.pictureBoxEmpDropdownBtn.TabStop = false;
            // 
            // buttonAbsentees
            // 
            this.buttonAbsentees.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAbsentees.FlatAppearance.BorderSize = 0;
            this.buttonAbsentees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbsentees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAbsentees.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAbsentees.Image = global::SCTAttendanceSystemUI.Properties.Resources.absentees;
            this.buttonAbsentees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbsentees.Location = new System.Drawing.Point(0, 359);
            this.buttonAbsentees.Name = "buttonAbsentees";
            this.buttonAbsentees.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonAbsentees.Size = new System.Drawing.Size(197, 80);
            this.buttonAbsentees.TabIndex = 23;
            this.buttonAbsentees.Text = "     ABSENTEES";
            this.buttonAbsentees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbsentees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAbsentees.UseVisualStyleBackColor = true;
            this.buttonAbsentees.Click += new System.EventHandler(this.buttonAbsentees_Click_1);
            // 
            // panelDropdownDepartments
            // 
            this.panelDropdownDepartments.Controls.Add(this.buttonAsp);
            this.panelDropdownDepartments.Controls.Add(this.buttonIbed);
            this.panelDropdownDepartments.Controls.Add(this.buttonSed);
            this.panelDropdownDepartments.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDropdownDepartments.Location = new System.Drawing.Point(0, 160);
            this.panelDropdownDepartments.Name = "panelDropdownDepartments";
            this.panelDropdownDepartments.Size = new System.Drawing.Size(197, 199);
            this.panelDropdownDepartments.TabIndex = 23;
            // 
            // buttonAsp
            // 
            this.buttonAsp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAsp.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAsp.FlatAppearance.BorderSize = 0;
            this.buttonAsp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAsp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAsp.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAsp.Location = new System.Drawing.Point(0, 124);
            this.buttonAsp.Name = "buttonAsp";
            this.buttonAsp.Size = new System.Drawing.Size(197, 62);
            this.buttonAsp.TabIndex = 3;
            this.buttonAsp.Text = "ASP";
            this.buttonAsp.UseVisualStyleBackColor = true;
            this.buttonAsp.Click += new System.EventHandler(this.buttonAsp_Click_1);
            // 
            // buttonIbed
            // 
            this.buttonIbed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIbed.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonIbed.FlatAppearance.BorderSize = 0;
            this.buttonIbed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIbed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonIbed.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonIbed.Location = new System.Drawing.Point(0, 62);
            this.buttonIbed.Name = "buttonIbed";
            this.buttonIbed.Size = new System.Drawing.Size(197, 62);
            this.buttonIbed.TabIndex = 2;
            this.buttonIbed.Text = "IBED";
            this.buttonIbed.UseVisualStyleBackColor = true;
            this.buttonIbed.Click += new System.EventHandler(this.buttonIbed_Click_1);
            // 
            // buttonSed
            // 
            this.buttonSed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSed.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSed.FlatAppearance.BorderSize = 0;
            this.buttonSed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSed.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSed.Location = new System.Drawing.Point(0, 0);
            this.buttonSed.Name = "buttonSed";
            this.buttonSed.Size = new System.Drawing.Size(197, 62);
            this.buttonSed.TabIndex = 1;
            this.buttonSed.Text = "SED";
            this.buttonSed.UseVisualStyleBackColor = true;
            this.buttonSed.Click += new System.EventHandler(this.buttonSed_Click_1);
            // 
            // tableLayoutPanelDepartment
            // 
            this.tableLayoutPanelDepartment.ColumnCount = 2;
            this.tableLayoutPanelDepartment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDepartment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanelDepartment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelDepartment.Controls.Add(this.buttonDepartment, 0, 0);
            this.tableLayoutPanelDepartment.Controls.Add(this.pictureBoxDepDropdownBtn, 1, 0);
            this.tableLayoutPanelDepartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelDepartment.Location = new System.Drawing.Point(0, 80);
            this.tableLayoutPanelDepartment.Name = "tableLayoutPanelDepartment";
            this.tableLayoutPanelDepartment.RowCount = 1;
            this.tableLayoutPanelDepartment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDepartment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDepartment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelDepartment.Size = new System.Drawing.Size(197, 80);
            this.tableLayoutPanelDepartment.TabIndex = 0;
            this.tableLayoutPanelDepartment.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // buttonDepartment
            // 
            this.buttonDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDepartment.FlatAppearance.BorderSize = 0;
            this.buttonDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDepartment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDepartment.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonDepartment.Image = global::SCTAttendanceSystemUI.Properties.Resources.department;
            this.buttonDepartment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDepartment.Location = new System.Drawing.Point(3, 3);
            this.buttonDepartment.Name = "buttonDepartment";
            this.buttonDepartment.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonDepartment.Size = new System.Drawing.Size(154, 74);
            this.buttonDepartment.TabIndex = 0;
            this.buttonDepartment.Text = "DEPARTMENT";
            this.buttonDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDepartment.UseVisualStyleBackColor = true;
            this.buttonDepartment.Click += new System.EventHandler(this.buttonDepartment_Click_1);
            // 
            // pictureBoxDepDropdownBtn
            // 
            this.pictureBoxDepDropdownBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxDepDropdownBtn.BackgroundImage")));
            this.pictureBoxDepDropdownBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxDepDropdownBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxDepDropdownBtn.Location = new System.Drawing.Point(163, 3);
            this.pictureBoxDepDropdownBtn.Name = "pictureBoxDepDropdownBtn";
            this.pictureBoxDepDropdownBtn.Size = new System.Drawing.Size(31, 74);
            this.pictureBoxDepDropdownBtn.TabIndex = 1;
            this.pictureBoxDepDropdownBtn.TabStop = false;
            // 
            // buttonHome
            // 
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonHome.Image = global::SCTAttendanceSystemUI.Properties.Resources.dashboard;
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(0, 0);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonHome.Size = new System.Drawing.Size(197, 80);
            this.buttonHome.TabIndex = 11;
            this.buttonHome.Text = "     HOME";
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(214, 110);
            this.panelDesktopPane.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.panelDesktopPane.MinimumSize = new System.Drawing.Size(1454, 712);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(1454, 712);
            this.panelDesktopPane.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Image = global::SCTAttendanceSystemUI.Properties.Resources.department;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(157, 94);
            this.button2.TabIndex = 0;
            this.button2.Text = "DEPARTMENT";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Location = new System.Drawing.Point(166, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 94);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Home1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1666, 822);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHeader);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1682, 861);
            this.Name = "Home1";
            this.Text = "SCT ATTENDANCE SYSTEM";
            this.Load += new System.EventHandler(this.Home1_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelEmployeesSubMenu.ResumeLayout(false);
            this.tableLayoutPanelEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmpDropdownBtn)).EndInit();
            this.panelDropdownDepartments.ResumeLayout(false);
            this.tableLayoutPanelDepartment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepDropdownBtn)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelHeader;
        private Label labelSiena;
        private Panel panelMenu;
        private Button buttonHome;
        private Label labelMenu;
        private Panel panelSearch;
        private Button buttonSearch;
        private Panel panelDesktopPane;
        private TableLayoutPanel tableLayoutPanelDepartment;
        private Button buttonDepartment;
        private PictureBox pictureBoxDepDropdownBtn;
        private TableLayoutPanel tableLayoutPanelEmployee;
        private Button buttonEmployees;
        private PictureBox pictureBoxEmpDropdownBtn;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button2;
        private PictureBox pictureBox2;
        private Panel panelDropdownDepartments;
        private Button buttonAsp;
        private Button buttonIbed;
        private Button buttonSed;
        private Button buttonAbsentees;
        private Panel panelEmployeesSubMenu;
        private Button buttonDeduction;
        private Button buttonOvertime;
        private Button buttonSchedule1;
        private Button buttonCashAdvance;
        private Button buttonEmployeeList;
        private Button buttonLeave;
        private Button buttonPayroll;
        private Button buttonSettings;
        private Button buttonLogout;
    }
}
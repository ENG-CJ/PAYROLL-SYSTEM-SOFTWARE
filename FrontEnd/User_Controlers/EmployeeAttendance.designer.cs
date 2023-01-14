namespace HIMILO_ICT_PAYROLL_SYSTEM.FrontEnd.User_Controlers
{
    partial class EmployeeAttendance
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.filterDepart = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.markAllAttendance = new Guna.UI2.WinForms.Guna2CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.attendanceDatteTaker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureNoDataFound = new System.Windows.Forms.PictureBox();
            this.employeeAttendanceData = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.showTop = new Guna.UI2.WinForms.Guna2ComboBox();
            this.progressIndicator = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.veiwBtn = new Guna.UI2.WinForms.Guna2Button();
            this.saveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.refereshIcon = new System.Windows.Forms.PictureBox();
            this.viewAttendanceData1 = new HIMILO_ICT_PAYROLL_SYSTEM.FrontEnd.User_Controlers.ViewAttendanceData();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNoDataFound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeAttendanceData)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refereshIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 53);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(35, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Take Attendance For Specific Depart or All";
            // 
            // filterDepart
            // 
            this.filterDepart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.filterDepart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(143)))), ((int)(((byte)(166)))));
            this.filterDepart.BorderRadius = 8;
            this.filterDepart.BorderThickness = 2;
            this.filterDepart.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.filterDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterDepart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.filterDepart.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filterDepart.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filterDepart.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.filterDepart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.filterDepart.ItemHeight = 30;
            this.filterDepart.Items.AddRange(new object[] {
            "Departments (All)",
            "Porduction",
            "Engineering",
            "Mobile Developing",
            "Web App Developing"});
            this.filterDepart.Location = new System.Drawing.Point(20, 37);
            this.filterDepart.Name = "filterDepart";
            this.filterDepart.Size = new System.Drawing.Size(515, 36);
            this.filterDepart.StartIndex = 0;
            this.filterDepart.TabIndex = 3;
            this.filterDepart.SelectedIndexChanged += new System.EventHandler(this.FilterByDepart);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.label2.Location = new System.Drawing.Point(20, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filter By Deparrtments";
            // 
            // markAllAttendance
            // 
            this.markAllAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.markAllAttendance.AutoSize = true;
            this.markAllAttendance.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.markAllAttendance.CheckedState.BorderRadius = 0;
            this.markAllAttendance.CheckedState.BorderThickness = 0;
            this.markAllAttendance.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.markAllAttendance.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markAllAttendance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.markAllAttendance.Location = new System.Drawing.Point(1377, 64);
            this.markAllAttendance.Name = "markAllAttendance";
            this.markAllAttendance.Size = new System.Drawing.Size(110, 27);
            this.markAllAttendance.TabIndex = 6;
            this.markAllAttendance.Text = "Check All";
            this.markAllAttendance.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.markAllAttendance.UncheckedState.BorderRadius = 0;
            this.markAllAttendance.UncheckedState.BorderThickness = 0;
            this.markAllAttendance.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.markAllAttendance.CheckedChanged += new System.EventHandler(this.MarkedAll);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.refereshIcon);
            this.panel2.Controls.Add(this.attendanceDatteTaker);
            this.panel2.Controls.Add(this.filterDepart);
            this.panel2.Controls.Add(this.markAllAttendance);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1500, 112);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // attendanceDatteTaker
            // 
            this.attendanceDatteTaker.Checked = true;
            this.attendanceDatteTaker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.attendanceDatteTaker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.attendanceDatteTaker.ForeColor = System.Drawing.Color.White;
            this.attendanceDatteTaker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.attendanceDatteTaker.Location = new System.Drawing.Point(552, 37);
            this.attendanceDatteTaker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.attendanceDatteTaker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.attendanceDatteTaker.Name = "attendanceDatteTaker";
            this.attendanceDatteTaker.Size = new System.Drawing.Size(504, 36);
            this.attendanceDatteTaker.TabIndex = 7;
            this.attendanceDatteTaker.Value = new System.DateTime(2022, 12, 17, 9, 21, 47, 28);
            this.attendanceDatteTaker.ValueChanged += new System.EventHandler(this.FilterByDate);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureNoDataFound);
            this.panel3.Controls.Add(this.viewAttendanceData1);
            this.panel3.Controls.Add(this.employeeAttendanceData);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 165);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1500, 740);
            this.panel3.TabIndex = 9;
            // 
            // pictureNoDataFound
            // 
            this.pictureNoDataFound.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureNoDataFound.Image = global::HIMILO_ICT_PAYROLL_SYSTEM.Properties.Resources._86231_confused;
            this.pictureNoDataFound.Location = new System.Drawing.Point(405, 80);
            this.pictureNoDataFound.Name = "pictureNoDataFound";
            this.pictureNoDataFound.Size = new System.Drawing.Size(598, 465);
            this.pictureNoDataFound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureNoDataFound.TabIndex = 18;
            this.pictureNoDataFound.TabStop = false;
            this.pictureNoDataFound.Visible = false;
            // 
            // employeeAttendanceData
            // 
            this.employeeAttendanceData.AllowUserToAddRows = false;
            this.employeeAttendanceData.AllowUserToDeleteRows = false;
            this.employeeAttendanceData.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.employeeAttendanceData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.employeeAttendanceData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeeAttendanceData.BackgroundColor = System.Drawing.Color.White;
            this.employeeAttendanceData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeeAttendanceData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.employeeAttendanceData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(31)))), ((int)(((byte)(151)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeAttendanceData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.employeeAttendanceData.ColumnHeadersHeight = 32;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.employeeAttendanceData.DefaultCellStyle = dataGridViewCellStyle3;
            this.employeeAttendanceData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeAttendanceData.EnableHeadersVisualStyles = false;
            this.employeeAttendanceData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.employeeAttendanceData.Location = new System.Drawing.Point(0, 0);
            this.employeeAttendanceData.Name = "employeeAttendanceData";
            this.employeeAttendanceData.RowHeadersVisible = false;
            this.employeeAttendanceData.RowHeadersWidth = 51;
            this.employeeAttendanceData.RowTemplate.Height = 24;
            this.employeeAttendanceData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeAttendanceData.Size = new System.Drawing.Size(1500, 740);
            this.employeeAttendanceData.TabIndex = 0;
            this.employeeAttendanceData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.employeeAttendanceData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.employeeAttendanceData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.employeeAttendanceData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.employeeAttendanceData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.employeeAttendanceData.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.employeeAttendanceData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.employeeAttendanceData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(31)))), ((int)(((byte)(151)))));
            this.employeeAttendanceData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.employeeAttendanceData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.employeeAttendanceData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.employeeAttendanceData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.employeeAttendanceData.ThemeStyle.HeaderStyle.Height = 32;
            this.employeeAttendanceData.ThemeStyle.ReadOnly = false;
            this.employeeAttendanceData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.employeeAttendanceData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.employeeAttendanceData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.employeeAttendanceData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.employeeAttendanceData.ThemeStyle.RowsStyle.Height = 24;
            this.employeeAttendanceData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.employeeAttendanceData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.employeeAttendanceData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeAttendanceData_CellContentClick);
            this.employeeAttendanceData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeAttendanceData_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.panel4.Controls.Add(this.showTop);
            this.panel4.Controls.Add(this.progressIndicator);
            this.panel4.Controls.Add(this.veiwBtn);
            this.panel4.Controls.Add(this.saveBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 886);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1500, 64);
            this.panel4.TabIndex = 10;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // showTop
            // 
            this.showTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.showTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.showTop.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.showTop.BorderRadius = 2;
            this.showTop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.showTop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.showTop.Enabled = false;
            this.showTop.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.showTop.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.showTop.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.showTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.showTop.ItemHeight = 30;
            this.showTop.Items.AddRange(new object[] {
            "All",
            "10",
            "20",
            "30",
            "50",
            "100"});
            this.showTop.Location = new System.Drawing.Point(832, 12);
            this.showTop.Name = "showTop";
            this.showTop.Size = new System.Drawing.Size(515, 36);
            this.showTop.StartIndex = 2;
            this.showTop.TabIndex = 10;
            this.guna2HtmlToolTip1.SetToolTip(this.showTop, "View As Top Number  For Huge Data");
            this.showTop.SelectedIndexChanged += new System.EventHandler(this.ShowTop);
            // 
            // progressIndicator
            // 
            this.progressIndicator.BorderRadius = 3;
            this.progressIndicator.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.progressIndicator.Location = new System.Drawing.Point(167, 9);
            this.progressIndicator.Name = "progressIndicator";
            this.progressIndicator.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.progressIndicator.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.progressIndicator.ShowText = true;
            this.progressIndicator.Size = new System.Drawing.Size(476, 45);
            this.progressIndicator.TabIndex = 9;
            this.progressIndicator.Text = "guna2ProgressBar1";
            this.progressIndicator.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.progressIndicator.Visible = false;
            this.progressIndicator.ValueChanged += new System.EventHandler(this.guna2ProgressBar1_ValueChanged);
            // 
            // veiwBtn
            // 
            this.veiwBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.veiwBtn.Animated = true;
            this.veiwBtn.BorderRadius = 8;
            this.veiwBtn.BorderThickness = 1;
            this.veiwBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.veiwBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.veiwBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.veiwBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.veiwBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.veiwBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.veiwBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.veiwBtn.ForeColor = System.Drawing.Color.White;
            this.veiwBtn.Location = new System.Drawing.Point(1353, 9);
            this.veiwBtn.Name = "veiwBtn";
            this.veiwBtn.Size = new System.Drawing.Size(134, 45);
            this.veiwBtn.TabIndex = 8;
            this.veiwBtn.Text = "View";
            this.guna2HtmlToolTip1.SetToolTip(this.veiwBtn, "View Attendance Data");
            this.veiwBtn.Click += new System.EventHandler(this.ViewAttendance);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveBtn.Animated = true;
            this.saveBtn.BorderRadius = 8;
            this.saveBtn.BorderThickness = 1;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Image = global::HIMILO_ICT_PAYROLL_SYSTEM.Properties.Resources.icons8_save_all_48px;
            this.saveBtn.Location = new System.Drawing.Point(17, 9);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(134, 45);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.TakeAttendanxce);
            // 
            // guna2HtmlToolTip1
            // 
            this.guna2HtmlToolTip1.AllowLinksHandling = true;
            this.guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // refereshIcon
            // 
            this.refereshIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refereshIcon.Enabled = false;
            this.refereshIcon.Image = global::HIMILO_ICT_PAYROLL_SYSTEM.Properties.Resources.icons8_refresh_48px;
            this.refereshIcon.Location = new System.Drawing.Point(1062, 38);
            this.refereshIcon.Name = "refereshIcon";
            this.refereshIcon.Size = new System.Drawing.Size(36, 31);
            this.refereshIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refereshIcon.TabIndex = 11;
            this.refereshIcon.TabStop = false;
            this.refereshIcon.Click += new System.EventHandler(this.refereshIcon_Click);
            // 
            // viewAttendanceData1
            // 
            this.viewAttendanceData1.BackColor = System.Drawing.Color.White;
            this.viewAttendanceData1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewAttendanceData1.Location = new System.Drawing.Point(0, 0);
            this.viewAttendanceData1.Name = "viewAttendanceData1";
            this.viewAttendanceData1.Size = new System.Drawing.Size(1500, 740);
            this.viewAttendanceData1.TabIndex = 1;
            this.viewAttendanceData1.Visible = false;
            // 
            // EmployeeAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeAttendance";
            this.Size = new System.Drawing.Size(1500, 950);
            this.Load += new System.EventHandler(this.EmployeeAttendance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureNoDataFound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeAttendanceData)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.refereshIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox filterDepart;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CheckBox markAllAttendance;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2DataGridView employeeAttendanceData;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button saveBtn;
        private Guna.UI2.WinForms.Guna2DateTimePicker attendanceDatteTaker;
        private Guna.UI2.WinForms.Guna2Button veiwBtn;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        private ViewAttendanceData viewAttendanceData1;
        private Guna.UI2.WinForms.Guna2ProgressBar progressIndicator;
        private Guna.UI2.WinForms.Guna2ComboBox showTop;
        private System.Windows.Forms.PictureBox pictureNoDataFound;
        private System.Windows.Forms.PictureBox refereshIcon;
    }
}

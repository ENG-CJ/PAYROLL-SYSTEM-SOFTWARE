namespace HIMILO_ICT_PAYROLL_SYSTEM.FrontEnd.User_Controlers
{
    partial class Payroll
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.year = new Guna.UI2.WinForms.Guna2ComboBox();
            this.month = new Guna.UI2.WinForms.Guna2ComboBox();
            this.departname = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureNoDataFound = new System.Windows.Forms.PictureBox();
            this.payrollData = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.topNumber = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalDeductios = new System.Windows.Forms.Label();
            this.TOTALNETPAY = new System.Windows.Forms.Label();
            this.TOTALBONUS = new System.Windows.Forms.Label();
            this.TOTALSALARY = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNoDataFound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollData)).BeginInit();
            this.panel4.SuspendLayout();
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
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(35, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Genarate Payroll For Employees (Monthly)";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.year);
            this.panel2.Controls.Add(this.month);
            this.panel2.Controls.Add(this.departname);
            this.panel2.Controls.Add(this.guna2Button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1500, 62);
            this.panel2.TabIndex = 3;
            // 
            // year
            // 
            this.year.BackColor = System.Drawing.Color.Transparent;
            this.year.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.year.BorderRadius = 3;
            this.year.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.year.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.year.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.year.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.year.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.year.ItemHeight = 30;
            this.year.Items.AddRange(new object[] {
            "Select"});
            this.year.Location = new System.Drawing.Point(349, 11);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(353, 36);
            this.year.StartIndex = 0;
            this.year.TabIndex = 9;
            this.year.SelectedIndexChanged += new System.EventHandler(this.FilterYear);
            // 
            // month
            // 
            this.month.BackColor = System.Drawing.Color.Transparent;
            this.month.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.month.BorderRadius = 3;
            this.month.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.month.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.month.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.month.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.month.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.month.ItemHeight = 30;
            this.month.Items.AddRange(new object[] {
            "Select"});
            this.month.Location = new System.Drawing.Point(13, 10);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(317, 36);
            this.month.StartIndex = 0;
            this.month.TabIndex = 9;
            this.month.SelectedIndexChanged += new System.EventHandler(this.Monthfilter);
            // 
            // departname
            // 
            this.departname.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.departname.BackColor = System.Drawing.Color.Transparent;
            this.departname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.departname.BorderRadius = 3;
            this.departname.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.departname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departname.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.departname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.departname.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.departname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.departname.ItemHeight = 30;
            this.departname.Items.AddRange(new object[] {
            "Departments (All)"});
            this.departname.Location = new System.Drawing.Point(994, 12);
            this.departname.Name = "departname";
            this.departname.Size = new System.Drawing.Size(317, 36);
            this.departname.StartIndex = 0;
            this.departname.TabIndex = 9;
            this.departname.SelectedIndexChanged += new System.EventHandler(this.FilterDeparts);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.guna2Button1.Font = new System.Drawing.Font("Poppins SemiBold", 11.8F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.guna2Button1.Image = global::HIMILO_ICT_PAYROLL_SYSTEM.Properties.Resources.icons8_save_all_48px1;
            this.guna2Button1.Location = new System.Drawing.Point(1323, 6);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(157, 47);
            this.guna2Button1.TabIndex = 8;
            this.guna2Button1.Text = "Generate";
            this.guna2Button1.Click += new System.EventHandler(this.Generate);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureNoDataFound);
            this.panel3.Controls.Add(this.payrollData);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 115);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1500, 835);
            this.panel3.TabIndex = 4;
            // 
            // pictureNoDataFound
            // 
            this.pictureNoDataFound.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureNoDataFound.Image = global::HIMILO_ICT_PAYROLL_SYSTEM.Properties.Resources._86231_confused;
            this.pictureNoDataFound.Location = new System.Drawing.Point(467, 127);
            this.pictureNoDataFound.Name = "pictureNoDataFound";
            this.pictureNoDataFound.Size = new System.Drawing.Size(598, 465);
            this.pictureNoDataFound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureNoDataFound.TabIndex = 19;
            this.pictureNoDataFound.TabStop = false;
            this.pictureNoDataFound.Visible = false;
            this.pictureNoDataFound.Click += new System.EventHandler(this.pictureNoDataFound_Click);
            // 
            // payrollData
            // 
            this.payrollData.AllowUserToAddRows = false;
            this.payrollData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.payrollData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.payrollData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.payrollData.BackgroundColor = System.Drawing.Color.White;
            this.payrollData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.payrollData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.payrollData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.payrollData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.payrollData.ColumnHeadersHeight = 27;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.payrollData.DefaultCellStyle = dataGridViewCellStyle6;
            this.payrollData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.payrollData.EnableHeadersVisualStyles = false;
            this.payrollData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.payrollData.Location = new System.Drawing.Point(0, 0);
            this.payrollData.Name = "payrollData";
            this.payrollData.ReadOnly = true;
            this.payrollData.RowHeadersVisible = false;
            this.payrollData.RowHeadersWidth = 51;
            this.payrollData.RowTemplate.Height = 24;
            this.payrollData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.payrollData.Size = new System.Drawing.Size(1500, 835);
            this.payrollData.TabIndex = 0;
            this.payrollData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.payrollData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.payrollData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.payrollData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.payrollData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.payrollData.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.payrollData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.payrollData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.payrollData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.payrollData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payrollData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.payrollData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.payrollData.ThemeStyle.HeaderStyle.Height = 27;
            this.payrollData.ThemeStyle.ReadOnly = true;
            this.payrollData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.payrollData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.payrollData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payrollData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.payrollData.ThemeStyle.RowsStyle.Height = 24;
            this.payrollData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.payrollData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.topNumber);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.totalDeductios);
            this.panel4.Controls.Add(this.TOTALNETPAY);
            this.panel4.Controls.Add(this.TOTALBONUS);
            this.panel4.Controls.Add(this.TOTALSALARY);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 836);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1500, 114);
            this.panel4.TabIndex = 5;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label3.Location = new System.Drawing.Point(8, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Bonus Paid: ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label5.Location = new System.Drawing.Point(445, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total Deductions: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // topNumber
            // 
            this.topNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.topNumber.BackColor = System.Drawing.Color.Transparent;
            this.topNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.topNumber.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.topNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.topNumber.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.topNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.topNumber.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.topNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.topNumber.ItemHeight = 30;
            this.topNumber.Items.AddRange(new object[] {
            "All",
            "10",
            "20",
            "30",
            "40",
            "50",
            "100",
            "150"});
            this.topNumber.Location = new System.Drawing.Point(1156, 39);
            this.topNumber.Name = "topNumber";
            this.topNumber.Size = new System.Drawing.Size(317, 36);
            this.topNumber.StartIndex = 0;
            this.topNumber.TabIndex = 9;
            this.topNumber.SelectedIndexChanged += new System.EventHandler(this.ShowTops);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label6.Location = new System.Drawing.Point(1151, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Show";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label4.Location = new System.Drawing.Point(445, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Net Pay: ";
            // 
            // totalDeductios
            // 
            this.totalDeductios.AutoSize = true;
            this.totalDeductios.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDeductios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.totalDeductios.Location = new System.Drawing.Point(668, 65);
            this.totalDeductios.Name = "totalDeductios";
            this.totalDeductios.Size = new System.Drawing.Size(96, 25);
            this.totalDeductios.TabIndex = 6;
            this.totalDeductios.Text = "$91111";
            // 
            // TOTALNETPAY
            // 
            this.TOTALNETPAY.AutoSize = true;
            this.TOTALNETPAY.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TOTALNETPAY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.TOTALNETPAY.Location = new System.Drawing.Point(667, 32);
            this.TOTALNETPAY.Name = "TOTALNETPAY";
            this.TOTALNETPAY.Size = new System.Drawing.Size(96, 25);
            this.TOTALNETPAY.TabIndex = 6;
            this.TOTALNETPAY.Text = "$91111";
            // 
            // TOTALBONUS
            // 
            this.TOTALBONUS.AutoSize = true;
            this.TOTALBONUS.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TOTALBONUS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.TOTALBONUS.Location = new System.Drawing.Point(235, 64);
            this.TOTALBONUS.Name = "TOTALBONUS";
            this.TOTALBONUS.Size = new System.Drawing.Size(96, 25);
            this.TOTALBONUS.TabIndex = 6;
            this.TOTALBONUS.Text = "$91111";
            // 
            // TOTALSALARY
            // 
            this.TOTALSALARY.AutoSize = true;
            this.TOTALSALARY.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TOTALSALARY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.TOTALSALARY.Location = new System.Drawing.Point(234, 35);
            this.TOTALSALARY.Name = "TOTALSALARY";
            this.TOTALSALARY.Size = new System.Drawing.Size(96, 25);
            this.TOTALSALARY.TabIndex = 6;
            this.TOTALSALARY.Text = "$91111";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label2.Location = new System.Drawing.Point(8, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total Basic Salary:";
            // 
            // Payroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Payroll";
            this.Size = new System.Drawing.Size(1500, 950);
            this.Load += new System.EventHandler(this.Payroll_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureNoDataFound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollData)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ComboBox year;
        private Guna.UI2.WinForms.Guna2ComboBox month;
        private Guna.UI2.WinForms.Guna2ComboBox departname;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2DataGridView payrollData;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox topNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalDeductios;
        private System.Windows.Forms.Label TOTALNETPAY;
        private System.Windows.Forms.Label TOTALBONUS;
        private System.Windows.Forms.Label TOTALSALARY;
        private System.Windows.Forms.PictureBox pictureNoDataFound;
    }
}

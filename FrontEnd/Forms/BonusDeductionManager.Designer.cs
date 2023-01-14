namespace HIMILO_ICT_PAYROLL_SYSTEM.FrontEnd.Forms
{
    partial class BonusDeductionManager
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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.notFoundMonth = new Guna.UI2.WinForms.Guna2Panel();
            this.errorDisplayer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.editBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bonusNames = new Guna.UI2.WinForms.Guna2ComboBox();
            this.totalIncome = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.totalDeductions = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.currentYear = new Guna.UI2.WinForms.Guna2TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.currentMonth = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.bonusAmont = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bonusPrecent = new Guna.UI2.WinForms.Guna2TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.employeeImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.empLevel = new System.Windows.Forms.Label();
            this.emSalary = new System.Windows.Forms.Label();
            this.emDepart = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.emGender = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.emName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.emID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            this.notFoundMonth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 45;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderRadius = 2;
            this.guna2GradientPanel1.Controls.Add(this.pictureBox2);
            this.guna2GradientPanel1.Controls.Add(this.label2);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1181, 83);
            this.guna2GradientPanel1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::HIMILO_ICT_PAYROLL_SYSTEM.Properties.Resources.close;
            this.pictureBox2.Location = new System.Drawing.Point(1121, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.Exit);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(163, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monthly Bonus And Deductions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(839, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Bonus Rewards And Deductions | Related Employee";
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.AutoScroll = true;
            this.guna2ShadowPanel1.AutoScrollMargin = new System.Drawing.Size(0, 45);
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.notFoundMonth);
            this.guna2ShadowPanel1.Controls.Add(this.guna2GroupBox2);
            this.guna2ShadowPanel1.Controls.Add(this.guna2GroupBox1);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(27, 92);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.guna2ShadowPanel1.ShadowShift = 4;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1123, 680);
            this.guna2ShadowPanel1.TabIndex = 5;
            this.guna2ShadowPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2ShadowPanel1_Paint);
            // 
            // notFoundMonth
            // 
            this.notFoundMonth.BackColor = System.Drawing.Color.White;
            this.notFoundMonth.Controls.Add(this.errorDisplayer);
            this.notFoundMonth.Controls.Add(this.pictureBox1);
            this.notFoundMonth.Controls.Add(this.label14);
            this.notFoundMonth.FillColor = System.Drawing.Color.White;
            this.notFoundMonth.Location = new System.Drawing.Point(53, 28);
            this.notFoundMonth.Name = "notFoundMonth";
            this.notFoundMonth.Size = new System.Drawing.Size(1019, 750);
            this.notFoundMonth.TabIndex = 1;
            this.notFoundMonth.Visible = false;
            // 
            // errorDisplayer
            // 
            this.errorDisplayer.AutoSize = true;
            this.errorDisplayer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorDisplayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(75)))));
            this.errorDisplayer.Location = new System.Drawing.Point(93, 320);
            this.errorDisplayer.Name = "errorDisplayer";
            this.errorDisplayer.Size = new System.Drawing.Size(834, 25);
            this.errorDisplayer.TabIndex = 0;
            this.errorDisplayer.Text = "Selected Employee, This month Has already been awarded or not achiced";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HIMILO_ICT_PAYROLL_SYSTEM.Properties.Resources._65770_info_icon_wave;
            this.pictureBox1.Location = new System.Drawing.Point(388, 215);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(97, 346);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(384, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "You Can Manage Bonus Only Current Month";
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderRadius = 10;
            this.guna2GroupBox2.Controls.Add(this.editBtn);
            this.guna2GroupBox2.Controls.Add(this.guna2Button1);
            this.guna2GroupBox2.Controls.Add(this.label5);
            this.guna2GroupBox2.Controls.Add(this.bonusNames);
            this.guna2GroupBox2.Controls.Add(this.totalIncome);
            this.guna2GroupBox2.Controls.Add(this.label10);
            this.guna2GroupBox2.Controls.Add(this.totalDeductions);
            this.guna2GroupBox2.Controls.Add(this.label8);
            this.guna2GroupBox2.Controls.Add(this.currentYear);
            this.guna2GroupBox2.Controls.Add(this.label15);
            this.guna2GroupBox2.Controls.Add(this.currentMonth);
            this.guna2GroupBox2.Controls.Add(this.label12);
            this.guna2GroupBox2.Controls.Add(this.bonusAmont);
            this.guna2GroupBox2.Controls.Add(this.label3);
            this.guna2GroupBox2.Controls.Add(this.bonusPrecent);
            this.guna2GroupBox2.Controls.Add(this.label20);
            this.guna2GroupBox2.Controls.Add(this.guna2CheckBox1);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(118, 372);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(878, 405);
            this.guna2GroupBox2.TabIndex = 0;
            this.guna2GroupBox2.Text = "Compute Bonus And Deductions Amount";
            this.guna2GroupBox2.Click += new System.EventHandler(this.guna2GroupBox2_Click);
            // 
            // editBtn
            // 
            this.editBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.editBtn.Animated = true;
            this.editBtn.BorderRadius = 4;
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.editBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.editBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.editBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.editBtn.Enabled = false;
            this.editBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.editBtn.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.editBtn.Image = global::HIMILO_ICT_PAYROLL_SYSTEM.Properties.Resources.icons8_save_all_48px1;
            this.editBtn.Location = new System.Drawing.Point(314, 340);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(210, 46);
            this.editBtn.TabIndex = 9;
            this.editBtn.Text = "Update";
            this.editBtn.Click += new System.EventHandler(this.UpdateData);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderRadius = 4;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.guna2Button1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.guna2Button1.Image = global::HIMILO_ICT_PAYROLL_SYSTEM.Properties.Resources.icons8_sigma_48px;
            this.guna2Button1.Location = new System.Drawing.Point(30, 340);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(278, 46);
            this.guna2Button1.TabIndex = 9;
            this.guna2Button1.Text = "Compute Net Income";
            this.guna2Button1.Click += new System.EventHandler(this.ComputeData);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label5.Location = new System.Drawing.Point(28, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Bonus | Reward Category";
            // 
            // bonusNames
            // 
            this.bonusNames.BackColor = System.Drawing.Color.Transparent;
            this.bonusNames.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(143)))), ((int)(((byte)(166)))));
            this.bonusNames.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bonusNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bonusNames.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bonusNames.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bonusNames.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.bonusNames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.bonusNames.ItemHeight = 30;
            this.bonusNames.Items.AddRange(new object[] {
            "Select"});
            this.bonusNames.Location = new System.Drawing.Point(29, 87);
            this.bonusNames.Name = "bonusNames";
            this.bonusNames.Size = new System.Drawing.Size(484, 36);
            this.bonusNames.StartIndex = 0;
            this.bonusNames.TabIndex = 6;
            this.bonusNames.SelectedIndexChanged += new System.EventHandler(this.DisplayAmount);
            // 
            // totalIncome
            // 
            this.totalIncome.Animated = true;
            this.totalIncome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.totalIncome.BorderRadius = 5;
            this.totalIncome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalIncome.DefaultText = "";
            this.totalIncome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.totalIncome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.totalIncome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalIncome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalIncome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalIncome.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.totalIncome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalIncome.IconLeft = global::HIMILO_ICT_PAYROLL_SYSTEM.Properties.Resources.icons8_Dollar_Coin_48px;
            this.totalIncome.Location = new System.Drawing.Point(293, 275);
            this.totalIncome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalIncome.Name = "totalIncome";
            this.totalIncome.PasswordChar = '\0';
            this.totalIncome.PlaceholderText = "";
            this.totalIncome.ReadOnly = true;
            this.totalIncome.SelectedText = "";
            this.totalIncome.Size = new System.Drawing.Size(231, 45);
            this.totalIncome.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label10.Location = new System.Drawing.Point(291, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 22);
            this.label10.TabIndex = 3;
            this.label10.Text = "Net Income  $";
            // 
            // totalDeductions
            // 
            this.totalDeductions.Animated = true;
            this.totalDeductions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.totalDeductions.BorderRadius = 5;
            this.totalDeductions.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalDeductions.DefaultText = "0";
            this.totalDeductions.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.totalDeductions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.totalDeductions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalDeductions.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalDeductions.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalDeductions.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.totalDeductions.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalDeductions.Location = new System.Drawing.Point(29, 275);
            this.totalDeductions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalDeductions.MaxLength = 8;
            this.totalDeductions.Name = "totalDeductions";
            this.totalDeductions.PasswordChar = '\0';
            this.totalDeductions.PlaceholderText = "";
            this.totalDeductions.SelectedText = "";
            this.totalDeductions.Size = new System.Drawing.Size(231, 45);
            this.totalDeductions.TabIndex = 4;
            this.totalDeductions.TextChanged += new System.EventHandler(this.CheckDeductions);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label8.Location = new System.Drawing.Point(29, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 22);
            this.label8.TabIndex = 3;
            this.label8.Text = "Total Deductions";
            // 
            // currentYear
            // 
            this.currentYear.Animated = true;
            this.currentYear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.currentYear.BorderRadius = 5;
            this.currentYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.currentYear.DefaultText = "";
            this.currentYear.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.currentYear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.currentYear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.currentYear.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.currentYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.currentYear.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.currentYear.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.currentYear.Location = new System.Drawing.Point(539, 275);
            this.currentYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.currentYear.Name = "currentYear";
            this.currentYear.PasswordChar = '\0';
            this.currentYear.PlaceholderText = "";
            this.currentYear.ReadOnly = true;
            this.currentYear.SelectedText = "";
            this.currentYear.Size = new System.Drawing.Size(220, 45);
            this.currentYear.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label15.Location = new System.Drawing.Point(539, 247);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(139, 22);
            this.label15.TabIndex = 3;
            this.label15.Text = "Current Year";
            // 
            // currentMonth
            // 
            this.currentMonth.Animated = true;
            this.currentMonth.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.currentMonth.BorderRadius = 5;
            this.currentMonth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.currentMonth.DefaultText = "";
            this.currentMonth.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.currentMonth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.currentMonth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.currentMonth.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.currentMonth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.currentMonth.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.currentMonth.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.currentMonth.Location = new System.Drawing.Point(539, 168);
            this.currentMonth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.currentMonth.Name = "currentMonth";
            this.currentMonth.PasswordChar = '\0';
            this.currentMonth.PlaceholderText = "";
            this.currentMonth.ReadOnly = true;
            this.currentMonth.SelectedText = "";
            this.currentMonth.Size = new System.Drawing.Size(220, 45);
            this.currentMonth.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label12.Location = new System.Drawing.Point(539, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 22);
            this.label12.TabIndex = 3;
            this.label12.Text = "Current Month";
            // 
            // bonusAmont
            // 
            this.bonusAmont.Animated = true;
            this.bonusAmont.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.bonusAmont.BorderRadius = 5;
            this.bonusAmont.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bonusAmont.DefaultText = "";
            this.bonusAmont.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bonusAmont.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.bonusAmont.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bonusAmont.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bonusAmont.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bonusAmont.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.bonusAmont.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bonusAmont.Location = new System.Drawing.Point(293, 168);
            this.bonusAmont.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bonusAmont.Name = "bonusAmont";
            this.bonusAmont.PasswordChar = '\0';
            this.bonusAmont.PlaceholderText = "";
            this.bonusAmont.ReadOnly = true;
            this.bonusAmont.SelectedText = "";
            this.bonusAmont.Size = new System.Drawing.Size(220, 45);
            this.bonusAmont.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label3.Location = new System.Drawing.Point(293, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bonus Amount";
            // 
            // bonusPrecent
            // 
            this.bonusPrecent.Animated = true;
            this.bonusPrecent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.bonusPrecent.BorderRadius = 5;
            this.bonusPrecent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bonusPrecent.DefaultText = "";
            this.bonusPrecent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bonusPrecent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.bonusPrecent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bonusPrecent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bonusPrecent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bonusPrecent.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.bonusPrecent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bonusPrecent.IconRight = global::HIMILO_ICT_PAYROLL_SYSTEM.Properties.Resources.icons8_percentage_48px;
            this.bonusPrecent.Location = new System.Drawing.Point(29, 168);
            this.bonusPrecent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bonusPrecent.Name = "bonusPrecent";
            this.bonusPrecent.PasswordChar = '\0';
            this.bonusPrecent.PlaceholderText = "";
            this.bonusPrecent.ReadOnly = true;
            this.bonusPrecent.SelectedText = "";
            this.bonusPrecent.Size = new System.Drawing.Size(231, 45);
            this.bonusPrecent.TabIndex = 4;
            this.bonusPrecent.TextChanged += new System.EventHandler(this.empAddress_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label20.Location = new System.Drawing.Point(27, 135);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(223, 22);
            this.label20.TabIndex = 3;
            this.label20.Text = "Bonus Precentage %";
            // 
            // guna2CheckBox1
            // 
            this.guna2CheckBox1.AutoSize = true;
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.CheckedState.BorderRadius = 0;
            this.guna2CheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CheckBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2CheckBox1.Location = new System.Drawing.Point(294, 216);
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.Size = new System.Drawing.Size(152, 24);
            this.guna2CheckBox1.TabIndex = 10;
            this.guna2CheckBox1.Text = "No Bonus Amount";
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.CheckedChanged += new System.EventHandler(this.guna2CheckBox1_CheckedChanged);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderRadius = 10;
            this.guna2GroupBox1.Controls.Add(this.employeeImage);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.empLevel);
            this.guna2GroupBox1.Controls.Add(this.emSalary);
            this.guna2GroupBox1.Controls.Add(this.emDepart);
            this.guna2GroupBox1.Controls.Add(this.label13);
            this.guna2GroupBox1.Controls.Add(this.emGender);
            this.guna2GroupBox1.Controls.Add(this.label11);
            this.guna2GroupBox1.Controls.Add(this.emName);
            this.guna2GroupBox1.Controls.Add(this.label9);
            this.guna2GroupBox1.Controls.Add(this.emID);
            this.guna2GroupBox1.Controls.Add(this.label7);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(118, 31);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(878, 294);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "Employee Information";
            // 
            // employeeImage
            // 
            this.employeeImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employeeImage.ImageRotate = 0F;
            this.employeeImage.Location = new System.Drawing.Point(17, 49);
            this.employeeImage.Name = "employeeImage";
            this.employeeImage.Size = new System.Drawing.Size(212, 218);
            this.employeeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.employeeImage.TabIndex = 5;
            this.employeeImage.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.label6.Location = new System.Drawing.Point(679, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Month Salary";
            // 
            // empLevel
            // 
            this.empLevel.AutoSize = true;
            this.empLevel.BackColor = System.Drawing.Color.White;
            this.empLevel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.empLevel.Location = new System.Drawing.Point(387, 201);
            this.empLevel.Name = "empLevel";
            this.empLevel.Size = new System.Drawing.Size(114, 21);
            this.empLevel.TabIndex = 3;
            this.empLevel.Text = "Department";
            // 
            // emSalary
            // 
            this.emSalary.AutoSize = true;
            this.emSalary.BackColor = System.Drawing.Color.White;
            this.emSalary.Font = new System.Drawing.Font("Verdana", 22.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.emSalary.Location = new System.Drawing.Point(665, 91);
            this.emSalary.Name = "emSalary";
            this.emSalary.Size = new System.Drawing.Size(128, 46);
            this.emSalary.TabIndex = 3;
            this.emSalary.Text = "$599";
            // 
            // emDepart
            // 
            this.emDepart.AutoSize = true;
            this.emDepart.BackColor = System.Drawing.Color.White;
            this.emDepart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emDepart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.emDepart.Location = new System.Drawing.Point(387, 165);
            this.emDepart.Name = "emDepart";
            this.emDepart.Size = new System.Drawing.Size(114, 21);
            this.emDepart.TabIndex = 3;
            this.emDepart.Text = "Department";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label13.Location = new System.Drawing.Point(253, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 22);
            this.label13.TabIndex = 3;
            this.label13.Text = "EMPLevel:";
            // 
            // emGender
            // 
            this.emGender.AutoSize = true;
            this.emGender.BackColor = System.Drawing.Color.White;
            this.emGender.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.emGender.Location = new System.Drawing.Point(387, 127);
            this.emGender.Name = "emGender";
            this.emGender.Size = new System.Drawing.Size(114, 21);
            this.emGender.TabIndex = 3;
            this.emGender.Text = "Department";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label11.Location = new System.Drawing.Point(253, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 22);
            this.label11.TabIndex = 3;
            this.label11.Text = "Department: ";
            // 
            // emName
            // 
            this.emName.AutoSize = true;
            this.emName.BackColor = System.Drawing.Color.White;
            this.emName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.emName.Location = new System.Drawing.Point(387, 92);
            this.emName.Name = "emName";
            this.emName.Size = new System.Drawing.Size(114, 21);
            this.emName.TabIndex = 3;
            this.emName.Text = "Department";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label9.Location = new System.Drawing.Point(253, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 22);
            this.label9.TabIndex = 3;
            this.label9.Text = "EMGender: ";
            // 
            // emID
            // 
            this.emID.AutoSize = true;
            this.emID.BackColor = System.Drawing.Color.White;
            this.emID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.emID.Location = new System.Drawing.Point(387, 54);
            this.emID.Name = "emID";
            this.emID.Size = new System.Drawing.Size(114, 21);
            this.emID.TabIndex = 3;
            this.emID.Text = "Department";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label7.Location = new System.Drawing.Point(253, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "EMPName: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label4.Location = new System.Drawing.Point(253, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "EMP ID:";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.DragStartTransparencyValue = 0.89D;
            this.guna2DragControl1.TargetControl = this.guna2GradientPanel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // BonusDeductionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1181, 788);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "BonusDeductionManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BonusDeductionManager";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.BonusDeductionManager_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.notFoundMonth.ResumeLayout(false);
            this.notFoundMonth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.Label label20;
        private Guna.UI2.WinForms.Guna2PictureBox employeeImage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label empLevel;
        private System.Windows.Forms.Label emSalary;
        private System.Windows.Forms.Label emDepart;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label emGender;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label emName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label emID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2TextBox bonusAmont;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox bonusPrecent;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox bonusNames;
        private Guna.UI2.WinForms.Guna2TextBox totalIncome;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox totalDeductions;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button editBtn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel notFoundMonth;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label errorDisplayer;
        private Guna.UI2.WinForms.Guna2TextBox currentYear;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2TextBox currentMonth;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
    }
}
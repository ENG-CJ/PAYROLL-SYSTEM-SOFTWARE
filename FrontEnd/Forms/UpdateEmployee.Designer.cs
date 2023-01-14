namespace HIMILO_ICT_PAYROLL_SYSTEM.FrontEnd.Forms
{
    partial class UpdateEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.empPhoto = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.empGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.empDestination = new Guna.UI2.WinForms.Guna2ComboBox();
            this.empDeparts = new Guna.UI2.WinForms.Guna2ComboBox();
            this.empEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.empNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.empSalary = new Guna.UI2.WinForms.Guna2TextBox();
            this.empAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.empName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openEmpImage = new System.Windows.Forms.OpenFileDialog();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 45;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "UPDATE EMPLOYEE DATA";
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
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1179, 74);
            this.guna2GradientPanel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::HIMILO_ICT_PAYROLL_SYSTEM.Properties.Resources.close;
            this.pictureBox2.Location = new System.Drawing.Point(1119, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(95, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edit And Save Changes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DodgerBlue;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(437, 737);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "JUST UNIVERSITY |  ICT LTD";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.empPhoto);
            this.guna2ShadowPanel1.Controls.Add(this.guna2Button1);
            this.guna2ShadowPanel1.Controls.Add(this.empGender);
            this.guna2ShadowPanel1.Controls.Add(this.empDestination);
            this.guna2ShadowPanel1.Controls.Add(this.empDeparts);
            this.guna2ShadowPanel1.Controls.Add(this.empEmail);
            this.guna2ShadowPanel1.Controls.Add(this.label6);
            this.guna2ShadowPanel1.Controls.Add(this.empNumber);
            this.guna2ShadowPanel1.Controls.Add(this.label10);
            this.guna2ShadowPanel1.Controls.Add(this.label5);
            this.guna2ShadowPanel1.Controls.Add(this.label9);
            this.guna2ShadowPanel1.Controls.Add(this.empSalary);
            this.guna2ShadowPanel1.Controls.Add(this.empAddress);
            this.guna2ShadowPanel1.Controls.Add(this.label11);
            this.guna2ShadowPanel1.Controls.Add(this.label8);
            this.guna2ShadowPanel1.Controls.Add(this.label7);
            this.guna2ShadowPanel1.Controls.Add(this.empName);
            this.guna2ShadowPanel1.Controls.Add(this.label4);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 74);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.guna2ShadowPanel1.ShadowShift = 6;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1179, 617);
            this.guna2ShadowPanel1.TabIndex = 4;
            this.guna2ShadowPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2ShadowPanel1_Paint);
            // 
            // empPhoto
            // 
            this.empPhoto.BackColor = System.Drawing.Color.Transparent;
            this.empPhoto.BorderRadius = 10;
            this.empPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.empPhoto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.empPhoto.ImageRotate = 0F;
            this.empPhoto.Location = new System.Drawing.Point(801, 81);
            this.empPhoto.Name = "empPhoto";
            this.empPhoto.Size = new System.Drawing.Size(270, 312);
            this.empPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.empPhoto.TabIndex = 6;
            this.empPhoto.TabStop = false;
            this.empPhoto.Click += new System.EventHandler(this.empPhoto_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderRadius = 25;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.guna2Button1.Font = new System.Drawing.Font("Poppins SemiBold", 13.8F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.guna2Button1.Image = global::HIMILO_ICT_PAYROLL_SYSTEM.Properties.Resources.icons8_save_all_48px1;
            this.guna2Button1.Location = new System.Drawing.Point(40, 485);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(213, 63);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "Edit";
            this.guna2Button1.Click += new System.EventHandler(this.SaveChanges);
            // 
            // empGender
            // 
            this.empGender.BackColor = System.Drawing.Color.Transparent;
            this.empGender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.empGender.BorderRadius = 3;
            this.empGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.empGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empGender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empGender.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.empGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.empGender.ItemHeight = 30;
            this.empGender.Items.AddRange(new object[] {
            "Select",
            "Male",
            "Female"});
            this.empGender.Location = new System.Drawing.Point(44, 407);
            this.empGender.Name = "empGender";
            this.empGender.Size = new System.Drawing.Size(317, 36);
            this.empGender.StartIndex = 0;
            this.empGender.TabIndex = 3;
            this.empGender.SelectedIndexChanged += new System.EventHandler(this.empGender_SelectedIndexChanged);
            // 
            // empDestination
            // 
            this.empDestination.BackColor = System.Drawing.Color.Transparent;
            this.empDestination.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.empDestination.BorderRadius = 3;
            this.empDestination.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.empDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empDestination.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empDestination.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empDestination.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.empDestination.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.empDestination.ItemHeight = 30;
            this.empDestination.Items.AddRange(new object[] {
            "Select",
            "CEO",
            "Develoepr"});
            this.empDestination.Location = new System.Drawing.Point(410, 308);
            this.empDestination.Name = "empDestination";
            this.empDestination.Size = new System.Drawing.Size(317, 36);
            this.empDestination.StartIndex = 0;
            this.empDestination.TabIndex = 3;
            // 
            // empDeparts
            // 
            this.empDeparts.BackColor = System.Drawing.Color.Transparent;
            this.empDeparts.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.empDeparts.BorderRadius = 3;
            this.empDeparts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.empDeparts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empDeparts.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empDeparts.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empDeparts.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.empDeparts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.empDeparts.ItemHeight = 30;
            this.empDeparts.Items.AddRange(new object[] {
            "Select"});
            this.empDeparts.Location = new System.Drawing.Point(410, 210);
            this.empDeparts.Name = "empDeparts";
            this.empDeparts.Size = new System.Drawing.Size(317, 36);
            this.empDeparts.StartIndex = 0;
            this.empDeparts.TabIndex = 3;
            // 
            // empEmail
            // 
            this.empEmail.Animated = true;
            this.empEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.empEmail.BorderRadius = 5;
            this.empEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empEmail.DefaultText = "";
            this.empEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.empEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.empEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.empEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empEmail.Location = new System.Drawing.Point(40, 299);
            this.empEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.empEmail.Name = "empEmail";
            this.empEmail.PasswordChar = '\0';
            this.empEmail.PlaceholderText = "";
            this.empEmail.SelectedText = "";
            this.empEmail.Size = new System.Drawing.Size(317, 45);
            this.empEmail.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label6.Location = new System.Drawing.Point(40, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Email";
            // 
            // empNumber
            // 
            this.empNumber.Animated = true;
            this.empNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.empNumber.BorderRadius = 5;
            this.empNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empNumber.DefaultText = "";
            this.empNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.empNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.empNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.empNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empNumber.Location = new System.Drawing.Point(40, 201);
            this.empNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.empNumber.MaxLength = 13;
            this.empNumber.Name = "empNumber";
            this.empNumber.PasswordChar = '\0';
            this.empNumber.PlaceholderText = "";
            this.empNumber.SelectedText = "";
            this.empNumber.Size = new System.Drawing.Size(317, 45);
            this.empNumber.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label10.Location = new System.Drawing.Point(42, 371);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 22);
            this.label10.TabIndex = 1;
            this.label10.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label5.Location = new System.Drawing.Point(40, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mobile Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label9.Location = new System.Drawing.Point(408, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 22);
            this.label9.TabIndex = 1;
            this.label9.Text = "Designation";
            // 
            // empSalary
            // 
            this.empSalary.Animated = true;
            this.empSalary.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.empSalary.BorderRadius = 5;
            this.empSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empSalary.DefaultText = "";
            this.empSalary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.empSalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.empSalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empSalary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empSalary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empSalary.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.empSalary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empSalary.IconRight = global::HIMILO_ICT_PAYROLL_SYSTEM.Properties.Resources.bonus;
            this.empSalary.IconRightOffset = new System.Drawing.Point(7, 0);
            this.empSalary.Location = new System.Drawing.Point(409, 402);
            this.empSalary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.empSalary.MaxLength = 5;
            this.empSalary.Name = "empSalary";
            this.empSalary.PasswordChar = '\0';
            this.empSalary.PlaceholderText = "";
            this.empSalary.SelectedText = "";
            this.empSalary.Size = new System.Drawing.Size(317, 45);
            this.empSalary.TabIndex = 2;
            // 
            // empAddress
            // 
            this.empAddress.Animated = true;
            this.empAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.empAddress.BorderRadius = 5;
            this.empAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empAddress.DefaultText = "";
            this.empAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.empAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.empAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.empAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empAddress.Location = new System.Drawing.Point(410, 102);
            this.empAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.empAddress.Name = "empAddress";
            this.empAddress.PasswordChar = '\0';
            this.empAddress.PlaceholderText = "";
            this.empAddress.SelectedText = "";
            this.empAddress.Size = new System.Drawing.Size(317, 45);
            this.empAddress.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label11.Location = new System.Drawing.Point(410, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 22);
            this.label11.TabIndex = 1;
            this.label11.Text = "Salary";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label8.Location = new System.Drawing.Point(408, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 22);
            this.label8.TabIndex = 1;
            this.label8.Text = "Department";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label7.Location = new System.Drawing.Point(410, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "Address";
            // 
            // empName
            // 
            this.empName.Animated = true;
            this.empName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.empName.BorderRadius = 5;
            this.empName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empName.DefaultText = "";
            this.empName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.empName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.empName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.empName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empName.Location = new System.Drawing.Point(40, 102);
            this.empName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.empName.Name = "empName";
            this.empName.PasswordChar = '\0';
            this.empName.PlaceholderText = "";
            this.empName.SelectedText = "";
            this.empName.Size = new System.Drawing.Size(317, 45);
            this.empName.TabIndex = 2;
            this.empName.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label4.Location = new System.Drawing.Point(40, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Employee Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = global::HIMILO_ICT_PAYROLL_SYSTEM.Properties.Resources.wave;
            this.pictureBox1.Location = new System.Drawing.Point(0, 691);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1179, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openEmpImage
            // 
            this.openEmpImage.Filter = "All|*.*|JPG|*.JPG|PNG|*.PNG";
            this.openEmpImage.Title = "Select Employee Image";
            // 
            // UpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1179, 765);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateEmployee";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UpdateEmployee_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox empName;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox empNumber;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox empEmail;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox empAddress;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox empDestination;
        private Guna.UI2.WinForms.Guna2ComboBox empDeparts;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2PictureBox empPhoto;
        private Guna.UI2.WinForms.Guna2ComboBox empGender;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox empSalary;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.OpenFileDialog openEmpImage;
    }
}
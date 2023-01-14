namespace HIMILO_ICT_PAYROLL_SYSTEM
{
    partial class EmployeeRegistration
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
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.employeeID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.employeeName = new Guna.UI2.WinForms.Guna2TextBox();
            this.emloyeePhoto = new System.Windows.Forms.PictureBox();
            this.imageCover = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mobileNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Email = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Address = new Guna.UI2.WinForms.Guna2TextBox();
            this.departmentName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.baseSalary = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.OPENIMAGE = new System.Windows.Forms.OpenFileDialog();
            this.employeelevel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.joinedDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dateOfBirth = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emloyeePhoto)).BeginInit();
            this.imageCover.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1371, 81);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HIMILO_ICT_PAYROLL_SYSTEM.Properties.Resources.close;
            this.pictureBox2.Location = new System.Drawing.Point(1299, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.CloseWindow);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HIMILO_ICT_PAYROLL_SYSTEM.Properties.Resources.icons8_manager_48px;
            this.pictureBox1.Location = new System.Drawing.Point(114, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(251, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Register && Manage Employee ";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(164, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Management ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // employeeID
            // 
            this.employeeID.Animated = true;
            this.employeeID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.employeeID.BorderRadius = 6;
            this.employeeID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.employeeID.DefaultText = "";
            this.employeeID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.employeeID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.employeeID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.employeeID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.employeeID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.employeeID.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.employeeID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.employeeID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.employeeID.Location = new System.Drawing.Point(27, 58);
            this.employeeID.Margin = new System.Windows.Forms.Padding(6);
            this.employeeID.Name = "employeeID";
            this.employeeID.PasswordChar = '\0';
            this.employeeID.PlaceholderText = "Employee ID";
            this.employeeID.SelectedText = "";
            this.employeeID.Size = new System.Drawing.Size(390, 46);
            this.employeeID.TabIndex = 0;
            this.employeeID.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.label3.Location = new System.Drawing.Point(25, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Employee ID";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.label4.Location = new System.Drawing.Point(557, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "FullName";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // employeeName
            // 
            this.employeeName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.employeeName.BorderRadius = 6;
            this.employeeName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.employeeName.DefaultText = "";
            this.employeeName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.employeeName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.employeeName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.employeeName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.employeeName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.employeeName.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.employeeName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.employeeName.Location = new System.Drawing.Point(556, 145);
            this.employeeName.Margin = new System.Windows.Forms.Padding(6);
            this.employeeName.Name = "employeeName";
            this.employeeName.PasswordChar = '\0';
            this.employeeName.PlaceholderText = "Employee Name";
            this.employeeName.SelectedText = "";
            this.employeeName.Size = new System.Drawing.Size(390, 46);
            this.employeeName.TabIndex = 1;
            this.employeeName.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // emloyeePhoto
            // 
            this.emloyeePhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emloyeePhoto.Location = new System.Drawing.Point(1010, 115);
            this.emloyeePhoto.Name = "emloyeePhoto";
            this.emloyeePhoto.Size = new System.Drawing.Size(263, 312);
            this.emloyeePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emloyeePhoto.TabIndex = 4;
            this.emloyeePhoto.TabStop = false;
            this.emloyeePhoto.Click += new System.EventHandler(this.BROWSEIMAGE);
            // 
            // imageCover
            // 
            this.imageCover.BackColor = System.Drawing.Color.Transparent;
            this.imageCover.Controls.Add(this.label5);
            this.imageCover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageCover.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.imageCover.Location = new System.Drawing.Point(1010, 117);
            this.imageCover.Name = "imageCover";
            this.imageCover.ShadowColor = System.Drawing.Color.Black;
            this.imageCover.ShadowShift = 3;
            this.imageCover.Size = new System.Drawing.Size(263, 310);
            this.imageCover.TabIndex = 11;
            this.imageCover.Click += new System.EventHandler(this.BROWSEIMAGE);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(72, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 39);
            this.label5.TabIndex = 0;
            this.label5.Text = "PHOTO";
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Font = new System.Drawing.Font("Yu Gothic Medium", 9F, System.Drawing.FontStyle.Bold);
            this.male.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.male.Location = new System.Drawing.Point(86, 670);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(68, 23);
            this.male.TabIndex = 6;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Font = new System.Drawing.Font("Yu Gothic Medium", 9F, System.Drawing.FontStyle.Bold);
            this.female.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.female.Location = new System.Drawing.Point(159, 671);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(85, 23);
            this.female.TabIndex = 6;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.label6.Location = new System.Drawing.Point(83, 637);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Gender";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.label7.Location = new System.Drawing.Point(29, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mobile";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // mobileNumber
            // 
            this.mobileNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.mobileNumber.BorderRadius = 6;
            this.mobileNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mobileNumber.DefaultText = "";
            this.mobileNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mobileNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mobileNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mobileNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mobileNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mobileNumber.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.mobileNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mobileNumber.Location = new System.Drawing.Point(28, 160);
            this.mobileNumber.Margin = new System.Windows.Forms.Padding(6);
            this.mobileNumber.MaxLength = 13;
            this.mobileNumber.Name = "mobileNumber";
            this.mobileNumber.PasswordChar = '\0';
            this.mobileNumber.PlaceholderText = "Phone Number";
            this.mobileNumber.SelectedText = "";
            this.mobileNumber.Size = new System.Drawing.Size(394, 46);
            this.mobileNumber.TabIndex = 3;
            this.mobileNumber.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.label8.Location = new System.Drawing.Point(85, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "Email";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // Email
            // 
            this.Email.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.Email.BorderRadius = 6;
            this.Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email.DefaultText = "";
            this.Email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Email.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.Email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Email.Location = new System.Drawing.Point(84, 354);
            this.Email.Margin = new System.Windows.Forms.Padding(6);
            this.Email.Name = "Email";
            this.Email.PasswordChar = '\0';
            this.Email.PlaceholderText = "example@gmail.com";
            this.Email.SelectedText = "";
            this.Email.Size = new System.Drawing.Size(394, 46);
            this.Email.TabIndex = 4;
            this.Email.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.label9.Location = new System.Drawing.Point(555, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 26);
            this.label9.TabIndex = 0;
            this.label9.Text = "DateOfBirth";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.label10.Location = new System.Drawing.Point(554, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 26);
            this.label10.TabIndex = 0;
            this.label10.Text = "Address";
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // Address
            // 
            this.Address.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.Address.BorderRadius = 6;
            this.Address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Address.DefaultText = "";
            this.Address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Address.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.Address.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Address.Location = new System.Drawing.Point(556, 354);
            this.Address.Margin = new System.Windows.Forms.Padding(6);
            this.Address.Name = "Address";
            this.Address.PasswordChar = '\0';
            this.Address.PlaceholderText = "Employee Address";
            this.Address.SelectedText = "";
            this.Address.Size = new System.Drawing.Size(394, 46);
            this.Address.TabIndex = 5;
            this.Address.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // departmentName
            // 
            this.departmentName.BackColor = System.Drawing.Color.Transparent;
            this.departmentName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.departmentName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.departmentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.departmentName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.departmentName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.departmentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.departmentName.ItemHeight = 30;
            this.departmentName.Items.AddRange(new object[] {
            "Select Department",
            "Software",
            "Dea",
            "Marketing",
            "Software"});
            this.departmentName.Location = new System.Drawing.Point(84, 462);
            this.departmentName.Name = "departmentName";
            this.departmentName.Size = new System.Drawing.Size(401, 36);
            this.departmentName.StartIndex = 0;
            this.departmentName.TabIndex = 6;
            this.departmentName.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.label11.Location = new System.Drawing.Point(80, 430);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 26);
            this.label11.TabIndex = 0;
            this.label11.Text = "Department ";
            this.label11.Click += new System.EventHandler(this.label1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.label12.Location = new System.Drawing.Point(551, 427);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 26);
            this.label12.TabIndex = 0;
            this.label12.Text = "Designation";
            this.label12.Click += new System.EventHandler(this.label1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.label13.Location = new System.Drawing.Point(83, 530);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 26);
            this.label13.TabIndex = 0;
            this.label13.Text = "Salary";
            this.label13.Click += new System.EventHandler(this.label1_Click);
            // 
            // baseSalary
            // 
            this.baseSalary.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.baseSalary.BorderRadius = 6;
            this.baseSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.baseSalary.DefaultText = "";
            this.baseSalary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.baseSalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.baseSalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.baseSalary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.baseSalary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.baseSalary.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.baseSalary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.baseSalary.Location = new System.Drawing.Point(86, 562);
            this.baseSalary.Margin = new System.Windows.Forms.Padding(6);
            this.baseSalary.MaxLength = 7;
            this.baseSalary.Name = "baseSalary";
            this.baseSalary.PasswordChar = '\0';
            this.baseSalary.PlaceholderText = "Basic Salary";
            this.baseSalary.SelectedText = "";
            this.baseSalary.Size = new System.Drawing.Size(394, 46);
            this.baseSalary.TabIndex = 8;
            this.baseSalary.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.label14.Location = new System.Drawing.Point(557, 529);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 26);
            this.label14.TabIndex = 0;
            this.label14.Text = "Joined Date";
            this.label14.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderRadius = 7;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(84, 719);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 90);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(220, 63);
            this.guna2Button1.TabIndex = 12;
            this.guna2Button1.Text = "Save";
            this.guna2Button1.Click += new System.EventHandler(this.SaveEmployee);
            // 
            // OPENIMAGE
            // 
            this.OPENIMAGE.Filter = "ALL|*.*|JPG|*.JPG|PNG|*.PNG";
            // 
            // employeelevel
            // 
            this.employeelevel.BackColor = System.Drawing.Color.Transparent;
            this.employeelevel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.employeelevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.employeelevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeelevel.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.employeelevel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.employeelevel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.employeelevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.employeelevel.ItemHeight = 30;
            this.employeelevel.Items.AddRange(new object[] {
            "Select Department",
            "Software",
            "Dea",
            "Marketing",
            "Software"});
            this.employeelevel.Location = new System.Drawing.Point(556, 462);
            this.employeelevel.Name = "employeelevel";
            this.employeelevel.Size = new System.Drawing.Size(390, 36);
            this.employeelevel.StartIndex = 0;
            this.employeelevel.TabIndex = 6;
            this.employeelevel.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.joinedDate);
            this.guna2ShadowPanel1.Controls.Add(this.dateOfBirth);
            this.guna2ShadowPanel1.Controls.Add(this.label15);
            this.guna2ShadowPanel1.Controls.Add(this.mobileNumber);
            this.guna2ShadowPanel1.Controls.Add(this.employeeID);
            this.guna2ShadowPanel1.Controls.Add(this.label7);
            this.guna2ShadowPanel1.Controls.Add(this.label3);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(57, 87);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.guna2ShadowPanel1.ShadowShift = 2;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1256, 731);
            this.guna2ShadowPanel1.TabIndex = 14;
            // 
            // joinedDate
            // 
            this.joinedDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.joinedDate.BorderRadius = 0;
            this.joinedDate.ForeColor = System.Drawing.Color.White;
            this.joinedDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.joinedDate.FormatCustom = null;
            this.joinedDate.Location = new System.Drawing.Point(499, 477);
            this.joinedDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.joinedDate.Name = "joinedDate";
            this.joinedDate.Size = new System.Drawing.Size(394, 44);
            this.joinedDate.TabIndex = 4;
            this.joinedDate.Value = new System.DateTime(2022, 12, 23, 17, 46, 43, 730);
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.dateOfBirth.BorderRadius = 0;
            this.dateOfBirth.ForeColor = System.Drawing.Color.White;
            this.dateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateOfBirth.FormatCustom = null;
            this.dateOfBirth.Location = new System.Drawing.Point(499, 162);
            this.dateOfBirth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(394, 44);
            this.dateOfBirth.TabIndex = 4;
            this.dateOfBirth.Value = new System.DateTime(2022, 12, 23, 17, 46, 43, 730);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DimGray;
            this.label15.Location = new System.Drawing.Point(954, 343);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(195, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Required Employee Image *";
            this.label15.Click += new System.EventHandler(this.label1_Click);
            // 
            // EmployeeRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1371, 831);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.employeelevel);
            this.Controls.Add(this.departmentName);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.baseSalary);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.employeeName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.imageCover);
            this.Controls.Add(this.emloyeePhoto);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeRegistration";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeRegistration";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.EmployeeRegistration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emloyeePhoto)).EndInit();
            this.imageCover.ResumeLayout(false);
            this.imageCover.PerformLayout();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox employeeID;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private Guna.UI2.WinForms.Guna2ShadowPanel imageCover;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox emloyeePhoto;
        private Guna.UI2.WinForms.Guna2TextBox Email;
        private Guna.UI2.WinForms.Guna2TextBox mobileNumber;
        private Guna.UI2.WinForms.Guna2TextBox employeeName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox departmentName;
        private Guna.UI2.WinForms.Guna2TextBox Address;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox baseSalary;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.OpenFileDialog OPENIMAGE;
        private Guna.UI2.WinForms.Guna2ComboBox employeelevel;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Bunifu.Framework.UI.BunifuDatepicker dateOfBirth;
        private Bunifu.Framework.UI.BunifuDatepicker joinedDate;
        private System.Windows.Forms.Label label15;
    }
}
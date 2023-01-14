namespace HIMILO_ICT_PAYROLL_SYSTEM.FrontEnd.Forms
{
    partial class UserUpdater
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.type = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.email = new Guna.UI2.WinForms.Guna2TextBox();
            this.username = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fullname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CoverPhoto = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.userImage = new System.Windows.Forms.PictureBox();
            this.saveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.browseImage = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.statusActive = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label8 = new System.Windows.Forms.Label();
            this.securityQ = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.answer = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.CoverPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1226, 82);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HIMILO_ICT_PAYROLL_SYSTEM.Properties.Resources.users;
            this.pictureBox2.Location = new System.Drawing.Point(47, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HIMILO_ICT_PAYROLL_SYSTEM.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(1155, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.ClsoeWindiow);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dosis", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(121)))));
            this.label2.Location = new System.Drawing.Point(236, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Update Secure And Valid Data ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(86, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "UPDATE USER | HIMILO ICT LTD TECH";
            // 
            // type
            // 
            this.type.BackColor = System.Drawing.Color.Transparent;
            this.type.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.type.BorderRadius = 3;
            this.type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.type.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.type.ItemHeight = 30;
            this.type.Items.AddRange(new object[] {
            "Select",
            "Admin",
            "User"});
            this.type.Location = new System.Drawing.Point(507, 393);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(387, 36);
            this.type.StartIndex = 0;
            this.type.TabIndex = 17;
            this.type.SelectedIndexChanged += new System.EventHandler(this.type_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.label7.Location = new System.Drawing.Point(504, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 36);
            this.label7.TabIndex = 6;
            this.label7.Text = "UserType";
            // 
            // email
            // 
            this.email.Animated = true;
            this.email.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.email.BorderRadius = 6;
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.DefaultText = "";
            this.email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email.Location = new System.Drawing.Point(60, 278);
            this.email.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.email.Name = "email";
            this.email.PasswordChar = '\0';
            this.email.PlaceholderText = "someOne@gmail.com";
            this.email.SelectedText = "";
            this.email.Size = new System.Drawing.Size(390, 47);
            this.email.TabIndex = 15;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // username
            // 
            this.username.Animated = true;
            this.username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.username.BorderRadius = 6;
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.DefaultText = "";
            this.username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username.Location = new System.Drawing.Point(504, 174);
            this.username.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.PlaceholderText = "Your Username";
            this.username.SelectedText = "";
            this.username.Size = new System.Drawing.Size(390, 47);
            this.username.TabIndex = 14;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.label5.Location = new System.Drawing.Point(26, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 36);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email";
            // 
            // fullname
            // 
            this.fullname.Animated = true;
            this.fullname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.fullname.BorderRadius = 6;
            this.fullname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fullname.DefaultText = "";
            this.fullname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fullname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fullname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fullname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fullname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fullname.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.fullname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fullname.Location = new System.Drawing.Point(59, 174);
            this.fullname.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.fullname.Name = "fullname";
            this.fullname.PasswordChar = '\0';
            this.fullname.PlaceholderText = "Enter FullName";
            this.fullname.SelectedText = "";
            this.fullname.Size = new System.Drawing.Size(390, 47);
            this.fullname.TabIndex = 11;
            this.fullname.TextChanged += new System.EventHandler(this.fullname_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.label4.Location = new System.Drawing.Point(501, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 36);
            this.label4.TabIndex = 12;
            this.label4.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.label3.Location = new System.Drawing.Point(25, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 36);
            this.label3.TabIndex = 13;
            this.label3.Text = "FullName";
            // 
            // CoverPhoto
            // 
            this.CoverPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.CoverPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CoverPhoto.Controls.Add(this.label9);
            this.CoverPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CoverPhoto.Location = new System.Drawing.Point(968, 145);
            this.CoverPhoto.Name = "CoverPhoto";
            this.CoverPhoto.Size = new System.Drawing.Size(213, 238);
            this.CoverPhoto.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins SemiBold", 17F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label9.Location = new System.Drawing.Point(47, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 51);
            this.label9.TabIndex = 0;
            this.label9.Text = "PHOTO";
            // 
            // userImage
            // 
            this.userImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userImage.Location = new System.Drawing.Point(968, 145);
            this.userImage.Name = "userImage";
            this.userImage.Size = new System.Drawing.Size(213, 238);
            this.userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userImage.TabIndex = 19;
            this.userImage.TabStop = false;
            this.userImage.Click += new System.EventHandler(this.BroswMyImage);
            // 
            // saveBtn
            // 
            this.saveBtn.Animated = true;
            this.saveBtn.BorderRadius = 12;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(47, 559);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(194, 59);
            this.saveBtn.TabIndex = 20;
            this.saveBtn.Text = "Edit";
            this.saveBtn.Click += new System.EventHandler(this.Savechanges);
            // 
            // browseImage
            // 
            this.browseImage.Filter = "All|*.*|JPG|*.jpg|PNG|*.png";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.label6.Location = new System.Drawing.Point(54, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 36);
            this.label6.TabIndex = 6;
            this.label6.Text = "Status";
            // 
            // statusActive
            // 
            this.statusActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.statusActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.statusActive.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.statusActive.CheckedState.InnerColor = System.Drawing.Color.White;
            this.statusActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statusActive.Location = new System.Drawing.Point(59, 493);
            this.statusActive.Name = "statusActive";
            this.statusActive.Size = new System.Drawing.Size(83, 32);
            this.statusActive.TabIndex = 21;
            this.statusActive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.statusActive.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.statusActive.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.statusActive.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.statusActive.CheckedChanged += new System.EventHandler(this.statusActive_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.label8.Location = new System.Drawing.Point(501, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 36);
            this.label8.TabIndex = 10;
            this.label8.Text = "Security Question";
            // 
            // securityQ
            // 
            this.securityQ.Animated = true;
            this.securityQ.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.securityQ.BorderRadius = 6;
            this.securityQ.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.securityQ.DefaultText = "";
            this.securityQ.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.securityQ.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.securityQ.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.securityQ.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.securityQ.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.securityQ.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.securityQ.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.securityQ.Location = new System.Drawing.Point(504, 278);
            this.securityQ.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.securityQ.Name = "securityQ";
            this.securityQ.PasswordChar = '\0';
            this.securityQ.PlaceholderText = "Question?";
            this.securityQ.SelectedText = "";
            this.securityQ.Size = new System.Drawing.Size(390, 47);
            this.securityQ.TabIndex = 15;
            this.securityQ.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.label10.Location = new System.Drawing.Point(57, 347);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 36);
            this.label10.TabIndex = 10;
            this.label10.Text = "Answer";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // answer
            // 
            this.answer.Animated = true;
            this.answer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.answer.BorderRadius = 6;
            this.answer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.answer.DefaultText = "";
            this.answer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.answer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.answer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.answer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.answer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.answer.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.answer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.answer.Location = new System.Drawing.Point(60, 382);
            this.answer.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.answer.Name = "answer";
            this.answer.PasswordChar = '\0';
            this.answer.PlaceholderText = "Answer";
            this.answer.SelectedText = "";
            this.answer.Size = new System.Drawing.Size(390, 47);
            this.answer.TabIndex = 15;
            this.answer.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.label5);
            this.guna2ShadowPanel1.Controls.Add(this.label3);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(33, 108);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowShift = 2;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1181, 543);
            this.guna2ShadowPanel1.TabIndex = 22;
            this.guna2ShadowPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2ShadowPanel1_Paint);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.8D;
            this.guna2DragControl1.DragStartTransparencyValue = 0.88D;
            this.guna2DragControl1.TargetControl = this.panel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // UserUpdater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1226, 706);
            this.Controls.Add(this.statusActive);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.securityQ);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.username);
            this.Controls.Add(this.fullname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CoverPhoto);
            this.Controls.Add(this.userImage);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserUpdater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserUpdater";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UserUpdater_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.CoverPhoto.ResumeLayout(false);
            this.CoverPhoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox type;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox email;
        private Guna.UI2.WinForms.Guna2TextBox username;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox fullname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel CoverPhoto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox userImage;
        private Guna.UI2.WinForms.Guna2Button saveBtn;
        private System.Windows.Forms.OpenFileDialog browseImage;
        private Guna.UI2.WinForms.Guna2ToggleSwitch statusActive;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox answer;
        private Guna.UI2.WinForms.Guna2TextBox securityQ;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}
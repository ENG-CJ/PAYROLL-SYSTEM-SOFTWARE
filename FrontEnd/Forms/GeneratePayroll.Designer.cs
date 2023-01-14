namespace HIMILO_ICT_PAYROLL_SYSTEM.FrontEnd.Forms
{
    partial class GeneratePayroll
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
            SaaUI.Properties.Radius radius1 = new SaaUI.Properties.Radius();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneratePayroll));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.monthName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.year = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.progressIndicator = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.saaToolTip1 = new SaaUI.SaaToolTip();
            this.saaToast1 = new SaaUI.SaaToast();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label1.Location = new System.Drawing.Point(110, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(620, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Month And Year For PaySlip Generation";
            this.saaToolTip1.SetToolTip(this.label1, "");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.8F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label2.Location = new System.Drawing.Point(117, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "You Can\'t  Generate PaySlip With Same Month And Year";
            this.saaToolTip1.SetToolTip(this.label2, "");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label7.Location = new System.Drawing.Point(116, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "Month";
            this.saaToolTip1.SetToolTip(this.label7, "");
            // 
            // monthName
            // 
            this.monthName.BackColor = System.Drawing.Color.Transparent;
            this.monthName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.monthName.BorderRadius = 3;
            this.monthName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.monthName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.monthName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.monthName.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.monthName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.monthName.ItemHeight = 30;
            this.monthName.Items.AddRange(new object[] {
            "Select"});
            this.monthName.Location = new System.Drawing.Point(117, 192);
            this.monthName.Name = "monthName";
            this.monthName.Size = new System.Drawing.Size(610, 36);
            this.monthName.StartIndex = 0;
            this.monthName.TabIndex = 4;
            this.saaToolTip1.SetToolTip(this.monthName, "");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label3.Location = new System.Drawing.Point(114, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Year";
            this.saaToolTip1.SetToolTip(this.label3, "");
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
            this.year.Location = new System.Drawing.Point(115, 280);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(610, 36);
            this.year.StartIndex = 0;
            this.year.TabIndex = 4;
            this.saaToolTip1.SetToolTip(this.year, "");
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderRadius = 6;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.guna2Button1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.guna2Button1.Image = global::HIMILO_ICT_PAYROLL_SYSTEM.Properties.Resources.icons8_save_all_48px1;
            this.guna2Button1.Location = new System.Drawing.Point(115, 354);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(198, 53);
            this.guna2Button1.TabIndex = 8;
            this.guna2Button1.Text = "Generate";
            this.saaToolTip1.SetToolTip(this.guna2Button1, "");
            this.guna2Button1.Click += new System.EventHandler(this.Generate);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.BorderRadius = 6;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Maroon;
            this.guna2Button2.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.guna2Button2.Image = global::HIMILO_ICT_PAYROLL_SYSTEM.Properties.Resources.icons8_save_all_48px1;
            this.guna2Button2.Location = new System.Drawing.Point(319, 354);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(406, 53);
            this.guna2Button2.TabIndex = 8;
            this.guna2Button2.Text = "Cancel";
            this.saaToolTip1.SetToolTip(this.guna2Button2, "");
            this.guna2Button2.Click += new System.EventHandler(this.Cancel);
            // 
            // progressIndicator
            // 
            this.progressIndicator.BorderRadius = 3;
            this.progressIndicator.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.progressIndicator.Location = new System.Drawing.Point(115, 428);
            this.progressIndicator.Name = "progressIndicator";
            this.progressIndicator.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.progressIndicator.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.progressIndicator.ShowText = true;
            this.progressIndicator.Size = new System.Drawing.Size(615, 45);
            this.progressIndicator.TabIndex = 10;
            this.progressIndicator.Text = "guna2ProgressBar1";
            this.progressIndicator.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.saaToolTip1.SetToolTip(this.progressIndicator, "");
            this.progressIndicator.Visible = false;
            // 
            // saaToolTip1
            // 
            this.saaToolTip1.Active = true;
            this.saaToolTip1.ArrowHeight = 10;
            this.saaToolTip1.ArrowStart = null;
            this.saaToolTip1.ArrowWidth = 20;
            this.saaToolTip1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.saaToolTip1.Delay = 500;
            this.saaToolTip1.Duration = 15000;
            this.saaToolTip1.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.saaToolTip1.OffsetX = 0;
            this.saaToolTip1.OffsetY = 0;
            this.saaToolTip1.OffSize = new System.Drawing.Size(0, 0);
            this.saaToolTip1.Position = SaaUI.SidePositions.Bottom;
            radius1.BottomLeft = 5;
            radius1.BottomRight = 5;
            radius1.TopLeft = 5;
            radius1.TopRight = 5;
            this.saaToolTip1.Radius = radius1;
            this.saaToolTip1.ShowAlways = false;
            this.saaToolTip1.ShowArrow = true;
            this.saaToolTip1.TextColor = System.Drawing.Color.White;
            this.saaToolTip1.TextOffsetX = 0;
            this.saaToolTip1.TextOffsetY = 0;
            // 
            // saaToast1
            // 
            this.saaToast1.AutoClose = true;
            this.saaToast1.AutoSize = true;
            this.saaToast1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.saaToast1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.saaToast1.BackColorAngle = 90F;
            this.saaToast1.BodyBackColor = System.Drawing.Color.Transparent;
            this.saaToast1.BodyPadding = new System.Windows.Forms.Padding(7, 5, 4, 6);
            this.saaToast1.BodyTextColor = System.Drawing.Color.WhiteSmoke;
            this.saaToast1.BodyTextFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saaToast1.CloseActiveImage = ((System.Drawing.Image)(resources.GetObject("saaToast1.CloseActiveImage")));
            this.saaToast1.CloseBackColor = System.Drawing.Color.Transparent;
            this.saaToast1.CloseImageSizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.saaToast1.CloseInActiveImage = ((System.Drawing.Image)(resources.GetObject("saaToast1.CloseInActiveImage")));
            this.saaToast1.ClosePadding = new System.Windows.Forms.Padding(8);
            this.saaToast1.ClosePosition = SaaUI.RightLeftPositions.Right;
            this.saaToast1.ClosePreviousTaost = false;
            this.saaToast1.HeaderBackColor = System.Drawing.Color.Transparent;
            this.saaToast1.HeaderBackColor2 = System.Drawing.Color.Transparent;
            this.saaToast1.HeaderBackColorAngle = 90F;
            this.saaToast1.HeaderPadding = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.saaToast1.Icon = global::HIMILO_ICT_PAYROLL_SYSTEM.Properties.Resources.bonus;
            this.saaToast1.IconImageSizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.saaToast1.IconPadding = new System.Windows.Forms.Padding(3);
            this.saaToast1.IconPosition = SaaUI.RightLeftPositions.Left;
            this.saaToast1.IntervalInMilliseconds = 20;
            this.saaToast1.LoaderBackColor = System.Drawing.Color.WhiteSmoke;
            this.saaToast1.LoaderHeight = 3;
            this.saaToast1.LoaderPosition = SaaUI.RightLeftPositions.Left;
            this.saaToast1.LoaderVisible = true;
            this.saaToast1.MinSize = new System.Drawing.Size(10, 10);
            this.saaToast1.Movable = true;
            this.saaToast1.OffHeight = 20;
            this.saaToast1.OffsetX = 0;
            this.saaToast1.OffsetY = 0;
            this.saaToast1.OffWidth = 0;
            this.saaToast1.Padding = new System.Windows.Forms.Padding(0);
            this.saaToast1.Position = SaaUI.ToastPosition.BottomRight;
            this.saaToast1.ShowBody = true;
            this.saaToast1.ShowBodyIcon = true;
            this.saaToast1.ShowCloseIcon = true;
            this.saaToast1.ShowHeader = true;
            this.saaToast1.ShowTitle = true;
            this.saaToast1.Size = new System.Drawing.Size(270, 80);
            this.saaToast1.StopOnHover = true;
            this.saaToast1.Text = "Your request is being processed and we will \nnotify you once done.";
            this.saaToast1.TitleBackColor = System.Drawing.Color.Transparent;
            this.saaToast1.TitlePadding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.saaToast1.TitleText = "Notice";
            this.saaToast1.TitleTextColor = System.Drawing.Color.Linen;
            this.saaToast1.TitleTextFont = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // GeneratePayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(910, 566);
            this.Controls.Add(this.progressIndicator);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.year);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.monthName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "GeneratePayroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeneratePayroll";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GeneratePayroll_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox year;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox monthName;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2ProgressBar progressIndicator;
        private SaaUI.SaaToolTip saaToolTip1;
        private SaaUI.SaaToast saaToast1;
    }
}
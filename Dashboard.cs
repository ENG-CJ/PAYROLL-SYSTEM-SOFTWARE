using Guna.UI2.WinForms;
using MessagesDLL;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace HIMILO_ICT_PAYROLL_SYSTEM
{
    public partial class Dashboard : Form
    {
        Messages message__ = new Messages();
        public Guna2Button userButton = new Guna2Button();
        public Guna2Button empButton = new Guna2Button();
        public Guna2Button attenButton = new Guna2Button();
        public Guna2Button bonusButton = new Guna2Button();
        public Guna2Button reportButton = new Guna2Button();
        public Guna2Button payrollButton = new Guna2Button();
        public Guna2Button deaprtButton = new Guna2Button();

        public static Label userLabel = new Label();

        public string username;
        public string fullname;
        public string email;
        public string secure;
        public string ans;

        public string oldPass;

        public Dashboard()
        {
            InitializeComponent();
        }

        public Dashboard(string username, string type, Image image)
        {
            InitializeComponent();
            userLabel = LeftUsername;
            LeftUsername.Text = username;
            leftUserType.Text = type;
            leftUserProfileImage.Image = image;

            userButton = userBtn;
            empButton = empBtn;
            attenButton = attenBtn;
            reportButton = reportsBtn;
            payrollButton = payrolBtn;
            bonusButton = bonusBtn;
            deaprtButton = departBtn;


            if (type.ToLower() == "user")
                settings.Visible = false;
        }
        private void makeActive(Control control)
        {
            control.BackColor = Color.FromArgb(181, 52, 113);
            control.ForeColor = Color.White;
        }
        private void makeNotActive(params Control[] controls)
        {
            foreach (Control c in controls)
            {
                c.BackColor = Color.FromArgb(52, 73, 94);
                c.ForeColor = Color.White;
            }
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            userLabel = LeftUsername;
            OneControl.HideVisibility(
                bonusFrontEnd1,
                usersFrontEnd1,
                departmentsFrontEnd1,
                employeeFrontEnd1,
                payroll1,
                reportFrontEnd1,

                employeeAttendance1);


            readData();

            makeActive(dashbtn);
            makeNotActive(userBtn, departBtn, empBtn, attenBtn, payrolBtn, reportsBtn, bonusBtn);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ExitApplication(object sender, EventArgs e)
        {
            var result = message__.ShowWarning("Are You To Exit The Entire Application?", "Confirm");
            if (result == DialogResult.No)
                return;
            else
            {
                var query = new GeneralQuery();
                query.addLogFile(this.LeftUsername.Text, "Logout");
                new LOGIN().Show();
                this.Hide();
            }
        }

        private void DashboardButton(object sender, EventArgs e)
        {
            OneControl.HideControlOuAnimate(bonusFrontEnd1, departmentsFrontEnd1, usersFrontEnd1, employeeAttendance1, employeeFrontEnd1, payroll1, reportFrontEnd1);
            OneControl.ShowControlOutAnimate(dashControelr1);
            makeActive(dashbtn);
            makeNotActive(userBtn, departBtn, empBtn, attenBtn, payrolBtn, reportsBtn, bonusBtn);
        }

        private void ShowUsers(object sender, EventArgs e)
        {
            OneControl.HideControlOuAnimate(bonusFrontEnd1, departmentsFrontEnd1, employeeAttendance1, employeeFrontEnd1, payroll1, reportFrontEnd1,
                dashControelr1);
            OneControl.ShowControlOutAnimate(usersFrontEnd1);

            makeActive(userBtn);
            makeNotActive(dashbtn, departBtn, empBtn, attenBtn, payrolBtn, reportsBtn, bonusBtn);
        }

        private void ShowDepartments(object sender, EventArgs e)
        {
            OneControl.HideControlOuAnimate(bonusFrontEnd1, usersFrontEnd1, employeeAttendance1, employeeFrontEnd1, payroll1, reportFrontEnd1, dashControelr1);
            OneControl.ShowControlOutAnimate(departmentsFrontEnd1);

            makeActive(departBtn);
            makeNotActive(dashbtn, userBtn, empBtn, attenBtn, payrolBtn, reportsBtn, bonusBtn);
        }

        private void showBonus(object sender, EventArgs e)
        {
            OneControl.HideControlOuAnimate(usersFrontEnd1, departmentsFrontEnd1, employeeAttendance1, employeeFrontEnd1, payroll1,
                reportFrontEnd1, dashControelr1);
            OneControl.ShowControlOutAnimate(bonusFrontEnd1);

            makeActive(bonusBtn);
            makeNotActive(dashbtn, userBtn, empBtn, attenBtn, payrolBtn, reportsBtn, departBtn);
        }

        private void viewAttendance(object sender, EventArgs e)
        {
            OneControl.HideControlOuAnimate(bonusFrontEnd1, departmentsFrontEnd1, usersFrontEnd1, employeeFrontEnd1, reportFrontEnd1, payroll1, dashControelr1);
            OneControl.ShowControlOutAnimate(employeeAttendance1);

            makeActive(attenBtn);
            makeNotActive(dashbtn, userBtn, empBtn, departBtn, payrolBtn, reportsBtn, bonusBtn);
        }

        private void ShowEmployee(object sender, EventArgs e)
        {
            OneControl.HideControlOuAnimate(bonusFrontEnd1, departmentsFrontEnd1, usersFrontEnd1, employeeAttendance1, dashControelr1, payroll1, reportFrontEnd1);
            OneControl.ShowControlOutAnimate(employeeFrontEnd1);

            makeActive(empBtn);
            makeNotActive(dashbtn, userBtn, departBtn, attenBtn, payrolBtn, reportsBtn, bonusBtn);
        }

        private void ViewProfile(object sender, EventArgs e)
        {
            setMyProfile();
            var profile = new profile(this.LeftUsername.Text, fullname, email, secure, ans, this.leftUserProfileImage.Image);
            var back = FrontEnd.User_Controlers.BackDrop.backDrop(.73d);
            back.Show();

            profile.Owner = back;
            profile.ShowDialog();

            back.Dispose();
        }



        private void setMyProfile()
        {
            var conn = Connections.GetSqlConnection();
            conn.Open();
            var cmd = new SqlCommand("selectUser", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", this.LeftUsername.Text);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    fullname = reader[0].ToString();
                    email = reader[1].ToString();
                    secure = reader[2].ToString();
                    ans = reader[3].ToString();

                }
            }



            conn.Close();
        }

        private void change(object sender, EventArgs e)
        {
            readpass();
            var changePass = new ChnagePassword(oldPass, this.LeftUsername.Text);
            var back = FrontEnd.User_Controlers.BackDrop.backDrop(.73d);
            back.Show();

            changePass.Owner = back;
            changePass.ShowDialog();

            back.Dispose();
        }




        private void readpass()
        {
            var conn = Connections.GetSqlConnection();
            conn.Open();
            var cmd = new SqlCommand("readpass", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", this.LeftUsername.Text);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    oldPass = reader[0].ToString();


                }
            }



            conn.Close();
        }

        private void reportsBtn_Click(object sender, EventArgs e)
        {

            OneControl.HideControlOuAnimate(bonusFrontEnd1, departmentsFrontEnd1, usersFrontEnd1, employeeAttendance1, dashControelr1, payroll1, employeeFrontEnd1);
            OneControl.ShowControlOutAnimate(reportFrontEnd1);

            makeActive(reportsBtn);
            makeNotActive(dashbtn, userBtn, empBtn, attenBtn, payrolBtn, departBtn, bonusBtn);
        }

        private void payrolBtn_Click(object sender, EventArgs e)
        {
            OneControl.HideControlOuAnimate(bonusFrontEnd1, departmentsFrontEnd1, usersFrontEnd1, employeeAttendance1, employeeFrontEnd1, dashControelr1, reportFrontEnd1);
            OneControl.ShowControlOutAnimate(payroll1);

            makeActive(payrolBtn);
            makeNotActive(dashbtn, userBtn, empBtn, attenBtn, departBtn, reportsBtn, bonusBtn);
        }

        private void SetSettings(object sender, EventArgs e)
        {
            var back = FrontEnd.User_Controlers.BackDrop.backDrop(.80);

            back.Show();
            var setting = new Settings();
            setting.Owner = back;


            setting.ShowDialog();
            back.Dispose();
        }

        private void dashControelr1_Load(object sender, EventArgs e)
        {

        }


        private void readData()
        {
            try
            {
                var con = Connections.GetSqlConnection();
                con.Open();
                var cmd = new SqlCommand("select *from company", con);
                var readrer = cmd.ExecuteReader();
                while (readrer.Read())
                {
                    if (readrer.HasRows)
                    {
                        mainTitle.Text = readrer[0].ToString();
                        subtitle.Text = readrer[1].ToString();

                        mainLogo.Image = Controlers.ImageControler.GteImageFromStream(readrer[3]);
                    }

                }
                readrer.Close();
                con.Close();

            }
            catch (Exception ex)
            {
                message__.ShowError(ex.Message, "Error Occurs");
            }


        }
    }
}

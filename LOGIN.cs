using HIMILO_ICT_PAYROLL_SYSTEM.Controlers;
using MessagesDLL;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIMILO_ICT_PAYROLL_SYSTEM
{
    public partial class LOGIN : Form
    {
        Messages message_ = new Messages();

        Users users = new Users();
        private bool isValid = false;
        public static string userRole;
        public LOGIN()
        {
            InitializeComponent();
        }

        private void Exit(object sender, System.EventArgs e)
        {
            var resultInfo = message_.ShowWarning("Are You ure To Exit?", "Confirm");
            if (resultInfo == DialogResult.No)
                return;
            else
                this.Close();
        }

        private void ForgotPassword(object sender, System.EventArgs e)
        {
            new EmailValidator().Show();
            this.Hide();
        }

        private void ShowPassword(object sender, System.EventArgs e)
        {
            if (password.PasswordChar == '*')
            {
                password.PasswordChar = '\0';
                hidePas.BringToFront();
            }
        }

        private void HidePassword(object sender, System.EventArgs e)
        {
            if (password.PasswordChar == '\0')
            {
                password.PasswordChar = '*';
                showPass.BringToFront();
            }
        }

        private void RememberMe(object sender, System.EventArgs e)
        {
            if (rememberMeCheckBox.Checked)
                setData(true);
            else
                setData(false);
        }




        private void setData(bool type)
        {

            if (type)
            {

                Properties.Settings.Default.username = username.Text;
                Properties.Settings.Default.password = password.Text;
                Properties.Settings.Default.isRemembered = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.username = null;
                Properties.Settings.Default.password = null;
                Properties.Settings.Default.isRemembered = false;
                Properties.Settings.Default.Save();
            }
        }


        private void GetData()
        {
            if (Properties.Settings.Default.isRemembered)
            {
                username.Text = Properties.Settings.Default.username;
                password.Text = Properties.Settings.Default.password;
                rememberMeCheckBox.Checked = true;
            }
            else
            {

                username.Text = "";
                password.Text = "";
                rememberMeCheckBox.Checked = false;
            }
        }

        private void LOGIN_Load(object sender, System.EventArgs e)
        {
           
            readData();
            GetData();

        }

        private void username_TextChanged(object sender, System.EventArgs e)
        {

            if (rememberMeCheckBox.Checked)
            {
                Properties.Settings.Default.username = username.Text;
                Properties.Settings.Default.isRemembered = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.username = null;
                Properties.Settings.Default.isRemembered = false;
                Properties.Settings.Default.Save();
            }


        }

        private void password_TextChanged(object sender, System.EventArgs e)
        {

            if (rememberMeCheckBox.Checked)
            {
                Properties.Settings.Default.password = password.Text;
                Properties.Settings.Default.isRemembered = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.password = null;
                Properties.Settings.Default.isRemembered = false;
                Properties.Settings.Default.Save();
            }

        }

        private async void Login(object sender, System.EventArgs e)
        {
            guna2Button1.Enabled = false;
            await loginAsync();
            guna2Button1.Enabled = true;


        }

        private void pictureBox2_Click(object sender, System.EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, System.EventArgs e)
        {

        }

        private void label2_Click(object sender, System.EventArgs e)
        {

        }



        private async Task loginAsync()
        {
            await Task.Run(() =>
            {

                isValid = users.isValidUser(username.Text, password.Text);
                if (users.QueryHasError)
                {
                    message_.ShowError($"Something Went Wrong....\n{users.ErrorMessage}", "Error");
                    return;
                }


            });
            if (isValid)
            {
                // with checking

                if (users.logonUserType.ToLower() == "admin")

                {
                    var query = new GeneralQuery();
                    query.addLogFile(this.username.Text, "Login");
                    userRole = users.logonUserType;
                    new Dashboard(users.logonUser, users.logonUserType, users.logonUserProfile).Show();
                    this.Hide();
                }
                else if (users.logonUserType.ToLower() == "user")
                {
                    userRole = users.logonUserType;
                    var dash = new Dashboard(users.logonUser, users.logonUserType, users.logonUserProfile);

                    // hide user controlers with access levels
                    OneControl.HideControlOuAnimate(dash.userButton, dash.bonusButton
                        , dash.payrollButton, dash.deaprtButton);

                    var query = new GeneralQuery();
                    query.addLogFile(this.username.Text, "Login");

                    dash.Show();
                    this.Hide();

                }




                ///// no checking

                //new Dashboard(users.logonUser, users.logonUserType, users.logonUserProfile).Show();
                //this.Hide();
            }
            else
                message_.ShowError("Incorrect Username Or Password..", "Error | User Validator");
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
                        title.Text = readrer[0].ToString();
                        subtitle.Text = readrer[1].ToString();

                        logo.Image = Controlers.ImageControler.GteImageFromStream(readrer[3]);
                    }

                }
                readrer.Close();
                con.Close();

            }
            catch (Exception ex)
            {
                message_.ShowError(ex.Message, "Error Occurs");
            }


        }
    }
}

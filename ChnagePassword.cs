using MessagesDLL;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace HIMILO_ICT_PAYROLL_SYSTEM
{
    public partial class ChnagePassword : Form
    {
        public string oldPass;
        public string username;
        Messages msg = new Messages();
        public ChnagePassword()
        {
            InitializeComponent();
        }


        public ChnagePassword(string olPass, string user)
        {
            InitializeComponent();
            oldPass = olPass;
            username = user;
        }

        private void dashboard(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangePass(object sender, EventArgs e)
        {
            if (Validations.validateAllBlanks(currentpassword, newPass, confirmPas))
                msg.ShowError("All Fields Are required, If You Want To Change Your password..", "Error");
            else if (this.currentpassword.Text == oldPass)
            {
                if (newPass.Text.Length >= 6 && newPass.Text.Length <= 10)
                {
                    if (confirmPas.Text == newPass.Text)
                    {
                        if (newPass.Text == currentpassword.Text)
                        {
                            msg.ShowError("New  Password Cannot Same As Old Password..", "Error");
                            OneControl.ClearControles(confirmPas, newPass);
                            return;
                        }

                        var result = msg.ShowWarning("Are You Sure To Change Your old Password? Press Yes To continue", "Confirm");
                        if (result == DialogResult.No)
                            return;
                        else
                        {
                            changeMypass();
                            msg.ShowInfo("You Password Has Been Changed Successfully....", "Changing Password");
                            this.Close();
                        }
                    }
                    else
                    {
                        msg.ShowError("Confirm Password Must Match The New Password....", "Error");
                        OneControl.ClearControles(confirmPas);
                    }
                }
                else
                {
                    msg.ShowError("Password Length Must Between 6 and 10 Characteres..", "Error");
                    OneControl.ClearControles(confirmPas, newPass);

                }

            }
            else
            {
                msg.ShowError("Current Password You Provide Is Incorrect....", "Error");
                OneControl.ClearControles(confirmPas, newPass, currentpassword);
            }

        }

        private void currentpassword_TextChanged(object sender, EventArgs e)
        {
            if (this.currentpassword.Text == "")
            {
                this.currentpassword.BorderColor = Color.FromArgb(44, 44, 84);
                this.currentpassword.HoverState.BorderColor = Color.FromArgb(44, 44, 84);
                this.currentpassword.FocusedState.BorderColor = Color.FromArgb(44, 44, 84);
            }
            else if (this.currentpassword.Text == oldPass)
            {
                this.currentpassword.BorderColor = Color.FromArgb(44, 44, 84);
                this.currentpassword.HoverState.BorderColor = Color.FromArgb(44, 44, 84);
                this.currentpassword.FocusedState.BorderColor = Color.FromArgb(44, 44, 84);
            }
            else
            {
                this.currentpassword.BorderColor = Color.FromName("Red");
                this.currentpassword.HoverState.BorderColor = Color.FromName("Red");
                this.currentpassword.FocusedState.BorderColor = Color.FromName("Red");
            }
        }



        private void changeMypass()
        {
            var conn = Connections.GetSqlConnection();
            conn.Open();
            var cmd = new SqlCommand("updateUserPass", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@newPass", this.newPass.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
                ShowPassword();
            else
                HidePassword();
        }


        private void ShowPassword()
        {
            if (newPass.PasswordChar == '*')
            {
                newPass.PasswordChar = '\0';

            }
        }

        private void HidePassword()
        {
            if (newPass.PasswordChar == '\0')
            {
                newPass.PasswordChar = '*';

            }
        }
    }
}

using MessagesDLL;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace HIMILO_ICT_PAYROLL_SYSTEM
{
    public partial class UsernameValidator : Form
    {
        Messages msg = new Messages();
        public string user;
        public UsernameValidator()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Continue(object sender, EventArgs e)
        {
            if (Validations.validateAllBlanks(username))
                msg.ShowError("Username is Required.....", "Error");
            else
            {
                if (isValid())
                {
                    new Forget(user).Show();
                    this.Hide();
                }
                else
                    msg.ShowError("The Username You Provide Does not exist....", "Error");
            }

        }



        private bool isValid()
        {
            var valid = false;
            try
            {

                var con = Connections.GetSqlConnection();
                con.Open();
                var cmd = new SqlCommand("select UserName from users where UserName=@user", con);
                cmd.Parameters.AddWithValue("@user", username.Text);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        user = reader[0].ToString();
                        valid = true;
                    }
                }
            }
            catch (Exception ex)
            {
                msg.ShowError(ex.Message);
            }
            return valid;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new LOGIN().Show();
            this.Hide();
        }
    }
}

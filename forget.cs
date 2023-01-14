using MessagesDLL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HIMILO_ICT_PAYROLL_SYSTEM
{
    public partial class Forget : Form
    {
        public string VALIDanswer;

        Messages msg = new Messages();
        public string email;
        public string user;
        public string accessFrom;
        public Forget()
        {
            InitializeComponent();
        }

        public Forget(string user)
        {
            InitializeComponent();
            this.user = user;
            accessFrom = "OneParam";
        }

        private void ShowPassword(object sender, System.EventArgs e)
        {
            if (pass.PasswordChar == '*')
            {
                pass.PasswordChar = '\0';
                hidePass.BringToFront();
            }
        }

        private void HidePassword(object sender, System.EventArgs e)
        {
            if (pass.PasswordChar == '\0')
            {
                pass.PasswordChar = '*';
                showPass.BringToFront();
            }
        }

        public Forget(string email, string secure, string ans)
        {
            InitializeComponent();
            this.secure.Text = secure;
            VALIDanswer = ans;
            this.email = email;

            accessFrom = "ThreeParam";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

            if (answer.Text == VALIDanswer)
            {
                pass.Enabled = true;
                conf.Enabled = true;
                reset.Enabled = true;
            }
            else
            {
                pass.Enabled = false;
                conf.Enabled = false;
                reset.Enabled = false;
            }
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            try
            {
                if (pass.Text == "" || conf.Text == "")
                    msg.ShowError("New pass is Required...", "Error");
                else if (pass.Text.Length >= 5 && pass.Text.Length <= 10)
                {


                    if (pass.Text == conf.Text)
                    {
                        var result = msg.ShowWarning("Press Yes To Continue tO Reset Your Password...", "Confirmation | Password");
                        if (result == DialogResult.No)
                            return;
                        else
                        {
                            if (accessFrom == "ThreeParam")
                            {
                                update();
                                msg.ShowInfo("Your Password Successfully Reset Go To Login Window To Continue Login...", "Information | HIMILO");
                                new LOGIN().Show();
                                this.Hide();
                            }
                            else if (accessFrom == "OneParam")
                            {
                                updatePass();
                                msg.ShowInfo("Your Password Successfully Reset Go To Login Window To Continue Login...", "Information | HIMILO");
                                new LOGIN().Show();
                                this.Hide();
                            }

                        }

                    }
                    else
                    {
                        msg.ShowError("Passwords Did't Match, Match Passwords.... ", "Error | Password");
                        OneControl.ClearControles(conf);
                    }
                }
                else
                {
                    msg.ShowError("Password Length Must Between 6 and 10 Chaarcters...", "Error Password Length | HIMILO");
                    OneControl.ClearControles(pass, conf);
                }
            }
            catch (Exception ex)
            {
                msg.ShowError(ex.Message, "Error");
            }
        }



        private void update()
        {

            var con = Connections.GetSqlConnection();
            con.Open();
            var cmd = new SqlCommand("updatePass", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@newPass", pass.Text);

            cmd.ExecuteNonQuery();
            con.Close();


        }

        private void updatePass()
        {

            var con = Connections.GetSqlConnection();
            con.Open();
            var cmd = new SqlCommand("update users set  password=@pass where UserName=@user", con);

            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass.Text);

            cmd.ExecuteNonQuery();
            con.Close();


        }

        private void HIMILO_ICT_PAYROLL_SYSTEM_Load(object sender, EventArgs e)
        {
            if (accessFrom == "OneParam")
                read();
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new LOGIN().Show();
            this.Hide();
        }

        private void answerChanging(object sender, EventArgs e)
        {
            if (answer.Text == VALIDanswer)
            {
                pass.Enabled = true;
                conf.Enabled = true;
                reset.Enabled = true;
            }
            else
            {
                pass.Enabled = false;
                conf.Enabled = false;
                reset.Enabled = false;
            }
        }


        private void read()
        {

            var con = Connections.GetSqlConnection();
            con.Open();
            var cmd = new SqlCommand("select securityQ, answer from users where UserName=@user", con);

            cmd.Parameters.AddWithValue("@user", user);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    secure.Text = reader[0].ToString();
                    VALIDanswer = reader[1].ToString();

                }
            }


            con.Close();


        }
    }
}

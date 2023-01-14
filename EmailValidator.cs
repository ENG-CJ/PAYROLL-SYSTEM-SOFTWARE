
using MessagesDLL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace HIMILO_ICT_PAYROLL_SYSTEM
{
    public partial class EmailValidator : Form
    {
        public string secure;
        public string ans;

        Messages msg = new Messages();
        public EmailValidator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            if (email.Text == "")
                msg.ShowError("Your Email Address is Required....", "Error");

            else if (Validations.IsValidEmail(email.Text))
            {

                await searchAsync();

                if (ISVALIDUSER())
                {
                    //
                    new Forget(email.Text, secure, ans).Show();
                    this.Hide();
                }
                else
                    msg.ShowError("Icorrect Email Address, Provide Your valid Account In order To Reset Your Password", "Error");
            }
            else
                msg.ShowError("Invalid Format  Email Address, Provide Valid Format Address Eg. someOne@gmail.com", "Error");
        }



        private bool ISVALIDUSER()
        {
            var valid = false;
            var con = Connections.GetSqlConnection();
            con.Open();
            var cmd = new SqlCommand("findMyEmail", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@email", email.Text);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    secure = reader[0].ToString();
                    ans = reader[1].ToString();
                    valid = true;
                }
            }


            con.Close();

            return valid;
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            if (email.Text == "")
            {
                email.BorderColor = Color.FromArgb(44, 44, 84);
                email.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
                email.HoverState.BorderColor = Color.FromArgb(94, 148, 255);

            }
            else if (Validations.IsValidEmail(email.Text))
            {
                email.BorderColor = Color.FromArgb(44, 44, 84);
                email.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
                email.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            }
            else
                email.BorderColor = Color.FromName("Red");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new LOGIN().Show();
            this.Close();
        }



        private async Task searchAsync()
        {
            await Task.Run(async () =>
            {
                for (int i = 1; i <= 4; i++)
                {
                    await Task.Delay(70);
                }
            });
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void login(object sender, EventArgs e)
        {
            new LOGIN().Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new OwnEmailValidator().Show();
            this.Hide();
        }
    }
}

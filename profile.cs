using MessagesDLL;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace HIMILO_ICT_PAYROLL_SYSTEM
{
    public partial class profile : Form
    {
        Messages msg = new Messages();
        public profile()
        {
            InitializeComponent();
        }

        public string username;
        public string secureityQues;
        public string ansSec;
        public string UserFullname;
        public string emailuser;
        public Image imag;

        public profile(string user, string fullanme, string email, string sec, string ans, Image img)
        {
            InitializeComponent();

            username = user;
            UserFullname = fullanme;
            emailuser = email;
            secureityQues = sec;
            ansSec = ans;
            imag = img;

            this.name.Text = UserFullname;
            this.ansQ.Text = emailuser;
            this.secQueston.Text = secureityQues;
            this.ansQ.Text = ansSec;
            this.userpoto.Image = imag;
            this.email.Text = emailuser;

        }

        private void profile_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void signout(object sender, EventArgs e)
        {
            this.Hide();
            this.Hide();
            new LOGIN().Show();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void userpoto_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void type_Click(object sender, EventArgs e)
        {

        }

        private void EDitProfiel(object sender, EventArgs e)
        {
            if (
                this.name.Text == UserFullname &&
                this.email.Text == emailuser &&
                this.secQueston.Text == secureityQues &&
                this.ansQ.Text == ansSec &&
                this.userpoto.Image == imag
                )

                return;
            else
            {
                if (Validations.validateAllBlanks(
                    name, email, secQueston, ansQ
                    ))
                    msg.ShowError("Blank Fields Can't Be Updated...", "Error");
                else
                {
                    updateProfile();
                    var result = msg.AskQuestion("Some Changes Will Effect After The System Restarts Do You Want To Restart? Press Yes To Restart Or No To Stay Up.......", "Profile Updater");

                    if (result == DialogResult.No)
                        this.Close();
                    else
                        Application.Restart();
                }
            }
        }

        private void BROWSEIMAGE(object sender, EventArgs e)
        {
            if (OPENIMAGE.ShowDialog() == DialogResult.OK)
            {
                userpoto.Image = Image.FromFile(OPENIMAGE.FileName);

            }
        }


        private void updateProfile()
        {

            try
            {
                SqlConnection connection = Connections.GetSqlConnection();
                connection.Open();
                SqlCommand command = new SqlCommand("update users set fullName=@name, email=@email, securityQ=@sec, answer=@ans, photo=@Photo where UserName=@username", connection);
                //   command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@name", this.name.Text);
                command.Parameters.AddWithValue("@email", email.Text);
                command.Parameters.AddWithValue("@sec", secQueston.Text);

                command.Parameters.AddWithValue("@ans", ansQ.Text);
                command.Parameters.AddWithValue("@username", username);


                if (userpoto.Image != null)
                    command.Parameters.AddWithValue("@Photo", Controlers.ImageControler.SaveImageIntoStream(userpoto.Image).ToArray());
                else
                    command.Parameters.AddWithValue("@Photo", Controlers.ImageControler.SaveImageIntoStream(Properties.Resources.user_male).ToArray());

                command.ExecuteNonQuery();
                connection.Close();

            }
            catch (Exception ex)
            {
                msg.ShowError("Error Occured...\n" + ex.Message, "Error");
            }


        }
    }
}

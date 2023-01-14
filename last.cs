using System;
using System.Windows.Forms;

namespace HIMILO_ICT_PAYROLL_SYSTEM
{
    public partial class last : Form
    {

        public string fullname;
        public string gmail;
        public string password;

        public last()
        {
            InitializeComponent();
        }



        public last(string user, string name, string email, string pass)
        {
            InitializeComponent();
            username.Text = user;
            fullname = name;
            gmail = email;
            password = pass;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.isConfigured = true;
            Properties.Settings.Default.logedFullname = fullname;
            Properties.Settings.Default.logedUsername = username.Text;
            Properties.Settings.Default.logedEmail = gmail;
            Properties.Settings.Default.logedPass = password;
            Properties.Settings.Default.Save();

            new ProductkeySender().Show();
            this.Hide();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

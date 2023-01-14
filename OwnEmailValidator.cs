using MessagesDLL;
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace HIMILO_ICT_PAYROLL_SYSTEM
{
    public partial class OwnEmailValidator : Form
    {
        Messages msg = new Messages();
        public int otpCode;
        public OwnEmailValidator()
        {
            InitializeComponent();
        }

        private async void SEND(object sender, EventArgs e)
        {
            if (email.Text == "")
                msg.ShowError("Your Email Address is Required....", "Error");

            else if (Validations.IsValidEmail(email.Text))
            {
                if (isAvailable())
                {
                    var r = msg.ShowWarning("NOTE : We Will Send OTP Code This Email, Are You Sure This Email is Your Email Account?", "Confirmation");
                    if (r == DialogResult.No)
                        return;
                    else
                    {
                        guna2Button1.Text = "Sending......";
                        guna2Button1.Enabled = false;
                        await sendAsync();
                        guna2Button1.Text = "Send OTP";
                        guna2Button1.Enabled = true;
                        msg.ShowInfo("OTP CODE SUCCESSFULLY SENT....", "OTP");
                        new OTPCODE(otpCode.ToString(), email.Text).Show();
                        this.Hide();

                    }
                }
                else
                    msg.ShowError(ErrorConection.Text, "Error");
            }
            else
                msg.ShowError("Invalid Format  Email Address, Provide Valid Format Address Eg. someOne@gmail.com", "Error");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new EmailValidator().Show();
            this.Hide();
        }

        private void OwnEmailValidator_Load(object sender, EventArgs e)
        {

        }


        public bool isAvailable()
        {
            return System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();

        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            if (isAvailable())
                ErrorConection.Visible = false;
            else
                ErrorConection.Visible = true;
        }



        private async Task sendAsync()
        {

            await Task.Run(() =>
            {
                try
                {
                    var random = new Random();
                    otpCode = random.Next(1000, 9999);
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
                        Subject = "JAMHUURIYA UNIVERSITY -PAYROLL SYSTEM - OTP VERIFICATION CODE",
                        Body = $"<h2>OTP CODE </h2></br><p>Your OTP Code Enables You To Reset Your password Even If You Forgot Your Gmail Account Logged In  The System</p>" +
                        $"<h3>OTP : {otpCode}</h3>",
                        IsBodyHtml = true
                    };

                    mail.To.Add(email.Text);
                    client.Send(mail);
                }
                catch (Exception ex)
                {
                    msg.ShowError($"{ex.Message}", "Email Error");
                }
            });

        }
    }

}

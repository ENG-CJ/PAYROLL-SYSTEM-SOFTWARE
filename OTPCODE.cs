using MessagesDLL;
using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace HIMILO_ICT_PAYROLL_SYSTEM
{
    public partial class OTPCODE : Form
    {
        public string otpCode;
        public string emailUser;
        Messages msg = new Messages();
        public OTPCODE()
        {
            InitializeComponent();
        }


        public OTPCODE(string otp, string email)
        {
            InitializeComponent();
            otpCode = otp;
            emailUser = email;
        }

        private void OTPCODE_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            new LOGIN().Show();
            this.Hide();
        }

        private void Verify(object sender, EventArgs e)
        {
            if (Validations.validateAllBlanks(num1, num2, num3, num4))
            {
                msg.ShowError("Fill All OTP Code Boxes....", "OTP ERROR | BLANK");
                return;
            }

            var resultConcat = num1.Text + num2.Text + num3.Text + num4.Text;
            if (resultConcat == otpCode)
            {
                new UsernameValidator().Show();
                this.Hide();
            }
            else
            {
                msg.ShowError("Invalid OTP Code....", "Error");
                OneControl.ClearControles(num1, num2, num3, num4);
            }

        }

        private void resend(object sender, EventArgs e)
        {
            OneControl.ClearControles(num1, num2, num3, num4);
            resendOTP();
            msg.ShowInfo("OTP RESENT SUCCESSFULLY.....", "OTP");
        }



        private void resendOTP()
        {

            try
            {
                var random = new Random();
                int randDom = random.Next(1000, 9999);
                otpCode = randDom.ToString();
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

                mail.To.Add(emailUser);
                client.Send(mail);
            }
            catch (Exception ex)
            {
                msg.ShowError($"{ex.Message}", "Email Error");
            }

        }

        private void num1_TextChanged(object sender, EventArgs e)
        {
            
          
        }
    }
}

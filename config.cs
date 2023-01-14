using HIMILO_ICT_PAYROLL_SYSTEM.Controlers;
using MessagesDLL;
using System;
using System.Windows.Forms;
using System.Drawing;
namespace HIMILO_ICT_PAYROLL_SYSTEM
{
    public partial class config : Form
    {
        Messages messages = new Messages();
        public config()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void config_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void BROWSEIMAGE(object sender, EventArgs e)
        {
            if (OPENIMAGE.ShowDialog() == DialogResult.OK)
            {
                user.Image = Image.FromFile(OPENIMAGE.FileName);
                CoverPhoto.SendToBack();
                user.BringToFront();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (Validations.validateAllBlanks(fullname, username, email, pass))
                messages.ShowError("All Fields Are required", "Error");

            else if (!Validations.IsValidEmail(email.Text))
                messages.ShowError($"{email.Text}  is Not valid Email Plz Input Valid Format Email", "Error");
            else if (!Validations.ValidPassLength(pass.Text, 10, 6))
                messages.ShowError("Password Length Must between 6 and 10 characetrs", "Error");

            else
            {
                if (Validations.isExistUser(username.Text))
                    messages.ShowError($"The Username [ {username.Text} ] Already Taken, Choose Another One.", $"Error | Username [ {username.Text }");
                else if (Validations.isExistEmail(email.Text))
                    messages.ShowError($"The Email [ {email.Text} ] Already Taken, Choose Another One.", $"Error | Email [ {email.Text }");
                else
                {
                    if (guna2CheckBox1.Checked)
                    {
                        var question = securityQuestionSelector.Text;
                        var ans = "two rakca";
                        Users users = new Users()
                        {
                            fullName = fullname.Text,
                            username = username.Text,
                            password = pass.Text,
                            securityQUestion = question,
                            answer = ans,
                            Email = email.Text,
                            userType = "Admin",
                            UserPhoto = user.Image
                        };
                        users.AddUser();
                        if (users.QueryHasError)
                            messages.ShowError($"Something Went Wrong\n\n{users.ErrorMessage}", "Error");
                        else
                        {
                            messages.ShowInfo("NOTICE:\nPlz Remember Your Gmail, Security Question and Answer, In Case You Forgot Your Password\n" +
                                " This Will Help You To Reset Your Password.", "Commits");
                            messages.ShowInfo($"Account With the Username {username.Text} Has Been Configured Successfully\nNow You Can Use The System...", "HIMILO USER CREATION");

                            last l = new last(username.Text, fullname.Text, email.Text, pass.Text);
                            l.Show();
                            this.Hide();

                        }
                    }
                    else if (!guna2CheckBox1.Checked && securityQuestionSelector.SelectedIndex == 0)
                        messages.ShowError("Select Security Question Or Use Default Security Question By Checking Checkbox below", "Error");
                    else
                    {
                        if (securityQuestionSelector.Visible && securityQuestionSelector.SelectedIndex != 0 && answer.Enabled)
                        {
                            if (answer.Text == "")
                                messages.ShowError("Type Your Answer For The Specified Question...", "Error");
                            else
                            {
                                // passed on selection

                                Users users = new Users()
                                {
                                    fullName = fullname.Text,
                                    username = username.Text,
                                    password = pass.Text,
                                    securityQUestion = securityQuestionSelector.Text,
                                    answer = answer.Text,
                                    Email = email.Text,
                                    userType = "Admin",
                                    UserPhoto = user.Image
                                };
                                users.AddUser();
                                if (users.QueryHasError)
                                    messages.ShowError($"Something Went Wrong\n\n{users.ErrorMessage}", "Error");
                                else
                                {
                                    messages.ShowInfo("NOTICE:\nPlz Remember Your Gmail, Security Question and Answer, In Case You Forgot Your Password\n" +
                                        " This Will Help You To Reset Your Password.", "Commits");
                                    messages.ShowInfo($"Account With the Username {username.Text} Has Been Created Successfully...", "HIMILO USER CREATION");

                                    last l = new last(username.Text, fullname.Text, email.Text, pass.Text);
                                    l.Show();
                                    this.Hide();

                                }

                                // end
                            }
                        }
                        else if (securityQuestion.Visible && answer.Enabled)
                        {
                            if (securityQuestion.Text == "" || answer.Text == "")
                                messages.ShowError("Write Your Security Question and Answer Explicitly...", "Error");
                            else
                            {
                                Users users = new Users()
                                {
                                    fullName = fullname.Text,
                                    username = username.Text,
                                    password = pass.Text,
                                    securityQUestion = securityQuestion.Text,
                                    answer = answer.Text,
                                    Email = email.Text,
                                    userType = "Admin",
                                    UserPhoto = user.Image
                                };
                                users.AddUser();
                                if (users.QueryHasError)
                                    messages.ShowError($"Something Went Wrong\n\n{users.ErrorMessage}", "Error");
                                else
                                {
                                    messages.ShowInfo("NOTICE:\nPlz Remember Your Gmail, Security Question and Answer, In Case You Forgot Your Password\n" +
                                        " This Will Help You To Reset Your Password.", "Commits");
                                    messages.ShowInfo($"Account With the Username {username.Text} Has Been Created Successfully...", "HIMILO USER CREATION");

                                    last l = new last(username.Text, fullname.Text, email.Text, pass.Text);
                                    l.Show();
                                    this.Hide();
                                }
                            }
                        }

                    }

                }


            }

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked && !securityQuestion.Visible)
            {
                securityQuestionSelector.Enabled = false;
                securityQuestionSelector.SelectedIndex = 0;
                answer.Enabled = false;
                answer.Text = "two rakca";
                return;
            }
            if (securityQuestion.Visible && guna2CheckBox1.Checked)
            {

                answer.Text = "two rakca";
                answer.Enabled = false;
                securityQuestionSelector.SelectedIndex = 0;
                securityQuestionSelector.Visible = true;
                securityQuestion.Visible = false;
                return;
            }

            securityQuestionSelector.Enabled = true;
            answer.Enabled = true;
        }

        private void securityQuestionSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (securityQuestionSelector.SelectedIndex == 0)
            {
                answer.Text = "two rakca";
                securityQuestionSelector.Enabled = false;
                answer.Enabled = false;
                guna2CheckBox1.Checked = true;
                return;

            }
            else if (securityQuestionSelector.SelectedItem.ToString() == "Other")
            {
                securityQuestionSelector.Visible = false;
                securityQuestion.Visible = true;
                answer.Enabled = true;
                answer.Text = "";
            }
            else
            {
                answer.Enabled = true;
                answer.Text = "";
            }
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

        private void CoverPhoto_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

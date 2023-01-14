using HIMILO_ICT_PAYROLL_SYSTEM.Controlers;
using HIMILO_ICT_PAYROLL_SYSTEM.FrontEnd.User_Controlers;
using MessagesDLL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HIMILO_ICT_PAYROLL_SYSTEM.FrontEnd.Forms
{
    public partial class UserRegistration : Form
    {
        Messages messages = new Messages();
        public UserRegistration()
        {
            InitializeComponent();
        }

        public UserRegistration(string buttonText)
        {
            InitializeComponent();
            saveBtn.Text = buttonText;
        }

        private void CloseThisWindow(object sender, EventArgs e)
        {
            Close();
        }

        private void UserRegistration_Load(object sender, EventArgs e)
        {

        }

        private void CoverPhoto_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SaveUser(object sender, EventArgs e)
        {
            try
            {
                if (Validations.validateAllBlanks(fullname, username, email, pass))
                    messages.ShowError("All Fields Are required", "Error");
                else if (Validations.ComboNotSelectedValue("Select", type))
                    messages.ShowError("user Type is required", "Error");
                else if (!Validations.IsValidEmail(email.Text))
                    messages.ShowError($"{email.Text}  is Not valid Email Plz Input Valid Format Email", "Error");
                else if (!Validations.ValidPassLength(pass.Text, 10, 6))
                    messages.ShowError("Password Length Must between 6 and 10 characetrs", "Error");
                else if (!Validations.HasValidName(fullname.Text))
                    messages.ShowError("User FullName Must Be Valid Name, Only Character Values", "Error");

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
                                userType = type.Text,
                                UserPhoto = userImage.Image
                            };
                            users.AddUser();
                            if (users.QueryHasError)
                                messages.ShowError($"Something Went Wrong\n\n{users.ErrorMessage}", "Error");
                            else
                            {
                                messages.ShowInfo("NOTICE:\nPlz Remember Your Gmail, Security Question and Answer, In Case You Forgot Your Password\n" +
                                    " This Will Help You To Reset Your Password.", "Commits");
                                messages.ShowInfo($"Account With the Username {username.Text} Has Been Created Successfully...", "HIMILO USER CREATION");
                                GeneralQuery query = new GeneralQuery();
                                var usersData = new Controlers.Users();
                                var data = usersData.GetData(Dashboard.userLabel.Text);


                                UsersFrontEnd.dataGridView.DataSource = data;
                                OneControl.ClearControles(fullname, username, email, pass, securityQuestion, answer);
                                OneControl.ClearControles("Select", type);
                                OneControl.ClearImages(CoverPhoto, label9, userImage);
                                var gen = new GeneralQuery();
                                gen.CountData("countUsers", DashControelr.totalUsrs);
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
                                        userType = type.Text,
                                        UserPhoto = userImage.Image
                                    };
                                    users.AddUser();
                                    if (users.QueryHasError)
                                        messages.ShowError($"Something Went Wrong\n\n{users.ErrorMessage}", "Error");
                                    else
                                    {
                                        messages.ShowInfo("NOTICE:\nPlz Remember Your Gmail, Security Question and Answer, In Case You Forgot Your Password\n" +
                                            " This Will Help You To Reset Your Password.", "Commits");
                                        messages.ShowInfo($"Account With the Username {username.Text} Has Been Created Successfully...", "HIMILO USER CREATION");
                                        GeneralQuery query = new GeneralQuery();
                                        var data = query.GetData("getUsers");

                                        UsersFrontEnd.dataGridView.DataSource = data;
                                        OneControl.ClearControles(fullname, username, email, pass, securityQuestion, answer);
                                        OneControl.ClearControles("Select", type);
                                        OneControl.ClearImages(CoverPhoto, label9, userImage);
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
                                        userType = type.Text,
                                        UserPhoto = userImage.Image
                                    };
                                    users.AddUser();
                                    if (users.QueryHasError)
                                        messages.ShowError($"Something Went Wrong\n\n{users.ErrorMessage}", "Error");
                                    else
                                    {
                                        messages.ShowInfo("NOTICE:\nPlz Remember Your Gmail, Security Question and Answer, In Case You Forgot Your Password\n" +
                                            " This Will Help You To Reset Your Password.", "Commits");
                                        messages.ShowInfo($"Account With the Username {username.Text} Has Been Created Successfully...", "HIMILO USER CREATION");
                                        GeneralQuery query = new GeneralQuery();
                                        var data = query.GetData("getUsers");

                                        UsersFrontEnd.dataGridView.DataSource = data;
                                        OneControl.ClearControles(fullname, username, email, pass, securityQuestion, answer);
                                        OneControl.ClearControles("Select", type);
                                        OneControl.ClearImages(CoverPhoto, label9, userImage);
                                    }
                                }
                            }

                        }

                    }


                }
            }
            catch (Exception ex)
            {
                messages.ShowError(ex.Message, "Error");
            }


        }

        private void BroswMyImage(object sender, EventArgs e)
        {
            try
            {
                if (browseImage.ShowDialog() == DialogResult.OK)
                {

                    userImage.Image = Image.FromFile(browseImage.FileName);
                    CoverPhoto.SendToBack();
                    userImage.BringToFront();
                }
            }
            catch (Exception ex)
            {
                messages.ShowError($"Error Occured While Opening The File.\nError Message : {ex.Message}", "Error | Uploading");
            }

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
            //  }
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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void answer_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void fullname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace HIMILO_ICT_PAYROLL_SYSTEM.FrontEnd.Forms
{
    public partial class UserUpdater : Form
    {

        public string emailUpdater;
        MessagesDLL.Messages msg = new
                    MessagesDLL.Messages();

        public bool isUpdatedUser = false;
        public bool isUpdatedEmail = false;
        public bool isUpdatedName = false;
        public bool isUpdatedType = false;

        public bool isUpdatedStatus = false;


        public string oldUsername;
        public string oldEmail;

        public UserUpdater()
        {
            InitializeComponent();
        }


        public UserUpdater(string username, string fullname, string email, string type, Image image, string status, string security, string
            answer)
        {
            InitializeComponent();
            this.username.Text = username;
            this.fullname.Text = fullname;
            this.email.Text = email;

            this.type.SelectedItem = type;
            userImage.Image = image;
            userImage.BringToFront();

            emailUpdater = email;
            if (status.ToLower() == "active")
                statusActive.Checked = true;
            else
                statusActive.Checked = false;

            oldUsername = username;
            oldEmail = email;
            this.securityQ.Text = security;
            this.answer.Text = answer;

        }

        private void ClsoeWindiow(object sender, EventArgs e)
        {
            Close();
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
                msg.ShowError($"Error Occured While Opening The File.\nError Message : {ex.Message}", "Error | Uploading");
            }
        }

        private void Savechanges(object sender, EventArgs e)
        {
            if (Validations.validateAllBlanks(fullname, username, email, securityQ, answer))
                msg.ShowError("Blank Field Can't be Updated Plz Fill All Blank Fields", "Error | Updating");
            else if (!Validations.HasValidName(fullname.Text))
                msg.ShowError("User FullName Must Be Valid Name, Only Character Values", "Error");
            else if (Validations.IsValidEmail(email.Text))
            {
                if (Validations.ComboNotSelectedValue("Select", type))
                    msg.ShowError("User Type Cannot Be 'Select' Value, Plz Select User Type...", "Error | Updating");
                else
                {


                    var users = new Controlers.Users()
                    {
                        username = username.Text,
                        Email = email.Text,
                        fullName = fullname.Text,
                        userType = type.Text,
                        securityQUestion = securityQ.Text,
                        answer = answer.Text,
                        UserPhoto = userImage.Image,
                        updaterEmail = emailUpdater
                    };
                    if (statusActive.Checked)
                        users.status = "active";
                    else
                        users.status = "Blocked";
                    users.updateUser();
                    if (users.QueryHasError)
                        msg.ShowError($"Something Went Wrong\n\nError Message\n-------------------\n{users.ErrorMessage}", "Error");
                    else
                        msg.ShowInfo($"User That has {emailUpdater} Was Successfully Updated...", "HILAT ICT | USER UPDATING");
                    var userData = new Controlers.Users();
                    var data = userData.GetData(Dashboard.userLabel.Text);
                    FrontEnd.User_Controlers.UsersFrontEnd.dataGridView.DataSource = data;
                    this.Close();
                }
            }
            else
                msg.ShowError($"{email.Text} is Not a Correct Email Format, Provide Valid Email Example: SomeOne@gmail.com", "Error | Upadting");

        }

        private void fullname_TextChanged(object sender, EventArgs e)
        {
            isUpdatedName = true;
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            isUpdatedUser = true;
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            isUpdatedEmail = true;
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            isUpdatedType = true;
        }

        private void statusActive_CheckedChanged(object sender, EventArgs e)
        {
            isUpdatedStatus = true;
        }

        private void UserUpdater_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

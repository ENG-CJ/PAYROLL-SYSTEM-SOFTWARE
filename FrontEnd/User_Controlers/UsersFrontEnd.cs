using Guna.UI2.WinForms;
using HIMILO_ICT_PAYROLL_SYSTEM.FrontEnd.Forms;
using MessagesDLL;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace HIMILO_ICT_PAYROLL_SYSTEM.FrontEnd.User_Controlers
{
    public partial class UsersFrontEnd : UserControl
    {
        public string email;
        public string username;
        public string fullName;
        public string security;
        public string status;
        public string answer;
        public string type;
        public Image image;
        public static Guna2DataGridView dataGridView = new Guna2DataGridView();


        Messages msg = new Messages();
        public UsersFrontEnd()
        {
            InitializeComponent();
            dataGridView = usersData;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddNewUser(object sender, EventArgs e)
        {
            Form backdrop = BackDrop.backDrop();
            UserRegistration userRegistration = new UserRegistration();

            backdrop.Show();
            userRegistration.Owner = backdrop;
            userRegistration.ShowDialog();

            backdrop.Dispose();
        }

        private void UpdateUser(object sender, EventArgs e)
        {
            Form backdrop = BackDrop.backDrop(.72d);
            var userUpdater = new UserUpdater(username, fullName, email, type, image, status, security, answer);

            backdrop.Show();
            userUpdater.Owner = backdrop;
            userUpdater.ShowDialog();

            backdrop.Dispose();
            guna2Button2.Enabled = false;
            guna2Button3.Enabled = false;
        }

        private void UsersFrontEnd_Load(object sender, EventArgs e)
        {
            guna2Button2.Enabled = false;
            guna2Button3.Enabled = false;
            var generalQuery = new Controlers.Users();
            var data = generalQuery.GetData(Dashboard.userLabel.Text);

            if (data.Rows.Count > 0)
            {
                pictureNoDataFound.Visible = false;
                labelNoDataFound.Visible = false;
                usersData.DataSource = data;
                usersData.Visible = true;

            }
            else
            {
                pictureNoDataFound.Visible = true;
                labelNoDataFound.Visible = true;
                usersData.Visible = false;
            }

        }

        private void DeleteUsers(object sender, EventArgs e)
        {
            if (email == null)
                msg.ShowError("Select record you want To Delete", "Error");
            else
            {
                var result = msg.ShowWarning("Are You Sure To Remove This Record?", "Confirmation");
                if (result == DialogResult.No)
                    return;
                else
                {
                    GeneralQuery generalQuery = new GeneralQuery();
                    generalQuery.Delete("deleteUser", "@email", email);
                    if (generalQuery.QueryHasError)
                        msg.ShowError($"Something went Wrong\n\n{generalQuery.ErrorMessage}", "Error");
                    else
                    {
                        msg.ShowInfo($"{email} Was Successfully Deleted...", "Commits");
                        var users = new Controlers.Users();
                        var data = users.GetData(Dashboard.userLabel.Text);
                        usersData.DataSource = data;
                        guna2Button2.Enabled = false;
                        guna2Button3.Enabled = false;
                        email = null;
                        var gen = new GeneralQuery();
                        gen.CountData("countUsers", DashControelr.totalUsrs);
                    }
                }

            }

        }

        private void GetUserData(object sender, DataGridViewCellEventArgs e)
        {
            var user = new Controlers.Users();
            guna2Button2.Enabled = true;
            guna2Button3.Enabled = true;
            email = usersData.SelectedRows[0].Cells[3].Value.ToString();
            fullName = usersData.SelectedRows[0].Cells[1].Value.ToString();

            username = usersData.SelectedRows[0].Cells[2].Value.ToString();
            type = usersData.SelectedRows[0].Cells[4].Value.ToString();
            status = usersData.SelectedRows[0].Cells[7].Value.ToString();
            security = usersData.SelectedRows[0].Cells[5].Value.ToString();
            answer = usersData.SelectedRows[0].Cells[6].Value.ToString();
            image = user.getMyPhoto(email);

        }

        private void SearchUser(object sender, EventArgs e)
        {
            pictureNoDataFound.Visible = false;
            labelNoDataFound.Visible = false;

            usersData.Visible = true;
            GeneralQuery generalQuery = new GeneralQuery();
            var data = generalQuery.search("searchUser", "@fullName", "@user", searchName.Text, Dashboard.userLabel.Text);
            if (data.Rows.Count > 0)
            {
                pictureNoDataFound.Visible = false;
                labelNoDataFound.Visible = false;
                usersData.DataSource = data;
                usersData.Visible = true;

            }
            else
            {
                pictureNoDataFound.Visible = true;
                labelNoDataFound.Visible = true;
                usersData.Visible = false;
            }

        }

        private void reload(object sender, EventArgs e)
        {
            var generalQuery = new Controlers.Users();
            var data = generalQuery.GetData(Dashboard.userLabel.Text);
            usersData.DataSource = data;
        }
    }
}

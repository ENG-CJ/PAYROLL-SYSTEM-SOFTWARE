using MessagesDLL;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HIMILO_ICT_PAYROLL_SYSTEM
{
    public partial class Settings : Form
    {
        Messages msg = new Messages();

        public Image logoImage;
        public string comnName;
        public string comSubtitle;
        public string Comaddress;
        public Guna.UI2.WinForms.Guna2CheckBox checkBox = new Guna.UI2.WinForms.Guna2CheckBox();

        public Settings()
        {
            InitializeComponent();
            logoImage = logo.Image;
            comnName = companyName.Text;
            comSubtitle = subTitle.Text;
            Comaddress = address.Text;
            checkBox.Checked = dontShowMe.Checked;
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void Settings_Load(object sender, EventArgs e)
        {
            readData();
            if (Properties.Settings.Default.isChecked)
                dontShowMe.Checked = true;
            else
                dontShowMe.Checked = false;



            if (Properties.Settings.Default.IsvalidatedPayroll)
                guna2CheckBox1.Checked = true;
            else
                guna2CheckBox1.Checked = false;
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (dontShowMe.Checked)
            {
                Properties.Settings.Default.isChecked = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.isChecked = false;
                Properties.Settings.Default.Save();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void saveCompanyDetails()
        {
            try
            {
                var con = Connections.GetSqlConnection();
                con.Open();
                var cmd = new SqlCommand("insertOrUpdate", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", companyName.Text);
                if (subTitle.Text == "")
                    cmd.Parameters.AddWithValue("@sub", "Manage Payroll For All Emplyoyees");
                else
                    cmd.Parameters.AddWithValue("@sub", subTitle.Text);
                cmd.Parameters.AddWithValue("@address", address.Text);
                cmd.Parameters.AddWithValue("@photo", Controlers.ImageControler.SaveImageIntoStream(logo.Image).ToArray());

                cmd.ExecuteNonQuery();
                con.Close();
                var result = msg.AskQuestion("SYSTEM SETTING UPDATED SUCCESSFULLY\n\nSYSTEM CHANGES WILL TAKE EFFECT, " +
                    " AFTER SYSTEM RESTART\nDO YOU WANT TO RESTART?, PRESS YES...", $"{companyName.Text}  | {subTitle.Text} ");
                if (result == DialogResult.No)
                    this.Close();
                else
                    Application.Restart();



            }
            catch (Exception ex)
            {
                msg.ShowError(ex.Message, "Error Occurs");
            }




        }

        private void readData()
        {
            try
            {
                var con = Connections.GetSqlConnection();
                con.Open();
                var cmd = new SqlCommand("select *from company", con);
                var readrer = cmd.ExecuteReader();
                while (readrer.Read())
                {
                    if (readrer.HasRows)
                    {
                        companyName.Text = readrer[0].ToString();
                        subTitle.Text = readrer[1].ToString();
                        address.Text = readrer[2].ToString();
                        logo.Image = Controlers.ImageControler.GteImageFromStream(readrer[3]);
                    }

                }
                readrer.Close();
                con.Close();


            }
            catch (Exception ex)
            {
                msg.ShowError(ex.Message, "Error Occurs");
            }


        }

        private void SaveChanges(object sender, EventArgs e)
        {
            if (logo.Image == logoImage && companyName.Text == comnName && subTitle.Text == comSubtitle && address.Text == Comaddress && (dontShowMe.Checked ==
                checkBox.Checked))
                return;
            if (Validations.validateAllBlanks(companyName, address))
                msg.ShowError("Company Details Cannot be Null Values...", "Error | Company Details Updating.....");
            else
            {
                var result = msg.AskQuestion("You Gonna Chage The System Setting.\nAre You Sure To Change?", $"Confirmation");
                if (result == DialogResult.No)
                    return;
                else
                    saveCompanyDetails();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            try
            {
                if (openImage.ShowDialog() == DialogResult.OK)
                    logo.Image = Image.FromFile(openImage.FileName);
            }
            catch (Exception ex)
            {
                msg.ShowError(ex.Message, "Error Occurs");
            }
        }

        private void VlidateChceker(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                Properties.Settings.Default.IsvalidatedPayroll = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.IsvalidatedPayroll = false;
                Properties.Settings.Default.Save();
            }
        }
    }
}

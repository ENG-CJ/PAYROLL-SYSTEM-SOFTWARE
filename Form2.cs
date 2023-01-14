using MessagesDLL;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace HIMILO_ICT_PAYROLL_SYSTEM
{
    public partial class Form2 : Form
    {
        Messages msg = new Messages();
        public Form2()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            guna.Increment(2);
            label3.Text = guna.Value.ToString() + "%";
            if (guna.Value == 100)
            {
                timer1.Enabled = false;
                new LOGIN().Show();
                this.Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
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

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            readData();
            guna2CheckBox1.Checked = Properties.Settings.Default.isChecked;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
                        TITLE.Text = readrer[0].ToString();

                        loginLogo.Image = Controlers.ImageControler.GteImageFromStream(readrer[3]);
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
    }
}

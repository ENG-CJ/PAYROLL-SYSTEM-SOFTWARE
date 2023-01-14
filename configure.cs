using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using MessagesDLL;
namespace HIMILO_ICT_PAYROLL_SYSTEM
{
    public partial class configure : Form
    {
        Messages msg = new Messages();
        public configure()
        {
            InitializeComponent();
        }

        private void configure_Load(object sender, EventArgs e)
        {
            readData();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            config con = new config();
            con.Show();
            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
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
                        hTitle.Text = readrer[0].ToString();
                       
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

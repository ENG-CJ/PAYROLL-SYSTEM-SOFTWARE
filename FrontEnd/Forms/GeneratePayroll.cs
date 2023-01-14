using MessagesDLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIMILO_ICT_PAYROLL_SYSTEM.FrontEnd.Forms
{
    public partial class GeneratePayroll : Form
    {
        Messages msg = new Messages();
        public string empID;
        public int baseSalary;
        public int bonusAmount;
        public int Deductions;
        public int netPay;


        public int HasRows;
        public string error;

        public bool hasError;
        public string errorMessage;

        public GeneratePayroll()
        {
            InitializeComponent();
        }

        private void Cancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void Generate(object sender, EventArgs e)
        {

            if (Validations.ComboNotSelectedValue("Select", monthName, year))
                msg.ShowError("Select Month And Year For Payroll Generating.....", "Error | Genearting....");
            else if (this.monthName.Text == "")
                msg.ShowError("Select Valid Month...", "Error | Month ");
            else
            {
                var isGnered = isGenearted();
                if (hasError)
                    msg.ShowError("Error Occured...\n" + errorMessage, "Error While Validating Payroll");
                else
                {


                    // if valodator has validation
                    if (Properties.Settings.Default.IsvalidatedPayroll)
                    {
                        if (monthName.Text.ToUpper() != DateTime.Now.ToString("MMMM").ToUpper() || year.Text.ToUpper() != DateTime.Now.Year.ToString())
                        {
                            msg.ShowError("ONLY YOU CAN GENERATE CURRENT MONTH AND YEAR, YOU CAN'T GENERATE OLD MONTH AND YEAR", "Error While Genearting...");
                            return;
                        }
                        if (isGnered)
                            msg.ShowError("This Period Has Been Already Generated, Delete It From The Payroll And Re-Genearte", "Error While Genearting...");
                        else
                        {
                            readData();
                            if (hasError)
                                msg.ShowError("Something Went Wrong...\nError Message: \n" + errorMessage, "Error");
                            else
                            {
                                guna2Button1.Enabled = false;

                                guna2Button2.Enabled = false;
                                await Progress();
                                msg.ShowInfo("Payroll For The Period Of " + monthName.Text + " - " + year.Text + "\nHas Been Successfully Genearted..", "PAYROLL GENEARTED PERIOD " + monthName.Text + " - " + year.Text);

                                guna2Button1.Enabled = true;
                                guna2Button2.Enabled = true;
                                var query = new GeneralQuery();

                                FrontEnd.User_Controlers.Payroll.data.DataSource = query.GetData("readPayrollData");
                                var gen = new GeneralQuery();
                                gen.CountData("totalPayroll", DashControelr.allpayslips);
                                gen.CountSalaryPaid(DashControelr.salariesPaid);
                                gen.countBonusPaid(DashControelr.bonusesPAID);
                                this.Close();


                            }
                        }
                    }
                    else
                    {
                        if (isGnered)
                            msg.ShowError("This Period Has Been Already Generated, Delete It From The Payroll And Re-Genearte", "Error While Genearting...");
                        else
                        {
                            readData();
                            if (hasError)
                                msg.ShowError("Something Went Wrong...\nError Message: \n" + errorMessage, "Error");
                            else
                            {
                                guna2Button1.Enabled = false;

                                guna2Button2.Enabled = false;
                                await Progress();
                                msg.ShowInfo("Payroll For The Period Of " + monthName.Text + " - " + year.Text + "\nHas Been Successfully Genearted..", "PAYROLL GENEARTED PERIOD " + monthName.Text + " - " + year.Text);

                                guna2Button1.Enabled = true;
                                guna2Button2.Enabled = true;
                                var query = new GeneralQuery();

                                FrontEnd.User_Controlers.Payroll.data.DataSource = query.GetData("readPayrollData");
                                var gen = new GeneralQuery();
                                gen.CountData("totalPayroll", DashControelr.allpayslips);
                                gen.CountSalaryPaid(DashControelr.salariesPaid);
                                gen.countBonusPaid(DashControelr.bonusesPAID);
                                this.Close();


                            }
                        }
                    }

                    // if has false
                }

            }


        }




        private async Task Progress()
        {
            progressIndicator.Visible = true;

            await Task.Run(async () =>
            {
                for (int i = 1; i <= 100; i++)
                {
                    progressIndicator.Value = i;
                    await Task.Delay(30);
                }
                progressIndicator.Visible = false;
                progressIndicator.Value = 0;

            });
        }

        private void GeneratePayroll_Load(object sender, EventArgs e)
        {
            populateMonthNames();
            populaterYears();
        }





        private void populateMonthNames()
        {
            string[] allMonths = DateTimeFormatInfo.CurrentInfo.MonthNames;
            this.monthName.Items.Clear();
            foreach (string month in allMonths)
            {
                this.monthName.Items.Add(month);
            }
            this.monthName.Items.Add("Select");
            this.monthName.SelectedItem = "Select";

        }


        private void populaterYears()
        {
            List<int> years = Enumerable.Range(2000, DateTime.Now.Year - 2000 + 1).ToList();

            foreach (int year in years)
            {
                this.year.Items.Add(year.ToString());
            }

        }




        public void GeneartePayrolls(string _empID, int _salary, int amount, int ded, int netpay)
        {

            try
            {
                SqlConnection conn = Connections.GetSqlConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("GeneratePayroll", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@empID", _empID);
                cmd.Parameters.AddWithValue("@basicSalary", _salary);
                cmd.Parameters.AddWithValue("@bonusAmount", amount);
                cmd.Parameters.AddWithValue("@deductions", ded);
                cmd.Parameters.AddWithValue("@netPay", netpay);
                cmd.Parameters.AddWithValue("@month", monthName.Text);
                cmd.Parameters.AddWithValue("@year", year.Text);
                var adapter = cmd.ExecuteReader();
                while (adapter.Read())
                {
                    if (adapter.HasRows)
                        HasRows = 1;
                    else
                        HasRows = 0;
                }




                conn.Close();


            }
            catch (Exception ex)
            {
                error = ex.Message;

            }

        }


        public void readData()
        {

            try
            {
                SqlConnection conn = Connections.GetSqlConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("readPayrollJoinData", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                var adapter = cmd.ExecuteReader();
                while (adapter.Read())
                {
                    if (adapter.HasRows)
                    {
                        GeneartePayrolls(adapter[0].ToString(),
                           Convert.ToInt32(adapter[1]),
                           Convert.ToInt32(adapter[2]),
                           Convert.ToInt32(adapter[3]),
                           Convert.ToInt32(adapter[4]));
                        if (HasRows == 1)
                        {
                            msg.ShowError("Error Occurs\n" + error, "Error");
                            return;
                        }
                    }

                }

                adapter.Close();
                conn.Close();
                hasError = false;

            }
            catch (Exception ex)
            {
                hasError = true;
                errorMessage = ex.Message;
            }

        }


        public bool isGenearted()
        {

            try
            {
                SqlConnection conn = Connections.GetSqlConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("isGenerated", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@month", monthName.Text);
                cmd.Parameters.AddWithValue("@year", year.Text);
                var adapter = cmd.ExecuteReader();
                while (adapter.Read())
                {
                    if (adapter.HasRows)
                        return true;

                }

                adapter.Close();
                conn.Close();
                hasError = false;


            }
            catch (Exception ex)
            {
                hasError = true;
                errorMessage = ex.Message;

            }
            return false;
        }
    }
}

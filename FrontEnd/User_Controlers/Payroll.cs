using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace HIMILO_ICT_PAYROLL_SYSTEM.FrontEnd.User_Controlers
{
    public partial class Payroll : UserControl
    {

        public static Guna2DataGridView data = new Guna2DataGridView();
        public static Guna2ComboBox comboBox = new Guna2ComboBox();
        public Payroll()
        {
            InitializeComponent();
            data = payrollData;
            comboBox = departname;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Generate(object sender, EventArgs e)
        {
            var back = BackDrop.backDrop(.58d);
            var geneartion = new FrontEnd.Forms.GeneratePayroll();

            back.Show();
            geneartion.Owner = back;
            geneartion.ShowDialog();

            back.Dispose();
        }

        private void Payroll_Load(object sender, EventArgs e)
        {
            var query = new GeneralQuery();
            payrollData.DataSource = query.GetData("readPayrollData");
            query.BindComboValue("bindDeparts", departname);
            departname.Items.Add("Departments (All)");
            departname.SelectedItem = "Departments (All)";

            populateMonthNames();
            populaterYears();

            Count();
        }


        private void populateMonthNames()
        {
            string[] allMonths = DateTimeFormatInfo.CurrentInfo.MonthNames;
            this.month.Items.Clear();
            foreach (string month in allMonths)
            {
                this.month.Items.Add(month);
            }
            this.month.Items.Add("Select");
            this.month.SelectedItem = "Select";

        }

        private void populaterYears()
        {
            List<int> years = Enumerable.Range(2000, DateTime.Now.Year - 2000 + 1).ToList();
            this.year.Items.Clear();
            foreach (int year in years)
            {
                this.year.Items.Add(year.ToString());
            }
            this.year.Items.Add("Select");
            this.year.SelectedItem = "Select";
        }

        private void Monthfilter(object sender, EventArgs e)
        {
            pictureNoDataFound.Visible = false;
            if (this.month.Text == "Select" && year.Text == "Select")
            {
                var query = new GeneralQuery();
                payrollData.DataSource = query.GetData("readPayrollData");
                Count();
            }
            else if (month.Text == "Select" && year.Text != "Select")
            {
                var query = new GeneralQuery();
                payrollData.DataSource = query.GetData("readPayrollData");
                Count();
            }
            else if (month.Text != "Select" && year.Text == "Select")
            {
                var query = new GeneralQuery();
                payrollData.DataSource = query.GetData("readPayrollData");
                Count();
            }
            else
            {

                var payrol = new Controlers.Payroll();
                var data = payrol.filterByPeriod(this.month.Text, this.year.Text);
                payrollData.Visible = true;
                pictureNoDataFound.Visible = false;
                if (data.Rows.Count > 0)
                {
                    payrollData.Visible = true;
                    payrollData.DataSource = data;
                    pictureNoDataFound.Visible = false;
                    Count();

                }
                else
                {
                    payrollData.Visible = false;

                    pictureNoDataFound.Visible = true;
                }



            }

        }

        private void FilterYear(object sender, EventArgs e)
        {
            pictureNoDataFound.Visible = false;
            if (this.month.Text == "Select" && year.Text == "Select")
            {
                payrollData.Visible = true;

                var query = new GeneralQuery();
                payrollData.DataSource = query.GetData("readPayrollData");
                Count();
            }
            else if (month.Text == "Select" && year.Text != "Select")
            {
                var query = new GeneralQuery();
                payrollData.DataSource = query.GetData("readPayrollData");
                Count();
            }
            else if (month.Text != "Select" && year.Text == "Select")
            {
                var query = new GeneralQuery();
                payrollData.DataSource = query.GetData("readPayrollData");
                Count();
            }
            else
            {
                var payrol = new Controlers.Payroll();
                var data = payrol.filterByPeriod(this.month.Text, this.year.Text);
                payrollData.Visible = true;
                pictureNoDataFound.Visible = false;
                if (data.Rows.Count > 0)
                {
                    payrollData.Visible = true;
                    payrollData.DataSource = data;
                    pictureNoDataFound.Visible = false;
                    Count();
                }
                else
                {
                    payrollData.Visible = false;
                    pictureNoDataFound.Visible = true;
                }

            }
        }

        private void FilterDeparts(object sender, EventArgs e)
        {
            pictureNoDataFound.Visible = false;
            payrollData.Visible = true;
            if (this.departname.Text == "Departments (All)")
            {
                var query = new GeneralQuery();
                payrollData.DataSource = query.GetData("readPayrollData");
                Count();
            }

            else
            {
                var payrol = new Controlers.Payroll();
                var data = payrol.filterbyDepart(this.departname.Text);
                pictureNoDataFound.Visible = false;
                payrollData.Visible = true;
                if (data.Rows.Count > 0)
                {
                    payrollData.Visible = true;
                    payrollData.DataSource = data;
                    pictureNoDataFound.Visible = false;
                    Count();

                }
                else
                {
                    payrollData.Visible = false;
                    pictureNoDataFound.Visible = true;
                }
            }
        }


        private void Count()
        {
            int sumSlary = 0;
            int sumBonus = 0;
            int sumDeduction = 0;
            Int64 sumNet = 0;
            for (int i = 0; i < payrollData.Rows.Count; i++)
            {
                sumSlary += Convert.ToInt32(payrollData.Rows[i].Cells[4].Value);
                sumBonus += Convert.ToInt32(payrollData.Rows[i].Cells[5].Value);
                sumDeduction += Convert.ToInt32(payrollData.Rows[i].Cells[6].Value);
                sumNet += Convert.ToInt64(payrollData.Rows[i].Cells[7].Value);
            }

            TOTALSALARY.Text = "$" + sumSlary.ToString("#,##0");
            TOTALNETPAY.Text = "$" + sumNet.ToString("#,##0");
            TOTALBONUS.Text = "$" + sumBonus.ToString("#,##0");
            totalDeductios.Text = "$" + sumDeduction.ToString("#,##0");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ShowTops(object sender, EventArgs e)
        {
            if (topNumber.Text == "All")
            {
                var query = new GeneralQuery(); ;
                payrollData.DataSource = query.GetData("readPayrollData");
                Count();
                return;
            }
            var payrol = new Controlers.Payroll();
            payrollData.DataSource = payrol.showTops(int.Parse(topNumber.Text));
            Count();
        }

        private void pictureNoDataFound_Click(object sender, EventArgs e)
        {

        }
    }
}

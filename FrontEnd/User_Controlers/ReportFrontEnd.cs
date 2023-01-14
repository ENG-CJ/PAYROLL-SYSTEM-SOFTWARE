using Guna.UI2.WinForms;
using MessagesDLL;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace HIMILO_ICT_PAYROLL_SYSTEM.FrontEnd.User_Controlers
{
    public partial class ReportFrontEnd : UserControl
    {

        public bool error;
        public string erroMessage;
        public static Guna2ComboBox combo = new Guna2ComboBox();

        Messages msg = new Messages();
        public ReportFrontEnd()
        {

            InitializeComponent();
            combo = departmentName;
        }

        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (reporttype.Text == "All")
                username.Enabled = false;
            else
                username.Enabled = true;
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
        private void remove()
        {
            guna2TabControl1.TabPages.Remove(tabPage1);
            guna2TabControl1.TabPages.Remove(tabPage2);

            guna2TabControl1.TabPages.Remove(tabPage4);
            guna2TabControl1.TabPages.Remove(tabPage5);


        }
        private void GenReport(object sender, EventArgs e)
        {
            if (reporttype.Text == "All")
            {
                var query = new GeneralQuery();
                var data = query.GetData("getUsersR");
                if (data.Rows.Count > 0)
                {
                    this.noReport.Visible = false;
                    er2.Visible = false;
                    err1.Visible = false;
                    userReport.Visible = true;
                    this.userReport.LocalReport.DataSources.Clear();
                    ReportDataSource soirce = new ReportDataSource("DataSet1", data);
                    this.userReport.LocalReport.ReportPath = "AllUserList.rdlc";
                    this.userReport.LocalReport.DataSources.Add(soirce);
                    this.userReport.RefreshReport();
                }
                else
                {
                    this.noReport.Visible = true;
                    er2.Visible = true;
                    err1.Visible = true;
                    userReport.Visible = false;
                }


            }
            else
            {
                var query = new GeneralQuery();
                var data = query.search("findUserReport", "@username", this.username.Text);
                if (data.Rows.Count > 0)
                {
                    this.noReport.Visible = false;
                    er2.Visible = false;
                    err1.Visible = false;
                    userReport.Visible = true;
                    this.userReport.LocalReport.DataSources.Clear();
                    ReportDataSource soirce = new ReportDataSource("DataSet1", data);
                    this.userReport.LocalReport.ReportPath = "AllUserList.rdlc";
                    this.userReport.LocalReport.DataSources.Add(soirce);
                    this.userReport.RefreshReport();
                }
                else
                {
                    userReport.Visible = false;
                    this.noReport.Visible = true;
                    er2.Visible = true;
                    err1.Visible = true;

                }
            }
        }

        private void ReportFrontEnd_Load(object sender, EventArgs e)
        {
            if (LOGIN.userRole.ToLower() == "user")
                remove();
            allEmployee.Checked = true;
            this.noReport.Visible = true;
            er2.Visible = true;
            err1.Visible = true;
            var query = new GeneralQuery();
            query.BindComboValue("bindDeparts", departmentName);
            query.BindComboValue("readEmpID", employeeID);
            query.BindComboValue("readEmpID", employeesid);
            query.BindComboValue("readEmpID", employeePayrollID);
            employeePayrollID.Items.Add("Select");
            employeePayrollID.SelectedItem = "Select";
            departmentName.SelectedIndex = 0;
            employeeID.SelectedIndex = 0;
            employeesid.SelectedIndex = 0;
            populateMonthNames();
            populaterYears();

            combo = departmentName;
            //this.userReport.RefreshReport();
            //this.departReportViewer.RefreshReport();
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userReport_Load(object sender, EventArgs e)
        {

        }

        private void GenerateDepartReport(object sender, EventArgs e)
        {
            if (departmentReportType.Text == "All With Details")
            {
                departmentName.Enabled = false;
                var query = new GeneralQuery();
                var data = query.GetData("moreInfo");
                if (data.Rows.Count == 0)
                {
                    this.noReport.Visible = true;
                    er2.Visible = true;
                    err1.Visible = true;
                    return;
                }
                this.departReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource soirce = new ReportDataSource("DataSet1", data);
                this.departReportViewer.LocalReport.ReportPath = "AllDeparts.rdlc";
                this.departReportViewer.LocalReport.DataSources.Add(soirce);
                this.departReportViewer.RefreshReport();
            }
            else
            {
                departmentName.Enabled = true;

                var query = new GeneralQuery();
                var data = query.search("getDepartName", "@departname", departmentName.Text);
                if (data.Rows.Count == 0)
                {
                    this.noReport.Visible = true;
                    er2.Visible = true;
                    err1.Visible = true;
                    return;
                }

                this.departReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource soirce = new ReportDataSource("DataSet1", data);
                this.departReportViewer.LocalReport.ReportPath = "DepartMentNames.rdlc";
                this.departReportViewer.LocalReport.DataSources.Add(soirce);
                this.departReportViewer.RefreshReport();
            }
        }

        private void departmentReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (departmentReportType.Text == "All With Details")
            {
                departmentName.Enabled = false;
                var query = new GeneralQuery();
                var data = query.GetData("moreInfo");
                if (data.Rows.Count == 0)
                {
                    this.noreportDepartTitle.Visible = true;
                    noreportDepartSub.Visible = true;
                    noreportDepart.Visible = true;
                    departReportViewer.Visible = false;
                    return;
                }
                this.noreportDepartTitle.Visible = false;
                noreportDepartSub.Visible = false;
                noreportDepart.Visible = false;
                departReportViewer.Visible = true;
                this.departReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource soirce = new ReportDataSource("DataSet1", data);
                this.departReportViewer.LocalReport.ReportPath = "AllDeparts.rdlc";
                this.departReportViewer.LocalReport.DataSources.Add(soirce);
                this.departReportViewer.RefreshReport();
            }
            else
            {
                departmentName.Enabled = true;

                var query = new GeneralQuery();
                var data = query.search("getDepartName", "@departname", departmentName.Text);
                if (data.Rows.Count == 0)
                {
                    this.noreportDepartTitle.Visible = true;
                    noreportDepartSub.Visible = true;
                    noreportDepart.Visible = true;
                    departReportViewer.Visible = false;
                    return;
                }
                this.noreportDepartTitle.Visible = false;
                noreportDepartSub.Visible = false;
                noreportDepart.Visible = false;
                departReportViewer.Visible = true;
                this.departReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource soirce = new ReportDataSource("DataSet1", data);
                this.departReportViewer.LocalReport.ReportPath = "DepartMentNames.rdlc";
                this.departReportViewer.LocalReport.DataSources.Add(soirce);
                this.departReportViewer.RefreshReport();
            }
        }

        private void AllEmplyee(object sender, EventArgs e)
        {
            if (allEmployee.Checked)
            {
                OneControl.DisAble(fromdate, todate, period);
                employeeID.Enabled = false;
            }
        }

        private void byEmployee(object sender, EventArgs e)
        {
            employeeID.Enabled = true;
            period.Enabled = false;
            OneControl.Enable(fromdate, todate);
        }

        private void byDate(object sender, EventArgs e)
        {
            employeeID.Enabled = false;
            OneControl.Enable(period);
            OneControl.DisAble(fromdate, todate);
        }

        private void GenerateEmployeeAttendanceREport(object sender, EventArgs e)
        {
            if (allEmployee.Checked)
                DisplayAllEmplyeeAttendance();
            else if (byEmplyee.Checked)
                DisplayByEmployeee();
            else if (empByDate.Checked)
                DisplayByDate();
        }

        private void attendanceReportViwer_Load(object sender, EventArgs e)
        {

        }



        private void DisplayAllEmplyeeAttendance()
        {

            var query = new GeneralQuery();
            var data = query.GetData("reportAll");
            if (data.Rows.Count == 0)
            {
                this.noReportAttendance.Visible = true;
                attendancePictureNotFound.Visible = true;
                noreportAttenSub.Visible = true;
                attendanceReportViwer.Visible = false;
                return;
            }
            this.noReportAttendance.Visible = false;
            attendancePictureNotFound.Visible = false;
            noreportAttenSub.Visible = false;
            attendanceReportViwer.Visible = true;
            this.attendanceReportViwer.LocalReport.DataSources.Clear();
            ReportDataSource soirce = new ReportDataSource("DataSet1", data);
            this.attendanceReportViwer.LocalReport.ReportPath = "AllEmployeeAttendance.rdlc";
            this.attendanceReportViwer.LocalReport.DataSources.Add(soirce);
            this.attendanceReportViwer.RefreshReport();
        }



        private void DisplayByEmployeee()
        {

            var query = new GeneralQuery();
            var data = search();
            if (error)
            {
                msg.ShowError("Error Occured While Retriving report \nMessages:\n" + erroMessage, "Error");
                return;
            }
            if (data.Rows.Count == 0)
            {
                this.noReportAttendance.Visible = true;
                attendancePictureNotFound.Visible = true;
                noreportAttenSub.Visible = true;
                attendanceReportViwer.Visible = false;
                return;
            }
            this.noReportAttendance.Visible = false;
            attendancePictureNotFound.Visible = false;
            noreportAttenSub.Visible = false;
            attendanceReportViwer.Visible = true;
            this.attendanceReportViwer.LocalReport.DataSources.Clear();
            ReportDataSource soirce = new ReportDataSource("DataSet1", data);
            this.attendanceReportViwer.LocalReport.ReportPath = "ByEmployee.rdlc";
            this.attendanceReportViwer.LocalReport.DataSources.Add(soirce);
            this.attendanceReportViwer.RefreshReport();
        }



        private DataTable search()
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection connection = Connections.GetSqlConnection();
                connection.Open();
                SqlCommand command = new SqlCommand("reportByEmployee", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@empID", employeeID.Text);
                command.Parameters.AddWithValue("@fromDate", fromdate.Value);
                command.Parameters.AddWithValue("@toDate", todate.Value);
                SqlDataAdapter sqlData = new SqlDataAdapter(command);
                sqlData.Fill(dataTable);
                command.ExecuteNonQuery();

                connection.Close();
                error = false;

            }
            catch (Exception ex)
            {
                error = true;
                erroMessage = ex.Message;
            }

            return dataTable;
        }


        private DataTable searchDate()
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection connection = Connections.GetSqlConnection();
                connection.Open();
                SqlCommand command = new SqlCommand("sortbyDate", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@date", period.Value);

                SqlDataAdapter sqlData = new SqlDataAdapter(command);
                sqlData.Fill(dataTable);
                command.ExecuteNonQuery();

                connection.Close();
                error = false;

            }
            catch (Exception ex)
            {
                error = true;
                erroMessage = ex.Message;
            }

            return dataTable;
        }


        private DataTable searchEmployee()
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection connection = Connections.GetSqlConnection();
                connection.Open();
                SqlCommand command = new SqlCommand("selectEmployee", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", employeesid.Text);

                SqlDataAdapter sqlData = new SqlDataAdapter(command);
                sqlData.Fill(dataTable);
                command.ExecuteNonQuery();

                connection.Close();
                error = false;

            }
            catch (Exception ex)
            {
                error = true;
                erroMessage = ex.Message;
            }

            return dataTable;
        }

        private void DisplayByDate()
        {

            var query = new GeneralQuery();
            var data = searchDate();
            if (error)
            {
                msg.ShowError("Error Occured While Retriving report \nMessages:\n" + erroMessage, "Error");
                return;
            }
            if (data.Rows.Count == 0)
            {
                this.noReportAttendance.Visible = true;
                attendancePictureNotFound.Visible = true;
                noreportAttenSub.Visible = true;
                attendanceReportViwer.Visible = false;
                return;
            }
            this.noReportAttendance.Visible = false;
            attendancePictureNotFound.Visible = false;
            noreportAttenSub.Visible = false;
            attendanceReportViwer.Visible = true;
            this.attendanceReportViwer.LocalReport.DataSources.Clear();
            ReportDataSource soirce = new ReportDataSource("DataSet1", data);
            this.attendanceReportViwer.LocalReport.ReportPath = "ByDate.rdlc";
            this.attendanceReportViwer.LocalReport.DataSources.Add(soirce);
            this.attendanceReportViwer.RefreshReport();
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void EmpReportType(object sender, EventArgs e)
        {
            if (employeeReportType.Text == "All")
            {
                employeesid.Enabled = false;
                var query = new GeneralQuery();
                var data = query.GetData("reportAllEmployee");
                if (data.Rows.Count == 0)
                {
                    this.noReportEmployeTitle.Visible = true;
                    noReportEmployeePicture.Visible = true;
                    noEmplpoyeeReportSubtit.Visible = true;
                    employeeReportViewer.Visible = false;
                    return;
                }
                this.noReportEmployeTitle.Visible = false;
                noReportEmployeePicture.Visible = false;
                noEmplpoyeeReportSubtit.Visible = false;
                employeeReportViewer.Visible = true;
                this.employeeReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource soirce = new ReportDataSource("DataSet1", data);
                this.employeeReportViewer.LocalReport.ReportPath = "EmployeeInformation.rdlc";
                this.employeeReportViewer.LocalReport.DataSources.Add(soirce);
                this.employeeReportViewer.RefreshReport();
            }
            else
            {
                employeesid.Enabled = true;

                var query = new GeneralQuery();
                var data = searchEmployee();
                if (data.Rows.Count == 0)
                {
                    this.noReportEmployeTitle.Visible = true;
                    noReportEmployeePicture.Visible = true;
                    noEmplpoyeeReportSubtit.Visible = true;
                    employeeReportViewer.Visible = false;
                    return;
                }
                this.noReportEmployeTitle.Visible = false;
                noReportEmployeePicture.Visible = false;
                noEmplpoyeeReportSubtit.Visible = false;
                employeeReportViewer.Visible = true;
                this.employeeReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource soirce = new ReportDataSource("DataSet1", data);
                this.employeeReportViewer.LocalReport.ReportPath = "OneEmployeeInformation.rdlc";
                this.employeeReportViewer.LocalReport.DataSources.Add(soirce);
                this.employeeReportViewer.RefreshReport();
            }
        }

        private void GenerateEmployeeReport(object sender, EventArgs e)
        {
            if (employeeReportType.Text == "All")
            {
                var query = new GeneralQuery();
                var data = query.GetData("reportAllEmployee");
                if (data.Rows.Count == 0)
                {
                    this.noReportEmployeTitle.Visible = true;
                    noReportEmployeePicture.Visible = true;
                    noEmplpoyeeReportSubtit.Visible = true;
                    employeeReportViewer.Visible = false;
                    return;
                }
                this.noReportEmployeTitle.Visible = false;
                noReportEmployeePicture.Visible = false;
                noEmplpoyeeReportSubtit.Visible = false;
                employeeReportViewer.Visible = true;
                this.employeeReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource soirce = new ReportDataSource("DataSet1", data);
                this.employeeReportViewer.LocalReport.ReportPath = "EmployeeInformation.rdlc";
                this.employeeReportViewer.LocalReport.DataSources.Add(soirce);
                this.employeeReportViewer.RefreshReport();
            }
            else
            {
                var data = searchEmployee();
                if (data.Rows.Count == 0)
                {
                    this.noReportEmployeTitle.Visible = true;
                    noReportEmployeePicture.Visible = true;
                    noEmplpoyeeReportSubtit.Visible = true;
                    employeeReportViewer.Visible = false;
                    return;
                }
                this.noReportEmployeTitle.Visible = false;
                noReportEmployeePicture.Visible = false;
                noEmplpoyeeReportSubtit.Visible = false;
                employeeReportViewer.Visible = true;
                this.employeeReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource soirce = new ReportDataSource("DataSet1", data);
                this.employeeReportViewer.LocalReport.ReportPath = "OneEmployeeInformation.rdlc";
                this.employeeReportViewer.LocalReport.DataSources.Add(soirce);
                this.employeeReportViewer.RefreshReport();
            }
        }

        private void employeeReportViewer_Load(object sender, EventArgs e)
        {

        }

        private void ReportByEmployePayroll(object sender, EventArgs e)
        {
            employeePayrollID.Enabled = true;
            payrollMonth.Enabled = false;
            payrollYear.Enabled = false;
        }

        private void allEmplyeePayrol_CheckedChanged(object sender, EventArgs e)
        {
            employeePayrollID.Enabled = false;
            payrollMonth.Enabled = false;
            payrollYear.Enabled = false;
        }

        private void SelectedMonthYear(object sender, EventArgs e)
        {
            employeePayrollID.Enabled = false;
            payrollMonth.Enabled = true;
            payrollYear.Enabled = true;
        }

        private void byEmployeeSELECETDMONTH_CheckedChanged(object sender, EventArgs e)
        {
            employeePayrollID.Enabled = true;
            payrollMonth.Enabled = true;
            payrollYear.Enabled = true;
        }

        private void GeneratePayrollemployeeReport(object sender, EventArgs e)
        {
            if (allEmplyeePayrol.Checked)
                DisplayAllEmployeePayroll();
            else if (payrollSelectedMonth.Checked)
            {
                if (payrollMonth.Text == "Select" || payrollYear.Text == "Select")
                    msg.ShowError("Select Month And Year To Make Statement About Specific Year and Month", "Error | reporting Statement payroll");
                else
                    DisplayAllEmployeePayrollBYMonthAndYear();
            }

            else if (byEmployeePayrol.Checked)
            {
                if (employeePayrollID.Text == "Select")
                    msg.ShowError("Select Employee ID To Make Statement About Specific Employee", "Error | reporting Statement payroll");
                else
                    DisplayAllEmployeePayrollByID();
            }


            else if (byEmployeeSELECETDMONTH.Checked)
            {
                if (employeePayrollID.Text == "Select" || payrollMonth.Text == "Select" || payrollYear.Text == "")
                    msg.ShowError("Select Employee ID, Period Month And Year To Make Statement About Specific Employee", "Error | reporting Statement payroll");
                else
                    DisplaySpecificEmployee();
            }

            else if (byyear.Checked)
            {
                if (payrollYear.Text == "Select")
                    msg.ShowError("Select  Year To Make Statement About  All Employees", "Error | reporting Statement payroll");
                else
                    DisplayAllEmployeePayrollBYYear();
            }
        }


        // search employee payroll month and year
        private DataTable searchByMonthAndYear()
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection connection = Connections.GetSqlConnection();
                connection.Open();
                SqlCommand command = new SqlCommand("reportPayrollSelectedMonth", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@month", payrollMonth.Text);
                command.Parameters.AddWithValue("@year", payrollYear.Text);
                SqlDataAdapter sqlData = new SqlDataAdapter(command);
                sqlData.Fill(dataTable);
                command.ExecuteNonQuery();

                connection.Close();
                error = false;

            }
            catch (Exception ex)
            {
                error = true;
                erroMessage = ex.Message;
            }

            return dataTable;
        }



        private DataTable searchByIDYaerMonth()
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection connection = Connections.GetSqlConnection();
                connection.Open();
                SqlCommand command = new SqlCommand("reportEmployeePayrolSelectedIDMonthAndYEAR", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", employeePayrollID.Text);
                command.Parameters.AddWithValue("@month", payrollMonth.Text);
                command.Parameters.AddWithValue("@year", payrollYear.Text);
                SqlDataAdapter sqlData = new SqlDataAdapter(command);
                sqlData.Fill(dataTable);
                command.ExecuteNonQuery();

                connection.Close();
                error = false;

            }
            catch (Exception ex)
            {
                error = true;
                erroMessage = ex.Message;
            }

            return dataTable;
        }
        // search employee by id
        private DataTable searchByID()
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection connection = Connections.GetSqlConnection();
                connection.Open();
                SqlCommand command = new SqlCommand("reportSelectedEmployeeID", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", employeePayrollID.Text);

                SqlDataAdapter sqlData = new SqlDataAdapter(command);
                sqlData.Fill(dataTable);
                command.ExecuteNonQuery();

                connection.Close();
                error = false;

            }
            catch (Exception ex)
            {
                error = true;
                erroMessage = ex.Message;
            }

            return dataTable;
        }

        // by year


        private DataTable searchByYear()
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection connection = Connections.GetSqlConnection();
                connection.Open();
                SqlCommand command = new SqlCommand("reportEmployeePayrolSelectedYear", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@year", payrollYear.Text);

                SqlDataAdapter sqlData = new SqlDataAdapter(command);
                sqlData.Fill(dataTable);
                command.ExecuteNonQuery();

                connection.Close();
                error = false;

            }
            catch (Exception ex)
            {
                error = true;
                erroMessage = ex.Message;
            }

            return dataTable;
        }
        /// display all employee payroll
        /// 
        private void DisplayAllEmployeePayroll()
        {
            var query = new GeneralQuery();
            var data = query.GetData("reportPayrollAllEmployee");
            if (data.Rows.Count == 0)
            {
                this.payTitle.Visible = true;
                payrollPictureRe.Visible = true;
                paySub.Visible = true;
                payrollReportViewer.Visible = false;
                return;
            }
            this.payTitle.Visible = false;
            payrollPictureRe.Visible = false;
            paySub.Visible = false;
            payrollReportViewer.Visible = true;
            this.payrollReportViewer.LocalReport.DataSources.Clear();
            ReportDataSource soirce = new ReportDataSource("DataSet1", data);
            this.payrollReportViewer.LocalReport.ReportPath = "PayrollReport.rdlc";
            this.payrollReportViewer.LocalReport.DataSources.Add(soirce);
            this.payrollReportViewer.RefreshReport();
            //

        }


        // by month and year
        private void DisplayAllEmployeePayrollBYMonthAndYear()
        {
            var query = new GeneralQuery();
            var data = searchByMonthAndYear();
            if (data.Rows.Count == 0)
            {
                this.payTitle.Visible = true;
                payrollPictureRe.Visible = true;
                paySub.Visible = true;
                payrollReportViewer.Visible = false;
                return;
            }
            this.payTitle.Visible = false;
            payrollPictureRe.Visible = false;
            paySub.Visible = false;
            payrollReportViewer.Visible = true;
            this.payrollReportViewer.LocalReport.DataSources.Clear();
            ReportDataSource soirce = new ReportDataSource("DataSet1", data);
            this.payrollReportViewer.LocalReport.ReportPath = "AllEmployeeSelectedMonth.rdlc";
            this.payrollReportViewer.LocalReport.DataSources.Add(soirce);
            this.payrollReportViewer.RefreshReport();
            //

        }


        // year
        private void DisplayAllEmployeePayrollBYYear()
        {
            var query = new GeneralQuery();
            var data = searchByYear();
            if (data.Rows.Count == 0)
            {
                this.payTitle.Visible = true;
                payrollPictureRe.Visible = true;
                paySub.Visible = true;
                payrollReportViewer.Visible = false;
                return;
            }
            this.payTitle.Visible = false;
            payrollPictureRe.Visible = false;
            paySub.Visible = false;
            payrollReportViewer.Visible = true;
            this.payrollReportViewer.LocalReport.DataSources.Clear();
            ReportDataSource soirce = new ReportDataSource("DataSet1", data);
            this.payrollReportViewer.LocalReport.ReportPath = "SelectedYear.rdlc";
            this.payrollReportViewer.LocalReport.DataSources.Add(soirce);
            this.payrollReportViewer.RefreshReport();
            //

        }

        // display emplyee by its id
        private void DisplayAllEmployeePayrollByID()
        {
            var query = new GeneralQuery();
            var data = searchByID();
            if (data.Rows.Count == 0)
            {
                this.payTitle.Visible = true;
                payrollPictureRe.Visible = true;
                paySub.Visible = true;
                payrollReportViewer.Visible = false;
                return;
            }
            this.payTitle.Visible = false;
            payrollPictureRe.Visible = false;
            paySub.Visible = false;
            payrollReportViewer.Visible = true;
            this.payrollReportViewer.LocalReport.DataSources.Clear();
            ReportDataSource soirce = new ReportDataSource("DataSet1", data);
            this.payrollReportViewer.LocalReport.ReportPath = "OneEmployeePayrollStatement.rdlc";
            this.payrollReportViewer.LocalReport.DataSources.Add(soirce);
            this.payrollReportViewer.RefreshReport();
            //

        }



        // byid and month and year
        private void DisplaySpecificEmployee()
        {
            var query = new GeneralQuery();
            var data = searchByIDYaerMonth();
            if (data.Rows.Count == 0)
            {
                this.payTitle.Visible = true;
                payrollPictureRe.Visible = true;
                paySub.Visible = true;
                payrollReportViewer.Visible = false;
                return;
            }
            this.payTitle.Visible = false;
            payrollPictureRe.Visible = false;
            paySub.Visible = false;
            payrollReportViewer.Visible = true;
            this.payrollReportViewer.LocalReport.DataSources.Clear();
            ReportDataSource soirce = new ReportDataSource("DataSet1", data);
            this.payrollReportViewer.LocalReport.ReportPath = "OneEmployeeSelectedMonthYear.rdlc";
            this.payrollReportViewer.LocalReport.DataSources.Add(soirce);
            this.payrollReportViewer.RefreshReport();
            //

        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }



        // year
        private void populaterYears()
        {
            List<int> years = Enumerable.Range(2000, DateTime.Now.Year - 2000 + 1).ToList();

            foreach (int year in years)
            {
                this.payrollYear.Items.Add(year.ToString());
            }
            this.payrollYear.Items.Add("Select");
            this.payrollYear.SelectedItem = "Select";

        }

        // months
        private void populateMonthNames()
        {
            string[] allMonths = DateTimeFormatInfo.CurrentInfo.MonthNames;
            this.payrollMonth.Items.Clear();
            foreach (string month in allMonths)
            {
                this.payrollMonth.Items.Add(month);
            }
            this.payrollMonth.Items.Add("Select");
            this.payrollMonth.SelectedItem = "Select";

        }

        private void byYEAR(object sender, EventArgs e)
        {
            if (byyear.Checked)
            {
                payrollMonth.Enabled = false;
                payrollYear.Enabled = true;
                employeePayrollID.Enabled = false;
            }
        }

        private void payrollYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

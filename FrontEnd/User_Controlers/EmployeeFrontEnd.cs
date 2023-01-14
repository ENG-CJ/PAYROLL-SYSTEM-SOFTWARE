using Guna.UI2.WinForms;
using HIMILO_ICT_PAYROLL_SYSTEM.Controlers;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HIMILO_ICT_PAYROLL_SYSTEM.FrontEnd.User_Controlers
{
    public partial class EmployeeFrontEnd : UserControl
    {
        public static Guna2DataGridView data = new Guna2DataGridView();
        public static DataGridView dataBonusAndDeductions = new Guna2DataGridView();
        MessagesDLL.Messages msg = new MessagesDLL.Messages();

        public static Guna2ComboBox filter = new Guna2ComboBox();

        Employee query = new Controlers.Employee();
        // vars to be updated.....
        public string IdDeletion { get; set; }
        public string employeeDeductionDeletionID;
        public string id;
        public string name;
        public Int64 mobile;
        public string address;
        public string gender;
        public int salary;
        public string departmentName;
        public string designation;
        public string email;

        public Image employeeImageUpdater { get; set; }


        private void Disable()
        {
            guna2TabControl1.TabPages.Remove(tabPage2);
            deleteBtn.Visible = false;
            editBtn.Visible = false;
            relatedData.Visible = false;
        }

        public EmployeeFrontEnd()
        {
            InitializeComponent();
            data = employeeData;
            dataBonusAndDeductions = deductionsData;
            filter = filterDepartments;

        }

        private void DeleteUsers(object sender, EventArgs e)
        {

        }

        private void AddNewUser(object sender, EventArgs e)
        {

        }

        private void AddEmployee(object sender, EventArgs e)
        {

            Form backdrop = BackDrop.backDrop();
            EmployeeRegistration empRegistration = new EmployeeRegistration();

            backdrop.Show();
            empRegistration.Owner = backdrop;
            empRegistration.ShowDialog();

            backdrop.Dispose();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DeleteEmployee(object sender, EventArgs e)
        {
            if (IdDeletion == null)
                msg.ShowError("Before Deletion Plz Select record You Want To Delete....", "Error");
            else
            {

                var result = msg.ShowWarning("Are You Sure To Delete This Record....\nPress Yes to Continue...", "Confirmation");
                if (result == DialogResult.No)
                    return;
                else
                {
                    var query = new Controlers.Employee();
                    var validDeletion = query.SearchDeletionEmployee(IdDeletion);
                    if (query.QueryHasError)
                        msg.ShowError($"Something Went Wrong....\nError Message...\n{query.ErrorMessage}", "Error | Deletion");
                    else if (validDeletion)
                        msg.ShowError("You Can't Delete This Employee Record, It Has Referenced To Another Record,\nFirst Delete That Information Then you Can Delete This Record ....", "Error");
                    else
                    {
                        var query_2 = new Controlers.Employee();
                        for (int i = 0; i < employeeData.SelectedRows.Count; i++)
                        {
                            var id = employeeData.SelectedRows[i].Cells[0].Value.ToString();
                            query_2.Delete(id);
                            if (query_2.QueryHasError)
                            {
                                msg.ShowError($"Something Went Wrong....\nError Message...\n{query_2.ErrorMessage}", "Error | Deletion");
                                return;
                            }
                        }



                        var generalQuery = new GeneralQuery();
                        msg.ShowInfo("Employee Record Successfully Removed....", "Commits | HIMILO ICT TECH CENTER");
                        var data = generalQuery.GetData("getEmpData");
                        employeeData.DataSource = data;
                        IdDeletion = null;
                        var gen = new GeneralQuery();
                        gen.CountData("countemp", DashControelr.allEmp);

                    }
                }

            }
        }

        private void GetEmployeeData(object sender, DataGridViewCellEventArgs e)
        {
            deleteBtn.Enabled = true;
            editBtn.Enabled = true;
            IdDeletion = employeeData.SelectedRows[0].Cells[0].Value.ToString();


            GetEmployeeInformation(IdDeletion);




            /// reading data
        }



        private void UpdateEmployee(object sender, EventArgs e)
        {
            if (IdDeletion == null)
                msg.ShowError("Before Updating Plz Select record You Want To Update....", "Error");
            else
            {
                var result = msg.ShowWarning("Are You Sure To Delete This Record....\nPress Yes to Continue...", "Confirmation");
                if (result == DialogResult.No)
                    return;
                else
                {
                    var query = new GeneralQuery();
                    query.Delete("deleteEmployee", "@id", IdDeletion);
                    if (query.QueryHasError)
                        msg.ShowError($"Something Went Wrong....\nError Message...\n{query.ErrorMessage}", "Error | Deletion");
                    else
                    {
                        msg.ShowInfo("Employee Record Successfully Removed....", "Commits | HIMILO ICT TECH CENTER");
                        var data = query.GetData("getEmployeeData");
                        employeeData.DataSource = data;

                    }
                }

            }
        }

        private void SearchEmployee(object sender, EventArgs e)
        {
            employeeData.Visible = true;
            var query = new GeneralQuery();
            var data = query.search("searchemployee", "@name", searchEmployeeName.Text);
            if (data.Rows.Count > 0)
            {
                employeeData.DataSource = data;
                employeeData.Visible = true;
                pictureNoDataFound.Visible = false;
            }
            else
            {
                pictureNoDataFound.Visible = true;
                employeeData.Visible = false;
            }
        }

        private void EmployeeFrontEnd_Load(object sender, EventArgs e)
        {
            if (LOGIN.userRole.ToLower() == "user")
                Disable();
            var query = new GeneralQuery();


            query.BindComboValue("bindDeparts", filterDepartments);
            filterDepartments.Items.Add("Employee(All)");
            filterDepartments.SelectedItem = "Employee(All)";
            var data = query.GetData("getEmpData");
            employeeData.DataSource = data;

            readDataLoad();
            var query_2 = new GeneralQuery();
            var data_bonus = query_2.GetData("getDeductions");
            deductionsData.DataSource = data_bonus;



        }

        private void DeleteEmployeeDeductions(object sender, EventArgs e)
        {
            if (employeeDeductionDeletionID == null)
                msg.ShowError("Before Deletion Plz Select record You Want To Delete....", "Error");
            else
            {
                var result = msg.ShowWarning("WARNING\n_________\nDo You Really Want To Delete This Record? \n" +
                    "Press Yes To Continue... ", "Confirmation");
                if (result == DialogResult.No)
                    return;
                else
                {
                    var query = new GeneralQuery();
                    for (int i = 0; i < deductionsData.SelectedRows.Count; i++)
                    {
                        var emploeeID = deductionsData.SelectedRows[i].Cells[1].Value.ToString();
                        var _month = deductionsData.SelectedRows[i].Cells[4].Value.ToString();
                        var _year = deductionsData.SelectedRows[i].Cells[5].Value.ToString();
                        query.DeleteDeduction(emploeeID, _month, _year);
                        if (query.QueryHasError)
                        {
                            msg.ShowError($"Something Went Wrong....\nError Message...\n{query.ErrorMessage}", "Error | Deletion");
                            return;
                        }
                    }

                    msg.ShowInfo("Employee Related Deductions And Bonus Has Been Removed Successfully....", "Commits | HIMILO ICT TECH CENTER");
                    var data = query.GetData("getDeductions");
                    deductionsData.DataSource = data;

                }
            }
        }
        public string month;
        public string year;
        private void GetDeductionData(object sender, DataGridViewCellEventArgs e)
        {
            deleteDedBt.Enabled = true;
            employeeDeductionDeletionID = deductionsData.SelectedRows[0].Cells[1].Value.ToString();
            month = deductionsData.SelectedRows[0].Cells[4].Value.ToString();
            year = deductionsData.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void FilterRelatedData(object sender, EventArgs e)
        {
            if (this.relatedData.Checked)
            {
                var query = new GeneralQuery();
                var data = query.GetData("getEmployeeData");
                employeeData.DataSource = data;
            }
            else
            {
                var query = new GeneralQuery();
                var data = query.GetData("getEmpData");
                employeeData.DataSource = data;
            }
        }

        private void filterByDeparts(object sender, EventArgs e)
        {
            employeeData.Visible = true;
            pictureNoDataFound.Visible = false;
            var general = new GeneralQuery();
            if (filterDepartments.Text == "Employee(All)")
            {
                pictureNoDataFound.Visible = false;
                var all_data = general.GetData("getEmpData");
                employeeData.DataSource = all_data;
                return;
            }
            var data = general.filterName("filterByDeparts", "@depart", filterDepartments.Text);
            if (data.Rows.Count > 0)
            {
                employeeData.Visible = true;
                employeeData.DataSource = data;

                pictureNoDataFound.Visible = false;
            }
            else
            {

                employeeData.Visible = false;
                pictureNoDataFound.Visible = true;
            }

        }

        private void FilterTopNUMBER(object sender, EventArgs e)
        {
            var general = new GeneralQuery();
            if (filterTopNumber.Text == "All")
            {
                var data = general.GetData("getEmpData");
                employeeData.DataSource = data;
            }
            else
            {
                var data = general.showTopNumber("filterAllEmployees", "@number", int.Parse(filterTopNumber.Text));
                if (data.Rows.Count > 0)
                    employeeData.DataSource = data;
                else
                    return;
            }
        }

        private void UpdateEmployeeData(object sender, EventArgs e)
        {
            if (IdDeletion == null)
            {
                msg.ShowError("Before Updating Plz Select record You Want To Update....", "Error");
                return;
            }

            var backdrop = BackDrop.backDrop(.68d);
            var employeeUpdater = new FrontEnd.Forms.UpdateEmployee(name, gender, mobile, address, departmentName, designation,
                salary, employeeImageUpdater, email, IdDeletion);
            backdrop.Show();

            employeeUpdater.Owner = backdrop;
            employeeUpdater.ShowDialog();
            IdDeletion = null;
            backdrop.Dispose();


        }






        public void GetEmployeeInformation(string id)
        {

            try
            {
                SqlConnection connection = Connections.GetSqlConnection();
                connection.Open();
                SqlCommand command = new SqlCommand("getEmployeeInfo", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", id);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        name = reader[0].ToString();
                        mobile = Convert.ToInt64(reader[2]);
                        email = reader[3].ToString();
                        address = reader[4].ToString();
                        gender = reader[1].ToString();
                        salary = Convert.ToInt32(reader[7]);
                        departmentName = reader[5].ToString();
                        designation = reader[6].ToString();
                        employeeImageUpdater = ImageControler.GteImageFromStream(reader[8]);
                    }

                }
                reader.Close();
                connection.Close();
                //  QueryHasError = false;
            }
            catch (Exception ex)
            {
                msg.ShowError(ex.Message);
                //QueryHasError = true;
                //ErrorMessage = ex.Message;
            }


        }

        private void Editbonus(object sender, EventArgs e)
        {
            if (employeeDeductionDeletionID == null)
            {
                msg.ShowError("First Select Record You Want To Update....", "Error | Updating");
                return;
            }
            var bonus = new Controlers.Bonus();
            bonus.ShowEmployeeBonus(employeeDeductionDeletionID,
              month, year);
            if (bonus.RowsNumber == 0)
            {

                var bonusManager_ = new FrontEnd.Forms.BonusDeductionManager(bonus.errorMessage);
                var _backdrop = BackDrop.backDrop(.67d);

                _backdrop.Show();
                bonusManager_.Owner = _backdrop;
                bonusManager_.ShowDialog();

                _backdrop.Dispose();
                employeeDeductionDeletionID = null;
            }
            else if (bonus.RowsNumber == 1)
            {

                GetEmployeeInformation(employeeDeductionDeletionID);
                var bonusManager = new FrontEnd.Forms.BonusDeductionManager(employeeDeductionDeletionID, name, gender, departmentName, designation, salary, employeeImageUpdater,
                    bonus.Bonusamount, bonus.deductionAmount, bonus.month, bonus.year);
                var backdrop = BackDrop.backDrop(.67d);

                backdrop.Show();
                bonusManager.Owner = backdrop;
                bonusManager.ShowDialog();

                backdrop.Dispose();
                employeeDeductionDeletionID = null;
            }
        }

        private void AddBonusA(object sender, EventArgs e)
        {
            var backdrop = BackDrop.backDrop(.67d);
            var empBonus = new FrontEnd.Forms.AddBonus();

            backdrop.Show();

            empBonus.Owner = backdrop;
            empBonus.ShowDialog();
            backdrop.Dispose();
        }

        private void searchEmployeeID_TextChanged(object sender, EventArgs e)
        {
            var q = new GeneralQuery();
            deductionsData.Visible = true;
            deductionnotFound.Visible = false;
            var data = q.search("searchEpID", "@id", searchEmployeeDID.Text);
            if (data.Rows.Count > 0)
            {
                deductionsData.Visible = true;
                deductionnotFound.Visible = false;
                deductionsData.DataSource = data;

            }
            else
            {
                deductionsData.Visible = false;
                deductionnotFound.Visible = true;
            }
        }


        private bool CheckExistnace()
        {
            var conn = Connections.GetSqlConnection();
            conn.Open();
            var cmd = new SqlCommand("readDeduction", conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                    return true;
            }
            reader.Close();
            conn.Close();
            return false;
        }




        private void readDataLoad()
        {
            if (CheckExistnace())
                return;
            else
            {
                var conn = Connections.GetSqlConnection();
                conn.Open();
                var cmd = new SqlCommand("readEmpID", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows)
                        addDeductionsLoad(reader[0].ToString());
                }
                reader.Close();
                conn.Close();
            }
        }


        private void addDeductionsLoad(string empid)
        {

            var conn = Connections.GetSqlConnection();
            conn.Open();
            var cmd = new SqlCommand("addLoad", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empID", empid);
            cmd.ExecuteNonQuery();
            conn.Close();

        }
    }
}

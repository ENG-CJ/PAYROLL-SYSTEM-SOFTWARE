using MessagesDLL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HIMILO_ICT_PAYROLL_SYSTEM.FrontEnd.Forms
{
    public partial class AddBonus : Form
    {

        public bool QueryHasError;
        public string ErrorMessage;
        public string name;
        public string email;
        public string gender;
        public int salary;
        public string depart;
        public string level;


        public string state;
        Messages msg = new
                    Messages();
        public AddBonus()
        {
            InitializeComponent();

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }







        public void GetdData()
        {
            try
            {
                SqlConnection connection = Connections.GetSqlConnection();
                connection.Open();
                SqlCommand command = new SqlCommand("empInfo", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", empID.Text);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        name = reader[0].ToString();
                        email = reader[1].ToString();
                        gender = reader[2].ToString();
                        salary = Convert.ToInt32(reader[3]);
                        depart = reader[4].ToString();
                        level = reader[5].ToString();
                    }
                }

                connection.Close();
                QueryHasError = false;
            }
            catch (Exception ex)
            {
                QueryHasError = true;
                ErrorMessage = ex.Message;
            }
        }


        public void getCurrentMonth()
        {
            try
            {
                SqlConnection connection = Connections.GetSqlConnection();
                connection.Open();
                SqlCommand command = new SqlCommand("selecrCurrentmonth", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        currentMonth.Text = reader[0].ToString();
                        currentYear.Text = reader[1].ToString();

                    }
                }

                connection.Close();
                QueryHasError = false;
            }
            catch (Exception ex)
            {
                QueryHasError = true;
                ErrorMessage = ex.Message;
            }
        }

        private void EmployeeInfo(object sender, EventArgs e)
        {
            state = null;
            if (empID.Text == "Select")
            {
                OneControl.ClearControles(empName, EmpGender, empSalary, empMail);
                return;
            }

            GetdData();
            if (QueryHasError)
                msg.ShowError("Error Occured\n" + ErrorMessage, "Error | SQL ERROR");
            else
            {
                empName.Text = name;
                empSalary.Text = salary.ToString();
                EmpGender.Text = gender;
                empMail.Text = email;
                department.Text = depart;
                designatioon.Text = level;

                var data = readBonusEmploye();
                if (data.Rows.Count > 0)
                {
                    bonusAmont.Text = data.Rows[0].Field<int>(0).ToString();
                    totalDeductions.Text = data.Rows[0].Field<int>(1).ToString();
                    ComputeExistBonus();


                    if (int.Parse(bonusAmont.Text) > 0)
                    {

                        totalDeductions.ReadOnly = true;
                        errolbl.Visible = true;
                        comBtn.Visible = false;
                        bonustn.Visible = false;
                        bonusNames.Enabled = false;
                    }
                    else
                    {
                        state = "Update";
                        totalDeductions.ReadOnly = false;
                        bonusNames.Enabled = true;
                        errolbl.Visible = false;
                        comBtn.Visible = true;
                        bonustn.Visible = true;
                    }

                }
                else
                {
                    state = "Add";
                    bonusAmont.Text = "0";
                    totalIncome.Text = empSalary.Text;
                }
                // else les the 0


            }
        }




        public DataTable readBonusEmploye()
        {
            var table = new DataTable();
            try
            {
                SqlConnection connection = Connections.GetSqlConnection();
                connection.Open();
                SqlCommand command = new SqlCommand("readEmployeeBonus", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@empID", empID.Text);
                command.Parameters.AddWithValue("@month", currentMonth.Text);
                command.Parameters.AddWithValue("@year", currentYear.Text);
                var reader = new SqlDataAdapter(command);

                reader.Fill(table);

                command.ExecuteNonQuery();
                connection.Close();
                QueryHasError = false;
            }
            catch (Exception ex)
            {
                QueryHasError = true;
                ErrorMessage = ex.Message;
            }
            return table;
        }
        private void AddBonus_Load(object sender, EventArgs e)
        {

            var query = new GeneralQuery();
            query.BindComboValue("readBonusNames", bonusNames);
            bonusNames.Items.Add("Select");
            bonusNames.SelectedItem = "Select";
            getCurrentMonth();
            var gen = new GeneralQuery();
            gen.BindComboValue("selectEmpID", empID);
            empID.Items.Add("Select");
            empID.SelectedItem = "Select";


        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void ComputeExistBonus()
        {



            // msg.ShowInfo(salary_with_sign);
            try
            {
                int totalSalary = int.Parse(bonusAmont.Text) + (int.Parse(empSalary.Text));
                int total = totalSalary - (int.Parse(totalDeductions.Text));

                totalIncome.Text = total.ToString();
            }
            catch (Exception ex)
            {
                msg.ShowError("Error " + ex.Message, "Error");
            }

        }

        private void ComputeBonus(object sender, EventArgs e)
        {
            try
            {
                if (empID.Text == "Select")
                {
                    msg.ShowError("Select Employee You Want To Add Bonus Its Net Salary...", "Error | computing net Salary");
                    return;
                }
                if (bonusNames.Text == "Select")
                {
                    msg.ShowError("To Compute Net Salary Of This Employee First Select Bonus Name...", "Error | computing net Salary");
                    return;
                }
                if (Validations.HasCharacters(totalDeductions.Text))
                {
                    msg.ShowError("Total Deduction Contains Characters, Only Allowed Numeric Value.", "Error | computing net Salary");
                    totalDeductions.Clear();
                    return;
                }

                if (int.Parse(totalDeductions.Text) >= int.Parse(totalIncome.Text))
                {
                    msg.ShowError("Total Deductions Cannot Exceed Or equal Employee Net income Value.", "Error | computing net Salary");
                    totalDeductions.Clear();
                    return;
                }

                if (int.Parse(totalDeductions.Text) < 0)
                {
                    msg.ShowError("Total Deductions  Must Be 0 Or Greater.", "Error | computing net Salary");
                    totalDeductions.Clear();
                    return;
                }

                if ((totalDeductions.Text) == "")
                {
                    msg.ShowError("Total Deductions Can't Be Null Value", "Error | computing net Salary");
                    totalDeductions.Clear();
                    return;
                }

                double bonusPrecentage = double.Parse(bonusPrecent.Text) / 100;
                int bonusAmount = (int)(bonusPrecentage * (int.Parse(empSalary.Text)));
                bonusAmont.Text = bonusAmount.ToString();

                // msg.ShowInfo(salary_with_sign);
                int totalSalary = bonusAmount + (int.Parse(empSalary.Text));
                int total = totalSalary - (int.Parse(totalDeductions.Text));

                totalIncome.Text = total.ToString();
                bonustn.Enabled = true;
            }
            catch (Exception ex)
            {
                msg.ShowError(ex.Message, "Error While Executing Bonus Query");
                totalDeductions.Text = "0";
                int totalSalary = (int.Parse(bonusAmont.Text)) + (int.Parse(empSalary.Text));
                int total = totalSalary - (int.Parse(totalDeductions.Text));

                totalIncome.Text = total.ToString();
            }
        }

        private void totalDeductions_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (totalDeductions.Text == "")
                {

                    totalDeductions.Text = "0";
                    int totalSalary = (int.Parse(bonusAmont.Text)) + (int.Parse(empSalary.Text));
                    int total = totalSalary - (int.Parse(totalDeductions.Text));

                    totalIncome.Text = total.ToString();

                }
                else if (Validations.HasCharacters(totalDeductions.Text))
                {
                    msg.ShowError("Total Deduction Contains Characters, Only Allowed Numeric Value.", "Error | computing net Salary");
                    totalDeductions.Clear();

                }

            }
            catch (Exception ex)
            {
                msg.ShowError(ex.Message, "Error");
            }


        }

        private void bonusNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            var bonus = new Controlers.Bonus();
            bonus.DisplaySmount(this.bonusNames.Text, bonusPrecent);
        }

        private void AddBonus_(object sender, EventArgs e)
        {

        }

        private void AddOrupdateBonus(object sender, EventArgs e)
        {
            //if (state.ToLower() == "update")
            //{
            //    //try
            //    //{
            //    if (empID.Text == "Select")
            //    {
            //        msg.ShowError("Select Employee You Want To Add Bonus Its Net Salary...", "Error | computing net Salary");
            //        return;
            //    }
            //    if (bonusNames.Text == "Select")
            //    {
            //        msg.ShowError("To Compute Net Salary Of This Employee First Select Bonus Name...", "Error | computing net Salary");
            //        return;
            //    }
            //    if (Validations.HasCharacters(totalDeductions.Text))
            //    {
            //        msg.ShowError("Total Deduction Contains Characters, Only Allowed Numeric Value.", "Error | computing net Salary");
            //        totalDeductions.Clear();
            //        return;
            //    }

            //    if (int.Parse(totalDeductions.Text) >= int.Parse(totalIncome.Text))
            //    {
            //        msg.ShowError("Total Deductions Cannot Exceed Or equal The Employee Net Income.", "Error | computing net Salary");
            //        totalDeductions.Clear();
            //        return;
            //    }

            //    if (int.Parse(totalDeductions.Text) < 0)
            //    {
            //        msg.ShowError("Total Deductions  Must Be 0 Or Greater.", "Error | computing net Salary");
            //        totalDeductions.Clear();
            //        return;
            //    }

            //    if ((totalDeductions.Text) == "")
            //    {
            //        msg.ShowError("Total Deductions Can't Be Null Value", "Error | computing net Salary");
            //        totalDeductions.Clear();
            //        return;
            //    }
            //    double bonusPrecentage = double.Parse(bonusPrecent.Text) / 100;
            //    int _bonusAmount = (int)(bonusPrecentage * (int.Parse(empSalary.Text)));
            //    bonusAmont.Text = _bonusAmount.ToString();

            //    // msg.ShowInfo(salary_with_sign);
            //    int totalSalary = _bonusAmount + (int.Parse(empSalary.Text));
            //    int total = totalSalary - (int.Parse(totalDeductions.Text));

            //    totalIncome.Text = total.ToString();


            //    MessageBox.Show(bonusAmont.Text);

            //    var bonus = new Controlers.Bonus();
            //    bonus.UpdateBonusEmployee(

            //        int.Parse(bonusAmont.Text),
            //        int.Parse(totalDeductions.Text),
            //        currentMonth.Text,
            //        currentYear.Text,
            //        empID.Text


            //        );

            //    //if (bonus.RowsNumber == 1)
            //    //    msg.ShowError(bonus.errorMessage, "Error While Updating...");
            //    //else
            //    //{
            //    var query = new GeneralQuery();
            //    msg.ShowInfo("Bonus Added The Employee [ " + empName.Text + " ]", "Commits");
            //    FrontEnd.User_Controlers.EmployeeFrontEnd.dataBonusAndDeductions.DataSource = query.GetData("getDeductions");
            //    this.Close();
            //    // }
            //    //}
            //    //catch (Exception ex)
            //    //{
            //    //    msg.ShowError(ex.Message, "Error While Updating Employee Binus | HIMILO TECH ");
            //    //    totalDeductions.Text = "0";
            //    //    int totalSalary = (int.Parse(bonusAmont.Text)) + (int.Parse(empSalary.Text));
            //    //    int total = totalSalary - (int.Parse(totalDeductions.Text));

            //    //    totalIncome.Text = total.ToString();
            //    //}
            //}
            //else if (state.ToLower() == "add")
            //{
                try
                {
                    if (empID.Text == "Select")
                    {
                        msg.ShowError("Select Employee You Want To Add Bonus Its Net Salary...", "Error | computing net Salary");
                        return;
                    }
                    if (bonusNames.Text == "Select")
                    {
                        msg.ShowError("To Compute Net Salary Of This Employee First Select Bonus Name...", "Error | computing net Salary");
                        return;
                    }
                    if (Validations.HasCharacters(totalDeductions.Text))
                    {
                        msg.ShowError("Total Deduction Contains Characters, Only Allowed Numeric Value.", "Error | computing net Salary");
                        totalDeductions.Clear();
                        return;
                    }

                    if (int.Parse(totalDeductions.Text) >= int.Parse(totalIncome.Text))
                    {
                        msg.ShowError("Total Deductions Cannot Exceed Or equal The Employee Net Income.", "Error | computing net Salary");
                        totalDeductions.Clear();
                        return;
                    }

                    if (int.Parse(totalDeductions.Text) < 0)
                    {
                        msg.ShowError("Total Deductions  Must Be 0 Or Greater.", "Error | computing net Salary");
                        totalDeductions.Clear();
                        return;
                    }

                    if ((totalDeductions.Text) == "")
                    {
                        msg.ShowError("Total Deductions Can't Be Null Value", "Error | computing net Salary");
                        totalDeductions.Clear();
                        return;
                    }
                    double bonusPrecentage = double.Parse(bonusPrecent.Text) / 100;
                    int bonusAmount = (int)(bonusPrecentage * (int.Parse(empSalary.Text)));
                    bonusAmont.Text = bonusAmount.ToString();

                    // msg.ShowInfo(salary_with_sign);
                    int totalSalary = bonusAmount + (int.Parse(empSalary.Text));
                    int total = totalSalary - (int.Parse(totalDeductions.Text));

                    totalIncome.Text = total.ToString();
                    bonustn.Enabled = true;
                    var bonus = new Controlers.Bonus();
                    MessageBox.Show(bonusAmont.Text);
                    bonus.CerateEmployeeBonus(

                        int.Parse(bonusAmont.Text),
                        int.Parse(totalDeductions.Text),

                        empID.Text


                        );

                    if (bonus.QueryHasError)
                        msg.ShowError(bonus.ErrorMessage, "Error While Updating...");
                    else
                    {
                        var query = new GeneralQuery();
                        msg.ShowInfo("Bonus Added The Employee [ " + empName.Text + " ]", "Commits");
                        FrontEnd.User_Controlers.EmployeeFrontEnd.dataBonusAndDeductions.DataSource = query.GetData("getDeductions");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    msg.ShowError(ex.Message, "Error While Updating Employee Binus | HIMILO TECH ");
                    totalDeductions.Text = "0";
                    int totalSalary = (int.Parse(bonusAmont.Text)) + (int.Parse(empSalary.Text));
                    int total = totalSalary - (int.Parse(totalDeductions.Text));

                    totalIncome.Text = total.ToString();
                }
           // }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using MessagesDLL;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace HIMILO_ICT_PAYROLL_SYSTEM.FrontEnd.Forms
{
    public partial class BonusDeductionManager : Form
    {
        Messages msg = new Messages();
        public string bonudStateUpdate;
        public BonusDeductionManager()
        {
            InitializeComponent();
        }


        public BonusDeductionManager(string id, string name, string gender, string depart, string designation, int salary, Image img,
            int amount, int deductions, string month, string year)
        {
            InitializeComponent();
            var query = new GeneralQuery();
            query.BindComboValue("readBonusNames", bonusNames);
            bonusNames.Items.Add("Select");
            bonusNames.SelectedItem = "Select";
            emID.Text = id;
            emName.Text = name;
            emGender.Text = gender;
            emDepart.Text = depart;
            empLevel.Text = designation;
            emSalary.Text = "$" + salary.ToString();
            employeeImage.Image = img;
            bonusAmont.Text = amount.ToString();
            totalIncome.Text = salary.ToString();
            totalDeductions.Text = deductions.ToString();
            currentMonth.Text = month;
            currentYear.Text = year;



            if (bonusAmont.Text != "")
                ComputeBonus();
        }


        public BonusDeductionManager(string error)
        {
            InitializeComponent();
            errorDisplayer.Text = error;
            notFoundMonth.Visible = true;
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Exit(object sender, System.EventArgs e)
        {
            Close();
        }

        private void empAddress_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void guna2GroupBox2_Click(object sender, System.EventArgs e)
        {

        }

        private void ComputeData(object sender, System.EventArgs e)
        {
            try
            {
                if (bonusNames.Text == "Select")
                {
                    msg.ShowError("Select Bonus Name To Compute Employee Total Net Income For This Month", "Error | Bonus");
                    return;
                }
                if (Validations.HasCharacters(totalDeductions.Text))
                {
                    msg.ShowError("Total Deductions Contains Characters, Deductions Must Be Only Numeric Values Numeric Values", "Error | Bonus");
                    totalDeductions.Clear();
                    return;
                }
                if ((totalDeductions.Text) == "")
                {
                    msg.ShowError("Total Deductions Must Be  0 Or Greater, Total Deduction Can't Be Null Value", "Error | Bonus");
                    totalDeductions.Clear();
                    return;
                }
                if (int.Parse(totalDeductions.Text) >= int.Parse(totalIncome.Text))
                {
                    msg.ShowError("Total Deductions Cannot Exceed Employee Net Income Value", "Error | Bonus");
                    totalDeductions.Clear();
                    return;
                }

                if (int.Parse(totalDeductions.Text) < 0)
                {
                    msg.ShowError("Total Deductions Must Be Greater Then 0", "Error | Bonus");
                    totalDeductions.Clear();
                    return;
                }
                string[] salary = emSalary.Text.Split('$');
                string salary_with_sign = salary[1];
                double bonusPrecentage = double.Parse(bonusPrecent.Text) / 100;
                int bonusAmount = (int)(bonusPrecentage * (int.Parse(salary_with_sign)));
                bonusAmont.Text = bonusAmount.ToString();

                // msg.ShowInfo(salary_with_sign);
                int totalSalary = bonusAmount + (int.Parse(salary_with_sign));
                int total = totalSalary - (int.Parse(totalDeductions.Text));

                totalIncome.Text = total.ToString();
                editBtn.Enabled = true;


            }
            catch (Exception ex)
            {
                msg.ShowError(ex.Message, "Error");
                totalDeductions.Clear();
            }


        }

        private void DisplayAmount(object sender, System.EventArgs e)
        {
            var bonus = new Controlers.Bonus();
            bonus.DisplaySmount(this.bonusNames.Text, bonusPrecent);
        }

        private void CheckDeductions(object sender, System.EventArgs e)
        {

            if (totalDeductions.Text == "")
                return;
            if (Validations.HasCharacters(totalDeductions.Text))
            {
                msg.ShowError("Total Deductions Contains Characters, Deductions Must Be Only Numeric Values Numeric Values", "Error | Bonus");
                totalDeductions.Clear();
                return;
            }

            //int deductin = int.Parse(totalDeductions.Text);

            //if (int.Parse(totalIncome.Text)<0)
            //{
            //    msg.ShowError("Employee Income Salary Cannot Be Negative Value", "Computing Salary");
            //    totalDeductions.Text = "";

            //}

        }

        private void UpdateData(object sender, System.EventArgs e)
        {
            try
            {
                if (bonudStateUpdate != null && bonusAmont.Text == "0")
                {
                    if (Validations.HasCharacters(totalDeductions.Text))
                    {
                        msg.ShowError("Total Deductions Contains Characters, Deductions Must Be Only  Numeric Values", "Error | Bonus");
                        totalDeductions.Clear();
                        foreach (char c in totalDeductions.Text)
                        {
                            if (char.IsLetter(c))
                            {
                                totalDeductions.Text += totalDeductions.Text.Remove(c);
                            }
                        }
                        return;
                    }

                    if ((totalDeductions.Text) == "")
                    {
                        msg.ShowError("Total Deductions Must Be  0 Or Greater, Total Deduction Can't Be Null Value", "Error | Bonus");
                        totalDeductions.Clear();
                        return;
                    }

                    if (int.Parse(totalDeductions.Text) >= int.Parse(totalIncome.Text))
                    {
                        msg.ShowError("Total Deductions Cannot Exceed Employee Net Income Value", "Error | Bonus");
                        totalDeductions.Clear();
                        return;
                    }
                    if (int.Parse(totalDeductions.Text) < 0)
                    {
                        msg.ShowError("Total Deductions Must Be Greater Then 0", "Error | Bonus");
                        totalDeductions.Clear();
                        return;
                    }

                    // start
                    //   string[] salary = emSalary.Text.Split('$');
                    // string salaryEithou = salary[1];
                    //double bonusPrecentage = double.Parse(bonusPrecent.Text) / 100;
                    //int bonusAmount = (int)(bonusPrecentage * (int.Parse(salary_with_sign)));
                    //  bonusAmont.Text = bonusAmount.ToString();

                    // msg.ShowInfo(salary_with_sign);
                    //  int totalSalary = bonusAmount + (int.Parse(salary_with_sign));
                    int totalCome = int.Parse(totalIncome.Text) - (int.Parse(totalDeductions.Text));

                    totalIncome.Text = totalCome.ToString();
                    editBtn.Enabled = true;
                    var bonus_2 = new Controlers.Bonus();
                    bonus_2.UpdateBonusEmployee(

                        int.Parse(bonusAmont.Text),
                        int.Parse(totalDeductions.Text),
                        currentMonth.Text,
                        currentYear.Text,
                        emID.Text


                        );

                    if (bonus_2.RowsNumber == 1)
                        msg.ShowError(bonus_2.errorMessage, "Error While Updating...");
                    else
                    {
                        var query = new GeneralQuery();
                        msg.ShowInfo("Record Successfully Managed...", "Commits");
                        FrontEnd.User_Controlers.EmployeeFrontEnd.dataBonusAndDeductions.DataSource = query.GetData("getDeductions");
                        this.Close();
                    }

                    // end
                    return;
                }

                if (bonusNames.Text == "Select")
                {
                    msg.ShowError("Select Bonus Name To Compute Employee Total Net Income For This Month", "Error | Bonus");
                    return;
                }
                if (Validations.HasCharacters(totalDeductions.Text))
                {
                    msg.ShowError("Total Deductions Contains Characters, Deductions Must Be Only  Numeric Values", "Error | Bonus");
                    totalDeductions.Clear();
                    foreach (char c in totalDeductions.Text)
                    {
                        if (char.IsLetter(c))
                        {
                            totalDeductions.Text += totalDeductions.Text.Remove(c);
                        }
                    }
                    return;
                }


                if (int.Parse(totalDeductions.Text) >= int.Parse(totalIncome.Text))
                {
                    msg.ShowError("Total Deductions Cannot Exceed Employee Net Income Value", "Error | Bonus");
                    totalDeductions.Clear();
                    return;
                }
                if ((totalDeductions.Text) == "")
                {
                    msg.ShowError("Total Deductions Must Be  0 Or Greater, Total Deduction Can't Be Null Value", "Error | Bonus");
                    totalDeductions.Clear();
                    return;
                }
                if (int.Parse(totalDeductions.Text) < 0)
                {
                    msg.ShowError("Total Deductions Must Be Greater Then 0", "Error | Bonus");
                    totalDeductions.Clear();
                    return;
                }
                string[] salary = emSalary.Text.Split('$');
                string salary_with_sign = salary[1];
                double bonusPrecentage = double.Parse(bonusPrecent.Text) / 100;
                int bonusAmount = (int)(bonusPrecentage * (int.Parse(salary_with_sign)));
                bonusAmont.Text = bonusAmount.ToString();

                // msg.ShowInfo(salary_with_sign);
                int totalSalary = bonusAmount + (int.Parse(salary_with_sign));
                int total = totalSalary - (int.Parse(totalDeductions.Text));

                totalIncome.Text = total.ToString();
                editBtn.Enabled = true;
                var bonus = new Controlers.Bonus();
                bonus.UpdateBonusEmployee(

                    int.Parse(bonusAmont.Text),
                    int.Parse(totalDeductions.Text),
                    currentMonth.Text,
                    currentYear.Text,
                    emID.Text


                    );

                if (bonus.RowsNumber == 1)
                    msg.ShowError(bonus.errorMessage, "Error While Updating...");
                else
                {
                    var query = new GeneralQuery();
                    msg.ShowInfo("Record Successfully Managed...", "Commits");
                    FrontEnd.User_Controlers.EmployeeFrontEnd.dataBonusAndDeductions.DataSource = query.GetData("getDeductions");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                msg.ShowError(ex.Message, "Error");
            }
        }

        private void BonusDeductionManager_Load(object sender, System.EventArgs e)
        {


        }



        private void ComputeBonus()
        {
            try
            {
                string[] salary = emSalary.Text.Split('$');
                string salary_with_sign = salary[1];


                int totalSalary = int.Parse(bonusAmont.Text) + (int.Parse(salary_with_sign));
                int total = totalSalary - (int.Parse(totalDeductions.Text));

                totalIncome.Text = total.ToString();
            }
            catch (Exception ex)
            {
                msg.ShowError(ex.Message, "Error");
            }

        }

        private void guna2CheckBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            if (guna2CheckBox1.Checked && bonusAmont.Text == "0")
                return;

            if (guna2CheckBox1.Checked && bonusAmont.Text != "0")
            {
                var result = msg.ShowWarning("NOTE:\nUpdating Bonus To Zero Will Cause Losing Existing Amount\nDo You Want To Update?", "Confirmation");
                if (result == DialogResult.No)
                {
                    guna2CheckBox1.Checked = false;
                    return;
                }
                else
                {


                    var lcal = (int.Parse(totalIncome.Text) - int.Parse(bonusAmont.Text));
                    totalIncome.Text = lcal.ToString();
                    bonusAmont.Text = "0";
                    bonudStateUpdate = "Update";
                    editBtn.Enabled = true;


                }
            }
            else
                return;
        }
    }
}

using Guna.UI2.WinForms;
using HIMILO_ICT_PAYROLL_SYSTEM.FrontEnd.User_Controlers;
using MessagesDLL;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace HIMILO_ICT_PAYROLL_SYSTEM
{
    public partial class EmployeeRegistration : Form
    {
        Messages msg = new Messages();
        public long number;
        public int temp_salar;

        public static Guna2ComboBox departCombo = new Guna2ComboBox();
        public static Guna2ComboBox levelCombo = new Guna2ComboBox();
        // over vars 
        public bool isCharacetrValidator;
        public EmployeeRegistration()
        {
            InitializeComponent();
            departCombo = departmentName;
            levelCombo = employeelevel;
        }

        private void guna2VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private bool HasCharacters(string text)
        {
            for (int i = 2; i <= text.Length - 1; i++)
            {
                if (char.IsLetter(text[i]))
                {

                    return true;

                }
            }
            return false;
        }

        private bool HasValidName(string text)
        {
            foreach (char txt in text)
            {
                if (text.Any(c => !char.IsLetter(txt) && !char.IsWhiteSpace(txt)))
                    return false;

            }
            return true;
        }
        private void EmployeeRegistration_Load(object sender, EventArgs e)
        {
            var query = new GeneralQuery();
            query.BindComboValue("bindDeparts", departmentName);
            query.BindComboValue("getLevelsName", employeelevel);
            departmentName.Items.Add("Select");
            departmentName.SelectedItem = "Select";
            employeelevel.Items.Add("Select");
            employeelevel.SelectedItem = "Select";
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void CloseWindow(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveEmployee(object sender, EventArgs e)
        {

            try
            {
                if (Validations.validateAllBlanks(employeeID, employeeName, mobileNumber,
               Address, Email, baseSalary))
                    msg.ShowError("All fields Are required...", "Error");
                else if (Validations.NotChecked(male, female))
                    msg.ShowError("Select Gender...", "Error");
                else if (Validations.ComboNotSelectedValue("Select", departmentName, employeelevel))
                    msg.ShowError("Department And Employee Level  Cannot be Null", "Error");
                else if (Validations.ImageNotSelected(emloyeePhoto))
                    msg.ShowError("Employee Image Can't be Null....", "Error");
                else if (!Validations.ValidDateOfBirth(dateOfBirth.Value))
                    msg.ShowError("Employee Age Must Betweetn 25 and 60 years old...", "Error");
                else
                {
                    if (employeeID.Text.ToUpper().StartsWith("EM"))
                    {
                        if (HasCharacters(employeeID.Text))
                        {
                            msg.ShowError("In Employee ID , After [ EM ] Identifier Characetes Only Allowed Numeric Values Not Letters");
                            return;
                        }

                        if (!HasValidName(employeeName.Text))
                        {
                            msg.ShowError("Employee Name Must Be Valid Name Characters");
                            return;
                        }

                        if (employeeName.Text.Length < 3)
                        {
                            msg.ShowError("Employee Name Must Be Valid FullName");
                            return;
                        }
                        Int64 temp;
                        Int64 phone;
                        if (Int64.TryParse(mobileNumber.Text, out phone))
                        {

                            if (Validations.isValidMobile(mobileNumber.Text))
                            {
                                if (Validations.isValidLength(mobileNumber.Text))
                                {
                                    phone = Int64.Parse(mobileNumber.Text);
                                    if (Validations.IsValidEmail(Email.Text))
                                    {
                                        if (Int64.TryParse(baseSalary.Text, out temp))
                                        {
                                            temp_salar = int.Parse(baseSalary.Text);
                                            if (Validations.MinMaxchecker(temp_salar, 150, 5000))
                                            {
                                                Execute(phone);
                                                var gen = new GeneralQuery();
                                                gen.CountData("countemp", DashControelr.allEmp);
                                                this.Close();
                                            }

                                            else
                                                msg.ShowError("Salary out Of Posible Range Values,\nSalary Must Betweeen 150 and 5000", "Error | Salary");
                                        }
                                        else
                                            msg.ShowError("Salary  Conatins Characetrs, Salary Must be Valid Numeric Value .....", "Error | HIMILO TECHNOLOGIES CENTER");
                                    }
                                    else
                                        msg.ShowError($"{Email.Text} is not a Correct Format Email, Provide Correct Email\nExample: someOne@gmail.com", "Error");
                                }
                                else
                                    msg.ShowError($"Mobile Length Must Be 12 Digits or 13 Digits", "Error");


                            }
                            else
                                msg.ShowError("Mobile Number Must Start Local Code Number [ 252 ] ", "Error");
                        }
                        else
                            msg.ShowError("Employee Phone Number Must be Valid Numeric Values, Not Characetrs..", "Error");
                    }
                    else
                        msg.ShowError("Employee ID Must Start [ EM  ] Characetrs...", "Error");
                }
            }
            catch (Exception ex)
            {
                msg.ShowError(ex.Message, "Error Occured...");
                return;
            }
        }

        private void Execute(Int64 number)
        {
            try
            {
                var employee = new Controlers.Employee()
                {
                    employeeID = employeeID.Text,
                    employeeName = employeeName.Text,
                    mobile = number,
                    dateOfBirth = dateOfBirth.Value,
                    joinedDate = joinedDate.Value,
                    designation = employeelevel.Text,
                    salary = temp_salar,
                    location = Address.Text,
                    departmentname = departmentName.Text,
                    email = Email.Text,
                    EmployeeImage = emloyeePhoto.Image

                };

                var gender = "";
                if (male.Checked) gender = "Male"; else gender = "Female";
                employee.gender = gender;
                employee.AddEmployee();
                if (employee.QueryHasError)
                    msg.ShowError("Something Went Wriong...\n" + employee.ErrorMessage, "Error");
                else
                {
                    msg.ShowInfo($"Employee {employeeName.Text} Sucessfully Saved....", "Commits");
                    var query = new GeneralQuery();
                    EmployeeFrontEnd.data.DataSource = query.GetData("getEmpData");
                    EmployeeFrontEnd.dataBonusAndDeductions.DataSource = query.GetData("getDeductions");


                }

            }
            catch (Exception ex)
            {
                msg.ShowError(ex.Message, "Error Occured...");
                return;
            }


        }

        private void BROWSEIMAGE(object sender, EventArgs e)
        {
            try
            {
                if (OPENIMAGE.ShowDialog() == DialogResult.OK)
                {
                    emloyeePhoto.Image = Image.FromFile(OPENIMAGE.FileName);
                    imageCover.SendToBack();
                    emloyeePhoto.BringToFront();
                }
            }
            catch (Exception ex)
            {
                msg.ShowError(ex.Message, "Error Occured...");
            }
        }

        private void guna2DateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}

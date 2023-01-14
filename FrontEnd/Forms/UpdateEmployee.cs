using HIMILO_ICT_PAYROLL_SYSTEM.FrontEnd.User_Controlers;
using MessagesDLL;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace HIMILO_ICT_PAYROLL_SYSTEM.FrontEnd.Forms
{
    public partial class UpdateEmployee : Form
    {
        Messages msg = new Messages();
        public string idUpdater;
        public UpdateEmployee()
        {
            InitializeComponent();
        }


        public UpdateEmployee(string name, string gender, Int64 mobile, string addres, string depart, string designation,
            int salary, Image image, string email, string updater)
        {
            InitializeComponent();
            var query = new GeneralQuery();
            query.BindComboValue("bindDeparts", empDeparts);
            query.BindComboValue("getLevelsName", empDestination);
            empName.Text = name;
            this.empGender.SelectedItem = gender;
            empNumber.Text = mobile.ToString();
            empAddress.Text = addres.ToString();
            empDeparts.SelectedItem = depart;
            empDestination.SelectedItem = designation.ToString();
            empSalary.Text = salary.ToString();
            empPhoto.Image = image;
            empEmail.Text = email;
            idUpdater = updater;
        }

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void empGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private bool HasCharacters(string text)
        {
            for (int i = 2; i < text.Length - 1; i++)
            {
                if (char.IsLetter(text[i]))
                {

                    return true;

                }
            }
            return false;
        }

        private void CheckAndSave()
        {
            try
            {
                if (Validations.validateAllBlanks(empName, empNumber,
           empAddress, empEmail, empSalary))
                    msg.ShowError("Blank Fields Can't be Updated.", "Error");

                else if (Validations.ComboNotSelectedValue("Select", empGender))
                    msg.ShowError("Select Gender", "Error");
                else if (Validations.ComboNotSelectedValue("Select", empDeparts))
                    msg.ShowError("We Can't Update Unknown DepartName ['Select']. Select Valid DepartName", "Error");

                else if (Validations.ComboNotSelectedValue("Select", empDestination))
                    msg.ShowError("We Can't Update Unknown Employee Level ['Select']. Select Valid Designation", "Error");
                else if (Validations.ImageNotSelected(empPhoto))
                    msg.ShowError("Employee Image Can't be Null....", "Error");
                else
                {


                    if (!Validations.HasValidName(empName.Text))
                    {
                        msg.ShowError("Employee Name Must Be VALID Charaters Value Values");
                        return;
                    }

                    if (empName.Text.Length < 3)
                    {
                        msg.ShowError("Employee Name Must Be Valid FullName");
                        return;
                    }
                    Int64 temp;
                    Int64 phone;
                    if (Int64.TryParse(empNumber.Text, out phone))
                    {

                        if (Validations.isValidMobile(empNumber.Text))
                        {
                            if (Validations.isValidLength(empNumber.Text))
                            {
                                phone = Int64.Parse(empNumber.Text);
                                if (Validations.IsValidEmail(empEmail.Text))
                                {
                                    if (Int64.TryParse(empSalary.Text, out temp))
                                    {
                                        int temp_salary = int.Parse(empSalary.Text);
                                        if (Validations.MinMaxchecker(temp_salary, 150, 5000))
                                            ExecuteQuery();

                                        else
                                            msg.ShowError("Salary out Of Posible Range Values,\nSalary Must Betweeen 150 and 5000", "Error | Salary");
                                    }
                                    else
                                        msg.ShowError("Salary  Conatins Characetrs, Salary Must be Valid Numeric Value .....", "Error | HIMILO TECHNOLOGIES CENTER");
                                }
                                else
                                    msg.ShowError($"{empEmail.Text} is not a Correct Format Email, Provide Correct Email\nExample: someOne@gmail.com", "Error");
                            }
                            else
                                msg.ShowError($"Mobile Length Must Be 12 Digits or 13 Digits", "Error");


                        }
                        else
                            msg.ShowError("Mobile Number Must Start Local Code Number [ 252 ] ", "Error");
                    }
                    else
                        msg.ShowError("You Can't Update This Mobile Number It Contains Some Characetrs..\nPlz Update Valid Mobile Number With Valid Numeric Value", "Error");

                }
            }
            catch (Exception ex)
            {
                msg.ShowError(ex.Message, "Error");
            }
        }

        private void SaveChanges(object sender, EventArgs e)
        {
            CheckAndSave();
        }


        public void ExecuteQuery()
        {
            try
            {
                var employee = new Controlers.Employee()
                {

                    employeeName = empName.Text,
                    mobile = Int64.Parse(empNumber.Text),

                    gender = empGender.Text,
                    designation = empDestination.Text,
                    salary = int.Parse(empSalary.Text),
                    location = empAddress.Text,
                    departmentname = empDeparts.Text,
                    email = empEmail.Text,
                    EmployeeImage = empPhoto.Image,
                    employeeIDUpdater = idUpdater

                };


                employee.UpdateEmployee();
                if (employee.QueryHasError)
                    msg.ShowError("Something Went Wriong...\n" + employee.ErrorMessage, "Error");
                else
                {
                    msg.ShowInfo($"Employee {empName.Text} Sucessfully Updated....", "Commits");
                    var query = new GeneralQuery();
                    EmployeeFrontEnd.data.DataSource = query.GetData("getEmpData");
                    EmployeeFrontEnd.dataBonusAndDeductions.DataSource = query.GetData("getDeductions");

                    this.Close();


                }
            }
            catch (Exception ex)
            {
                msg.ShowError(ex.Message, "Error");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void empPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (openEmpImage.ShowDialog() == DialogResult.OK)
                {
                    empPhoto.Image = Image.FromFile(openEmpImage.FileName);
                }
            }
            catch (Exception ex)
            {
                msg.ShowError(ex.Message, "Error");
            }
        }
    }
}

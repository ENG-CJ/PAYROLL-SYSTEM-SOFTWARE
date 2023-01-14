using HIMILO_ICT_PAYROLL_SYSTEM.FrontEnd.User_Controlers;
using System;
using System.Windows.Forms;
namespace HIMILO_ICT_PAYROLL_SYSTEM.FrontEnd.Forms
{
    public partial class UpdateDepartments : Form
    {
        public int DepartmentUpdater { get; set; }
        public UpdateDepartments(int id, string name, int updater)
        {
            InitializeComponent();
            departID.Text = id.ToString();
            deprtname.Text = name.ToString();
            this.DepartmentUpdater = updater;
        }

        private void CloseWindoiw(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveChanges(object sender, EventArgs e)
        {
            MessagesDLL.Messages msg = new MessagesDLL.Messages();
            if (Validations.validateAllBlanks(departID, deprtname))
                msg.ShowError("DepartID and DepartName is Required....", "Error | Blank");
            else if (Validations.HasCharacters(this.departID.Text))
            {
                msg.ShowError("Department ID Conatins Characters Remove And Continue.....", "Error");
                OneControl.ClearControles(departID);
            }
            else if (!Validations.HasValidName(deprtname.Text))
            {
                msg.ShowError("DepartmentName Conatins Numeric Values Remove And Continue.....", "Error");
                OneControl.ClearControles(deprtname);
            }
            else
            {
                try
                {
                    // checking if the depart is exist
                    var departmemt = new Controlers.Departs()
                    {
                        DepartmentId = int.Parse(departID.Text),
                        DepartmentName = deprtname.Text,
                        Updater = DepartmentUpdater

                    };
                    departmemt.UpdateDepartment();

                    if (departmemt.QueryHasError)
                        msg.ShowError($"Something Went Wrong Plz Fix That Error\nError Message:\n{departmemt.ErrorMessage}");
                    else
                    {
                        msg.ShowInfo("Departmemt Was Succesfully Updated....", "HMILO ICT CENTER | UPDATING");
                        GeneralQuery query = new GeneralQuery();
                        FrontEnd.User_Controlers.DepartmentsFrontEnd.dgv.DataSource = query.GetData("getDepartData");
                        OneControl.ClearControles(departID, deprtname);
                        User_Controlers.DepartmentsFrontEnd.deletbutton.Enabled = false;
                        User_Controlers.DepartmentsFrontEnd.deletbutton.Enabled = false;

                        query.BindComboValue("bindDeparts", EmployeeRegistration.departCombo);
                        EmployeeRegistration.departCombo.Items.Add("Select");
                        EmployeeRegistration.departCombo.SelectedItem = "Select";

                        query.BindComboValue("bindDeparts", EmployeeFrontEnd.filter);
                        EmployeeFrontEnd.filter.Items.Add("Employee(All)");
                        EmployeeFrontEnd.filter.SelectedItem = "Employee(All)";

                        query.BindComboValue("bindDeparts", ReportFrontEnd.combo);
                        ReportFrontEnd.combo.SelectedIndex = 0;

                        query.BindComboValue("bindDeparts", EmployeeAttendance.depatcom);
                        EmployeeAttendance.depatcom.Items.Add("Departments (All)");
                        EmployeeAttendance.depatcom.SelectedItem = "Departments (All)";
                        query.BindComboValue("bindDeparts", Payroll.comboBox);
                        Payroll.comboBox.Items.Add("Departments (All)");
                        Payroll.comboBox.SelectedItem = "Departments (All)";


                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    msg.ShowError(ex.Message, "Error");
                    OneControl.ClearControles(deprtname, departID);

                }


            }

        }

    }
}

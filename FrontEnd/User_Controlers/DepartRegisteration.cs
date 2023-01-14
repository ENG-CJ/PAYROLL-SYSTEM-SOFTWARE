using HIMILO_ICT_PAYROLL_SYSTEM.Controlers;
using MessagesDLL;
using System;
using System.Windows.Forms;

namespace HIMILO_ICT_PAYROLL_SYSTEM.FrontEnd.User_Controlers
{
    public partial class DepartRegisteration : UserControl
    {

        public static string buttontext = "Save";
        Messages messages = new Messages();
        public DepartRegisteration()
        {


            InitializeComponent();
            this.departButtonControler.Text = buttontext;

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DepartRegisteration_Load(object sender, System.EventArgs e)
        {
            this.departButtonControler.Text = buttontext;
        }

        private void SaveDepartMent(object sender, System.EventArgs e)
        {
            if (Validations.validateAllBlanks(departmentID, departmentName))
                messages.ShowError("All Fields Are required", "Error");
            else if (Validations.HasCharacters(this.departmentID.Text))
            {
                messages.ShowError("Department ID Conatins Characters Remove And Continue.....", "Error");
                OneControl.ClearControles(departmentID);
            }
            else if (!Validations.HasValidName(departmentName.Text))
            {
                messages.ShowError("DepartmentName Conatins Numeric Values Remove And Continue.....", "Error");
                OneControl.ClearControles(departmentName);
            }
            else if (Validations.isExistDepartment(departmentName.Text))
            {
                messages.ShowError("This Department Already Exist, Add new One Or Remove This Exist Department And Re-Register", "Error");
                OneControl.ClearControles(departmentName);
            }


            else
            {

                try
                {
                    Departs Departs = new Departs()
                    {
                        DepartmentId = int.Parse(departmentID.Text),
                        DepartmentName = departmentName.Text
                    };

                    Departs.AddDepartment();
                    if (Departs.QueryHasError)
                        messages.ShowError($"Something Went Wrong\n\n{Departs.ErrorMessage}", "Error");
                    else
                    {
                        messages.ShowInfo($"{departmentName.Text} Has Been Successfully Created....", "Commits");

                        DepartmentsFrontEnd.addbutton.Enabled = true;

                        OneControl.ClearControles(departmentID, departmentName);
                        GeneralQuery query = new GeneralQuery();
                        DepartmentsFrontEnd.dgv.DataSource = query.GetData("getDepartData");
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
                        this.Hide();
                        var gen = new GeneralQuery();
                        gen.CountData("countDeparts", DashControelr.allDeparts);
                        OneControl.ClearControles(departmentID, departmentName);


                    }
                }
                catch (Exception ex)
                {
                    messages.ShowError(ex.Message, "Error");
                    OneControl.ClearControles(departmentID, departmentName);
                }

            }
        }

        private void cLOSE(object sender, System.EventArgs e)
        {
            DepartmentsFrontEnd.addbutton.Enabled = true;
            DepartmentsFrontEnd.deletbutton.Enabled = true;
            DepartmentsFrontEnd.updatebutton.Enabled = true;

            this.Hide();
        }
    }
}

using Guna.UI2.WinForms;
using MessagesDLL;
using System;
using System.Windows.Forms;

namespace HIMILO_ICT_PAYROLL_SYSTEM.FrontEnd.User_Controlers
{
    public partial class DepartmentsFrontEnd : UserControl
    {
        Messages message = new Messages();
        public int DeparID { get; set; }
        public string DeparName { get; set; }
        public int id { get; set; }


        public int idDesignation;
        public string name;
        public static Guna2DataGridView dgv = new Guna2DataGridView();
        public static Guna2DataGridView designationdgv = new Guna2DataGridView();
        public static Guna2Button addbutton = new Guna2Button();
        public static Guna2Button deletbutton = new Guna2Button();
        public static Guna2Button updatebutton = new Guna2Button();
        public DepartmentsFrontEnd()
        {
            InitializeComponent();
            dgv = departmentsData;
            designationdgv = designationData;

            addbutton = addBtn;
            deletbutton = deleteBtn;
            updatebutton = updateBtn;
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddDepart(object sender, EventArgs e)
        {
            this.addBtn.Enabled = false;
            this.deleteBtn.Enabled = false;
            this.updateBtn.Enabled = false;
            this.departRegisteration2.Show();
        }

        private void UpdateDepart(object sender, EventArgs e)
        {
            if (DeparID == 0)
                message.ShowError("To Update a Record, Plz First The Record You want To Update", "Error | Updating");
            else
            {
                Form backDrop = BackDrop.backDrop(.61d);
                backDrop.Show();
                var department_updater = new FrontEnd.Forms.UpdateDepartments(DeparID, DeparName, id);
                department_updater.Owner = backDrop;
                department_updater.ShowDialog();

                backDrop.Dispose();
                DeparID = 0;
            }




        }

        private void departmentsData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DepartmentsFrontEnd_Load(object sender, EventArgs e)
        {
            GeneralQuery query = new GeneralQuery();
            departmentsData.DataSource = query.GetData("getDepartData");
            designationData.DataSource = query.GetData("getDesignation");

            updateBtn.Enabled = false;
            deleteBtn.Enabled = false;
            deldes.Enabled = false;
            upadteDes.Enabled = false;
        }

        private void DeleteDepartment(object sender, EventArgs e)
        {
            if (DeparID == 0)
                message.ShowError("Select  Record you went to Remove ", "Error");
            else
            {
                var result = message.ShowWarning("Are You Sure To Remove This Record", "Confirmation");
                if (result == DialogResult.No)
                    return;
                else
                {

                    Controlers.Departs query = new Controlers.Departs();
                    query.DeleteDepartment(DeparID);

                    if (query.QueryHasError)

                        message.ShowError("Error Occured:  \n" + query.ErrorMessage, "Error");

                    else if (query.__HasRows)

                        message.ShowError(query.messageQuery, "Error");

                    else
                    {
                        message.ShowInfo("Record Was Successfully Removed... ", "Commits | Deletion");
                        GeneralQuery query_ = new GeneralQuery();
                        departmentsData.DataSource = query_.GetData("getDepartData");
                        deleteBtn.Enabled = false;
                        updateBtn.Enabled = false;
                        var gen = new GeneralQuery();
                        gen.CountData("countDeparts", DashControelr.allDeparts);

                        query_.BindComboValue("bindDeparts", EmployeeRegistration.departCombo);
                        EmployeeRegistration.departCombo.Items.Add("Select");
                        EmployeeRegistration.departCombo.SelectedItem = "Select";

                        query_.BindComboValue("bindDeparts", EmployeeFrontEnd.filter);
                        EmployeeFrontEnd.filter.Items.Add("Employee(All)");
                        EmployeeFrontEnd.filter.SelectedItem = "Employee(All)";

                        query_.BindComboValue("bindDeparts", ReportFrontEnd.combo);
                        ReportFrontEnd.combo.SelectedIndex = 0;

                        query_.BindComboValue("bindDeparts", EmployeeAttendance.depatcom);
                        EmployeeAttendance.depatcom.Items.Add("Departments (All)");
                        EmployeeAttendance.depatcom.SelectedItem = "Departments (All)";
                        query_.BindComboValue("bindDeparts", Payroll.comboBox);
                        Payroll.comboBox.Items.Add("Departments (All)");
                        Payroll.comboBox.SelectedItem = "Departments (All)";


                        DeparID = 0;
                    }

                }



            }

        }

        private void GetDepartmentData(object sender, DataGridViewCellEventArgs e)
        {
            updateBtn.Enabled = true;
            deleteBtn.Enabled = true;
            DeparID = (int)departmentsData.SelectedRows[0].Cells[0].Value;
            DeparName = departmentsData.SelectedRows[0].Cells[1].Value.ToString();
            id = (int)departmentsData.SelectedRows[0].Cells[0].Value;

        }

        private void SearchDepartmnt(object sender, EventArgs e)
        {
            pictureNoDataFound.Visible = false;
            labelNoDataFound.Visible = false;
            departmentsData.Visible = true;
            var query = new GeneralQuery();
            var depatData = query.search("searchdepart", "@name", saechDepartment.Text);
            if (depatData.Rows.Count > 0)
            {
                pictureNoDataFound.Visible = false;
                labelNoDataFound.Visible = false;

                departmentsData.DataSource = depatData;
                departmentsData.Visible = true;
            }
            else
            {
                pictureNoDataFound.Visible = true;
                labelNoDataFound.Visible = true;
                departmentsData.Visible = false;
            }
        }

        private void BonusBtnControl_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bottonPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddDesignation(object sender, EventArgs e)
        {

            var form = new Forms.Designation();
            var back = BackDrop.backDrop(.60d);
            back.Show();

            form.Owner = back;
            form.ShowDialog();

            back.Dispose();
        }

        private void UpdateDesignation(object sender, EventArgs e)
        {
            if (idDesignation == 0)
            {
                message.ShowError("Select Record You Want To Update..", "Error");
                return;
            }
            var form = new Forms.Designation(idDesignation, name, "Update");
            var back = BackDrop.backDrop(.60d);
            back.Show();

            form.Owner = back;
            form.ShowDialog();
            idDesignation = 0;
            back.Dispose();
        }

        private void GetDesignationData(object sender, DataGridViewCellEventArgs e)
        {
            deldes.Enabled = true;
            upadteDes.Enabled = true;
            idDesignation = (int)(designationData.SelectedRows[0].Cells[0].Value);
            name = (string)(designationData.SelectedRows[0].Cells[1].Value);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            GeneralQuery query = new GeneralQuery();

            designationData.DataSource = query.GetData("getDesignation");
        }

        private void Delete(object sender, EventArgs e)
        {
            if (idDesignation == 0)
            {
                message.ShowError("Select Record You Want To Remove..", "Error");
                return;
            }
            var result = message.ShowWarning("Are You Sure To Remove This Record? Press Yes To Continue...", "Confirmation");
            if (result == DialogResult.No)
                return;
            else
            {
                var query = new GeneralQuery();
                query.Delete("deleteDesignation", "@id", idDesignation);
                if (query.QueryHasError)
                    message.ShowError("Error Occured.." + query.ErrorMessage, "Error");
                else
                {
                    message.ShowInfo("Designation Has Been Successfully removed...", "Commits");
                    designationData.DataSource = query.GetData("getDesignation");
                    idDesignation = 0;
                }
            }
        }

        private void OpenExcelFile(object sender, EventArgs e)
        {

        }

        private void refereshIcon_Click(object sender, EventArgs e)
        {
            var query = new GeneralQuery();
            departmentsData.DataSource = query.GetData("getDepartData");
        }

        private void ShowTop(object sender, EventArgs e)
        {
            var query = new GeneralQuery();
            if (guna2ComboBox1.Text == "All")
            {
                departmentsData.DataSource = query.GetData("getDepartData");
                return;
            }

            departmentsData.DataSource = query.showTopNumber("showTop", "@top", int.Parse(guna2ComboBox1.Text));
        }
    }
}

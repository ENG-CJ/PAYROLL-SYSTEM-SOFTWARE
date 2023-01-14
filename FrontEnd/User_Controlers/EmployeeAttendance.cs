using Guna.UI2.WinForms;
using MessagesDLL;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace HIMILO_ICT_PAYROLL_SYSTEM.FrontEnd.User_Controlers
{
    public partial class EmployeeAttendance : UserControl
    {
        Messages msg = new Messages();
        public static Guna2ComboBox depatcom = new Guna2ComboBox();
        public EmployeeAttendance()
        {
            InitializeComponent();

        }

        private void EmployeeAttendance_Load(object sender, EventArgs e)
        {

            depatcom = filterDepart;
            var query = new GeneralQuery();
            query.BindComboValue("bindDeparts", filterDepart);
            filterDepart.Items.Add("Departments (All)");
            filterDepart.SelectedItem = "Departments (All)";
            employeeAttendanceData.DataSource = query.GetData("readAndDiplayEmployee");
            //       viewAttendanceData.DataSource = query.GetData("viewAttendance");

            employeeAttendanceData.Columns[0].ReadOnly = true;
            employeeAttendanceData.Columns[1].ReadOnly = true;
            employeeAttendanceData.Columns[2].ReadOnly = true;

            DataGridViewCheckBoxColumn ch = new DataGridViewCheckBoxColumn();

            ch.HeaderText = "Status";
            ch.Visible = true;

            employeeAttendanceData.Columns.Insert(3, ch);
            ch.DisplayIndex = 3;

            var att = new Controlers.Attendance();
            ViewAttendanceData.dataview.DataSource = att.showTopNumber(int.Parse(showTop.Text));

            //MessageBox.Show(employeeAttendanceData.Columns[0].ReadOnly.ToString() + " " +
            //      employeeAttendanceData.Columns[0].HeaderText);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void TakeAttendanxce(object sender, EventArgs e)
        {
            var attendance = new Controlers.Attendance();
            if(!Validations.isCurrentMonth(attendanceDatteTaker.Value))
                msg.ShowError("Only You Can Take Attendance For The Current Date.....", "Error");
           else  if (attendance.isTooked(attendanceDatteTaker.Value))
                msg.ShowError("Attendance Related This Date Has Already Been Tooked......", "Error");
            else
            {
                var result = msg.ShowWarning("NOTE:\nYou Can Take Attendance Once At a Time If You Take This Attendance\n" +
                    " You Can't Update Or  You Can't Delete Plz Make Sure Before Taking.....\nDo You Want To Continue?", "Warning");

                if (result == DialogResult.No)
                    return;
                else
                {
                    await Progress();
                    TakeAttendanceAsyc();
                    // viewAttendanceData.DataSource = query.GetData("viewAttendance");
                }
            }
        }

        private void MarkedAll(object sender, EventArgs e)
        {


            if (this.markAllAttendance.Checked)
            {
                for (int i = 0; i < employeeAttendanceData.RowCount; i++)
                    employeeAttendanceData.Rows[i].Cells[0].Value = true;


                return;
            }
            for (int i = 0; i < employeeAttendanceData.RowCount; i++)
                employeeAttendanceData.Rows[i].Cells[0].Value = false;
        }

        private void employeeAttendanceData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FilterByDepart(object sender, EventArgs e)
        {
            var query = new GeneralQuery();
            if (viewAttendanceData1.Visible)
            {
                ViewAttendanceData.dataview.Visible = true;
                ViewAttendanceData.img.Visible = false;
                if (filterDepart.Text == "Departments (All)")
                {
                    ViewAttendanceData.img.Visible = false;
                    ViewAttendanceData.dataview.DataSource = query.GetData("viewAttendance");
                }
                else
                {
                    var att = new Controlers.Attendance();

                    var data = att.filterDepartment(this.filterDepart.Text);
                    if (data.Rows.Count > 0)
                    {
                        ViewAttendanceData.dataview.Visible = true;
                        ViewAttendanceData.dataview.DataSource = data;
                        ViewAttendanceData.img.Visible = false;

                    }
                    else
                    {
                        ViewAttendanceData.dataview.Visible = false;

                        ViewAttendanceData.img.Visible = true;
                    }
                }
            }
            else
            {
                employeeAttendanceData.Visible = true;
                pictureNoDataFound.Visible = false;
                if (filterDepart.Text == "Departments (All)")
                {
                    pictureNoDataFound.Visible = false;
                    employeeAttendanceData.DataSource = query.GetData("readAndDiplayEmployee");
                }
                else
                {
                    var att = new Controlers.Attendance();
                    var data = att.filterDepartments(this.filterDepart.Text);
                    if (data.Rows.Count > 0)
                    {
                        pictureNoDataFound.Visible = false
                             ;
                        employeeAttendanceData.Visible = true;
                        employeeAttendanceData.DataSource = data;
                    }
                    else
                    {
                        pictureNoDataFound.Visible = true
                           ;
                        employeeAttendanceData.Visible = false;


                    }

                }
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewAttendance(object sender, EventArgs e)
        {
            if (veiwBtn.Text == "View")
            {
                OneControl.ClearControles(markAllAttendance);
                viewAttendanceData1.Visible = true;
                markAllAttendance.Enabled = false;
                saveBtn.Enabled = false;
                showTop.Enabled = true;
                veiwBtn.Text = "Close";
                refereshIcon.Enabled = true;
            }
            else if (veiwBtn.Text == "Close")
            {
                viewAttendanceData1.Visible = false;
                markAllAttendance.Enabled = true;
                saveBtn.Enabled = true;
                veiwBtn.Text = "View";
                showTop.Enabled = false;
                refereshIcon.Enabled = false;
            }
        }

        private void FilterByDate(object sender, EventArgs e)
        {
            if (viewAttendanceData1.Visible)
            {
                ViewAttendanceData.dataview.Visible = true;
                var query = new GeneralQuery();
                var att = new Controlers.Attendance();
                var data = att.filterDateAttendance(this.attendanceDatteTaker.Value);
                if (data.Rows.Count > 0)
                {

                    ViewAttendanceData.img.Visible = false;
                    ViewAttendanceData.dataview.Visible = true;
                    ViewAttendanceData.dataview.DataSource = data;
                }
                else
                {
                    ViewAttendanceData.img.Visible = true;
                    ViewAttendanceData.dataview.Visible = false;
                    //ViewAttendanceData.dataview.Visible = false;
                    //noemployeeAttendance.Visible = true;
                }

            }
            else
                return;
        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShowTop(object sender, EventArgs e)
        {
            var query = new GeneralQuery();
            if (showTop.Text == "All")
                ViewAttendanceData.dataview.DataSource = query.GetData("viewAttendance");
            else
            {

                var att = new Controlers.Attendance();
                ViewAttendanceData.dataview.DataSource = att.showTopNumber(int.Parse(showTop.Text));


            }
        }


        private async Task Progress()
        {
            progressIndicator.Visible = true;
            await Task.Run(async () =>
            {
                for (int i = 1; i <= 100; i++)
                {
                    progressIndicator.Value = i;
                    await Task.Delay(10);
                }
                progressIndicator.Visible = false;
                progressIndicator.Value = 0;
            });
        }

        private async void TakeAttendanceAsyc()
        {

            await Task.Run(() =>
            {
                var attendance = new Controlers.Attendance();
                for (int i = 0; i < employeeAttendanceData.RowCount; i++)
                {
                    string state;
                    bool staus = Convert.ToBoolean(employeeAttendanceData.Rows[i].Cells[0].Value);
                    if (staus)
                        state = "Present";
                    else
                        state = "Absent";
                    attendance.takeAttendance(
                       employeeAttendanceData.Rows[i].Cells[1].Value.ToString(),
                       state,
                       attendanceDatteTaker.Value

                        );
                    if (attendance.QueryHasError)
                    {
                        msg.ShowError($"Error Occured...\n\n{attendance.ErrorMessage}", "Errpr");
                        return;
                    }


                }
                msg.ShowInfo("Attendance Data Has been Successfully Taking...", "Commits");

            });
            var query = new GeneralQuery();
            employeeAttendanceData.DataSource = query.GetData("readAndDiplayEmployee");
            ViewAttendanceData.dataview.DataSource = query.GetData("viewAttendance");

            OneControl.ClearControles(markAllAttendance);
        }







        // attendance process
        private async Task ThreadProgerss()
        {
            progressIndicator.Visible = true;
            await Task.Run(async () =>
            {
                for (int i = 1; i <= 7; i++)
                {
                    progressIndicator.Value = i;
                    await Task.Delay(80);
                }
                progressIndicator.Visible = false;
                progressIndicator.Value = 0;
            });
        }

        private void refereshIcon_Click(object sender, EventArgs e)
        {
            var query = new GeneralQuery();
            //  employeeAttendanceData.DataSource = query.GetData("readAndDiplayEmployee");
            ViewAttendanceData.dataview.DataSource = query.GetData("viewAttendance");
        }
    }
}

using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;
namespace HIMILO_ICT_PAYROLL_SYSTEM.FrontEnd.User_Controlers
{
    public partial class ViewAttendanceData : UserControl
    {

        public static Guna2DataGridView dataview = new Guna2DataGridView();
        public static PictureBox img = new PictureBox();

        public ViewAttendanceData()
        {
            InitializeComponent();
            dataview = viewAttendaceData;
            img = pictureNoDataFound;


        }

        private void ViewAttendanceData_Load(object sender, EventArgs e)
        {
            var query = new GeneralQuery();
            viewAttendaceData.DataSource = query.GetData("viewAttendance");
            img = pictureNoDataFound;

        }

        private void CloseWindow(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FilterDate(object sender, EventArgs e)
        {

            //var query = new GeneralQuery();
            //var att = new Controlers.Attendance();
            //var data = att.filterDateAttendance(this.attendanceDatteTaker.Value);
            //if (data.Rows.Count > 0)
            //    viewAttendaceData.DataSource = data;
            //else
            //    viewAttendaceData.DataSource = query.GetData("viewAttendance");


        }

        private void FilterDepart(object sender, EventArgs e)
        {
            //var query = new GeneralQuery();
            //if (filterDepart.Text == "Departments (All)")
            //    viewAttendaceData.DataSource = query.GetData("viewAttendance");
            //else
            //{
            //    var att = new Controlers.Attendance();
            //    var data = att.filterDepartment(this.filterDepart.Text);
            //    if (data.Rows.Count > 0)
            //        viewAttendaceData.DataSource = data;
            //    else
            //        viewAttendaceData.DataSource = query.GetData("viewAttendance");

            //}
        }

        private void viewAttendaceData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

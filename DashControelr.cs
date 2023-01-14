using System;
using System.Windows.Forms;

namespace HIMILO_ICT_PAYROLL_SYSTEM
{
    public partial class DashControelr : UserControl
    {


        public static Label totalUsrs = new Label();
        public static Label allDeparts = new Label();
        public static Label allEmp = new Label();
        public static Label salariesPaid = new Label();
        public static Label bonusesPAID = new Label();
        public static Label allpayslips = new Label();
        public DashControelr()
        {
            InitializeComponent();
            totalUsrs = totalUsers;
            allDeparts = totalDeparts;
            allEmp = totalEmpllye;
            salariesPaid = salaryPaid;
            bonusesPAID = bonusPaid;
            allpayslips = totalPayslips;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void disable()
        {

            salaryPaidPanel.Visible = false;
            bonusPaidPanel.Visible = false;
            payslipsPanel.Visible = false;
            panel6_container.Visible = false;
            panel7_container.Visible = false;

            logData.Visible = false;
            latestPayslipPanel.Visible = false;
            lastPayslipData.Visible = false;
            shadowPanel_container.Visible = false;

        }

        private void DashControelr_Load(object sender, EventArgs e)
        {
            if (LOGIN.userRole.ToLower() == "user")
                disable();
            var gen = new GeneralQuery();
            gen.CountData("countUsers", totalUsers);
            gen.CountData("countDeparts", totalDeparts);
            gen.CountData("countemp", totalEmpllye);
            gen.CountData("totalPayroll", totalPayslips);
            gen.countBonusPaid(bonusPaid);
            gen.CountSalaryPaid(salaryPaid);
            // gen.CountData("countUsers", totalUsers);
            logData.DataSource = gen.GetData("readLog");
            lastPayslipData.DataSource = gen.GetData("readLastPayslip");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

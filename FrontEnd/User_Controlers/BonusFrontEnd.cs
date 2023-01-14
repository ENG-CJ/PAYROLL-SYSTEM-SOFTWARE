using Guna.UI2.WinForms;
using HIMILO_ICT_PAYROLL_SYSTEM.FrontEnd.Forms;
using MessagesDLL;
using System;
using System.Windows.Forms;
namespace HIMILO_ICT_PAYROLL_SYSTEM.FrontEnd.User_Controlers
{

    public partial class BonusFrontEnd : UserControl
    {
        Messages message = new Messages();
        public int id;
        public string bonus_name;
        public int bonusAmount;
        public string bonusDescription;
        public static Guna2DataGridView dataview = new Guna2DataGridView();
        public BonusFrontEnd()
        {
            InitializeComponent();
            dataview = bonusdv;


        }

        private void BonusFrontEnd_Load(object sender, EventArgs e)
        {
            GeneralQuery general = new GeneralQuery();
            bonusdv.DataSource = general.GetData("getBonusData");
        }

        private void AddBonus(object sender, EventArgs e)
        {
            Form backDrop = BackDrop.backDrop(.61d);
            backDrop.Show();
            BonusRegistration bonus = new BonusRegistration();
            bonus.Owner = backDrop;
            bonus.ShowDialog();

            backDrop.Dispose();

        }

        private void UpdateBonus(object sender, EventArgs e)
        {
            Form backDrop = BackDrop.backDrop(.58d);
            backDrop.Show();
            BonusRegistration bonus = new BonusRegistration("Update", id, bonus_name, bonusAmount, bonusDescription);
            bonus.Owner = backDrop;
            bonus.ShowDialog();

            backDrop.Dispose();
            guna2Button2.Enabled = false;
            guna2Button3.Enabled = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void delete(object sender, EventArgs e)
        {
            if (id == 0)
                message.ShowError("Select Record You want To Delete", "Error");

            else
            {
                var res = message.ShowWarning($"Are U Sure To Delete The Record That Has an ID {id}? ", "Confirmation");
                if (res == DialogResult.No)
                    return;
                GeneralQuery general = new GeneralQuery();
                general.Delete("deleteBonus", "@id", id);
                message.ShowInfo("Bonus Record Was Successfully Removed...", "Commits");
                id = 0;

                bonusdv.DataSource = general.GetData("getBonusData");
                guna2Button2.Enabled = false;
                guna2Button3.Enabled = false;
            }

        }

        private void getdata(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)bonusdv.SelectedRows[0].Cells[0].Value;
            bonus_name = bonusdv.SelectedRows[0].Cells[1].Value.ToString();
            bonusAmount = (int)bonusdv.SelectedRows[0].Cells[2].Value;
            bonusDescription = bonusdv.SelectedRows[0].Cells[3].Value.ToString();
            guna2Button2.Enabled = true;
            guna2Button3.Enabled = true;


        }

        private void logout_Click(object sender, EventArgs e)
        {

        }

        private void lreload(object sender, EventArgs e)
        {
            GeneralQuery general = new GeneralQuery();
            bonusdv.DataSource = general.GetData("getBonusData");
        }

        private void bonusdv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

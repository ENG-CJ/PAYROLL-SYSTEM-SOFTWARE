using MessagesDLL;
using System;
using System.Windows.Forms;

namespace HIMILO_ICT_PAYROLL_SYSTEM.FrontEnd.Forms
{
    public partial class Designation : Form
    {

        Messages msg = new Messages();
        public int updater;
        public Designation()
        {
            InitializeComponent();
        }


        public Designation(int updater, string name, string btntext)
        {
            InitializeComponent();
            this.updater = updater;
            deprtname.Text = name;
            this.BonusBtnControl.Text = btntext;

        }

        private void Save(object sender, EventArgs e)
        {
            try
            {
                if (BonusBtnControl.Text == "Save")
                {
                    if (deprtname.Text == "")
                        msg.ShowError("Designation Name is required....", "Error");
                    else


                    {
                        if (HasNumeric())
                        {
                            msg.ShowError("Designation Name Contains Numeric Value, Plz Remove Numbers", "Error");
                            return;
                        }

                        Controlers.Departs.DepartmentDesignation dep = new Controlers.Departs.DepartmentDesignation();
                        var isvalid = dep.FindDepart(this.deprtname.Text);
                        if (isvalid)
                            msg.ShowError($"Designation name Cannot Be Duplicate, This level Already Exist Choose Another One..", "Eroor");
                        else
                        {

                            dep.name = deprtname.Text;
                            dep.addDesignation();
                            if (dep.QueryHasError)
                                msg.ShowError("Error Occurs\n" + dep.ErrorMessage, "Error");
                            else
                            {
                                msg.ShowInfo("Level Has Been Saved Successully....", "Commits");
                                GeneralQuery query = new GeneralQuery();
                                FrontEnd.User_Controlers.DepartmentsFrontEnd.designationdgv.DataSource = query.GetData("getDesignation");


                                query.BindComboValue("getLevelsName", EmployeeRegistration.levelCombo);
                                EmployeeRegistration.levelCombo.Items.Add("Select");
                                EmployeeRegistration.levelCombo.SelectedItem = "Select";
                                this.Close();
                            }
                        }
                    }




                }
                else if (BonusBtnControl.Text == "Update")
                {
                    if (deprtname.Text == "")
                        msg.ShowError("Designation Name is REquired....", "Error");
                    else if (HasNumeric())
                    {
                        msg.ShowError("Designation Name Contains Numeric Value, Plz Remove Numbers", "Error");
                        return;
                    }
                    else
                    {
                        Controlers.Departs.DepartmentDesignation dep = new Controlers.Departs.DepartmentDesignation();

                        dep.name = deprtname.Text;
                        dep.updater = updater;
                        dep.updateDesignation();
                        if (dep.QueryHasError)
                            msg.ShowError("Error Occurs\n" + dep.ErrorMessage, "error");
                        else
                        {
                            msg.ShowInfo("Successully Updated....", "Commits");
                            GeneralQuery query = new GeneralQuery();
                            FrontEnd.User_Controlers.DepartmentsFrontEnd.designationdgv.DataSource = query.GetData("getDesignation");
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                msg.ShowError(ex.Message, "Error");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool HasNumeric()
        {
            foreach (char c in deprtname.Text)
            {
                if (char.IsNumber(c))
                    return true;
            }
            return false;
        }
    }
}

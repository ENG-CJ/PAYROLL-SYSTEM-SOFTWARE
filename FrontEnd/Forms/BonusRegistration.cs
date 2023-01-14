using HIMILO_ICT_PAYROLL_SYSTEM.Controlers;
using HIMILO_ICT_PAYROLL_SYSTEM.FrontEnd.User_Controlers;
using MessagesDLL;
using System;
using System.Windows.Forms;

namespace HIMILO_ICT_PAYROLL_SYSTEM.FrontEnd.Forms
{
    public partial class BonusRegistration : Form

    {
        Messages messages = new Messages();
        public int updaterID;

        public BonusRegistration()
        {
            InitializeComponent();
        }

        public BonusRegistration(string buttonText, int id, string name, int amount, string descr)
        {
            InitializeComponent();
            this.BonusBtnControl.Text = buttonText;
            BonusName.Text = name;
            Amount.Text = amount.ToString();
            desc.Text = descr;
            updaterID = id;
        }

        private void ExitWindow(object sender, System.EventArgs e)
        {
            Close();
        }

        private void BonusRegistration_Load(object sender, System.EventArgs e)
        {

        }

        private void save(object sender, System.EventArgs e)
        {

        }

        private void SaveOrEditBonus(object sender, System.EventArgs e)
        {
            try
            {
                if (BonusBtnControl.Text == "Save")
                {

                    if (Validations.validateAllBlanks(BonusName, Amount))
                        messages.ShowError("All Fields Are required", "Error");
                    else if (Validations.HasCharacters(Amount.Text))
                    {
                        messages.ShowError("Bonus Percentage Allowed Only Numeric Values.....", "Error");
                        OneControl.ClearControles(Amount);
                    }
                    else if (!Validations.HasValidName(BonusName.Text))
                    {
                        messages.ShowError("Bonus Name Conatins Numeric Values Remove And Continue.....", "Error");
                        OneControl.ClearControles(BonusName);
                    }

                    else
                    {
                        int amount = int.Parse(Amount.Text);
                        if (amount >= 10 && amount <= 45)
                        {
                            Bonus bonus = new Bonus()
                            {
                                bonusName = BonusName.Text,
                                amount = amount,
                                description = desc.Text
                            };
                            bonus.addBonus();
                            if (bonus.QueryHasError)
                                messages.ShowError($"Something Went Wrong\n\n{bonus.ErrorMessage}", "Error");
                            else
                            {
                                messages.ShowInfo($"[{BonusName.Text}]  Successfully Saved....", "Commits");
                                GeneralQuery query = new GeneralQuery();
                                var data = query.GetData("getBonusData");
                                BonusFrontEnd.dataview.DataSource = data;
                                this.Close();

                                //   UsersFrontEnd.dataGridView.DataSource = data;
                            }
                        }
                        else
                            messages.ShowError("Bonus Precentage Must Between 10% and 45%", "Error | Bonus Precentage");


                    }
                }
                else if (BonusBtnControl.Text == "Update")
                {

                    if (Validations.validateAllBlanks(BonusName, Amount))
                        messages.ShowError("All Fields Are required", "Error");
                    else if (Validations.HasCharacters(Amount.Text))
                    {
                        messages.ShowError("Bonus Percentage Allowed Only Numeric Values.....", "Error");
                        OneControl.ClearControles(Amount);
                    }
                    else if (!Validations.HasValidName(BonusName.Text))
                    {
                        messages.ShowError("Bonus Name Conatins Numeric Values Remove And Continue.....", "Error");
                        OneControl.ClearControles(BonusName);
                    }
                    else
                    {
                        int amount = int.Parse(Amount.Text);
                        if (amount >= 10 && amount <= 45)
                        {
                            Bonus bonus = new Bonus()
                            {
                                bonusName = BonusName.Text,
                                amount = amount,
                                description = desc.Text,
                                bonusIDUpdater = updaterID
                            };
                            bonus.updatedbonus();
                            if (bonus.QueryHasError)
                                messages.ShowError($"Something Went Wrong\n\n{bonus.ErrorMessage}", "Error");
                            else
                            {
                                messages.ShowInfo($"Bonus [{BonusName.Text}] Successfully Updated....", "Commits");
                                GeneralQuery query = new GeneralQuery();
                                var data = query.GetData("getBonusData");
                                BonusFrontEnd.dataview.DataSource = data;
                                this.Close();
                                //   UsersFrontEnd.dataGridView.DataSource = data;
                            }
                        }
                        else
                            messages.ShowError("Bonus Precentage Must Between 10% and 45%", "Error | Bonus Precentage");


                    }
                }
            }
            catch (Exception ex)
            {
                messages.ShowError(ex.Message, "Error");
            }
        }

        private void Amount_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}


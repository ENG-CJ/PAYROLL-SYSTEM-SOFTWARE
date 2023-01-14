using Guna.UI2.AnimatorNS;
using System.Windows.Forms;

namespace HIMILO_ICT_PAYROLL_SYSTEM
{
    internal class OneControl
    {
        public static void HideVisibility(params Control[] controls)
        {
            foreach (Control control in controls)
                control.Visible = false;
        }


        public static void ShowControl(Control control, bool animated = false, AnimationType animationType = AnimationType.Custom)
        {
            if (animated)
            {
                Guna.UI2.WinForms.Guna2Transition transition = new Guna.UI2.WinForms.Guna2Transition();
                transition.AnimationType = animationType;
                transition.Interval = 10;
                transition.ShowSync(control);
            }
            else
                control.Show();

        }


        public static void ShowControlOutAnimate(Control control)
        {

            control.Show();

        }

        public static void HideControlOuAnimate(params Control[] controls)
        {

            foreach (Control control in controls)
                control.Hide();



        }
        public static void HideControl(bool animated = false, AnimationType animationType = AnimationType.Custom, params Control[] controls)
        {
            Guna.UI2.WinForms.Guna2Transition transition = new Guna.UI2.WinForms.Guna2Transition();
            transition.AnimationType = animationType;
            transition.Interval = 10;



            if (animated)
            {
                foreach (Control control in controls)
                    transition.HideSync(control);

            }
            else
            {
                foreach (Control control in controls)
                    control.Hide();
            }

        }

        public static void Enable(params Guna.UI2.WinForms.Guna2DateTimePicker[] date)
        {
            foreach (Guna.UI2.WinForms.Guna2DateTimePicker picker in date)
                picker.Enabled = true;
        }

        public static void DisAble(params Guna.UI2.WinForms.Guna2DateTimePicker[] date)
        {
            foreach (Guna.UI2.WinForms.Guna2DateTimePicker picker in date)
                picker.Enabled = false;
        }

        public static void ClearControles(params Guna.UI2.WinForms.Guna2TextBox[] textBoxes)
        {
            foreach (var control in textBoxes)
                control.Clear();
        }



        public static void ClearControles(params Guna.UI2.WinForms.Guna2CheckBox[] textBoxes)
        {
            foreach (var control in textBoxes)
                control.Checked = false;
        }

        public static void ClearControles(string selectedItem, params Guna.UI2.WinForms.Guna2ComboBox[] comboBoxes)
        {
            foreach (var control in comboBoxes)
                control.SelectedItem = selectedItem;
        }
        public static void ClearImages(Panel coverPhoto = null, Label label = null, params PictureBox[] pictureBoxes)
        {
            foreach (var pictureBox in pictureBoxes)
            {
                if (coverPhoto != null && label != null)
                {
                    pictureBox.Image = null;

                    coverPhoto.BringToFront();
                    label.BringToFront();
                    return;
                }

                pictureBox.Image = null;

            }
        }


        public static string FormattingNumber(int number)
        {
            if (number >= 100000000)
                return (number / 1000000D).ToString("0.#M");
            if (number >= 1000000)
                return (number / 1000000D).ToString("0.##M");
            if (number >= 100000)
                return (number / 1000).ToString("0.#K");
            if (number >= 10000)
                return (number / 1000D).ToString("0.##k");


            return number.ToString("0.#");

        }
    }
}

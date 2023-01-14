using System.Drawing;
using System.Windows.Forms;
namespace HIMILO_ICT_PAYROLL_SYSTEM.FrontEnd.User_Controlers
{
    internal class BackDrop
    {

        public static Form backDrop(double opacity = .70d)
        {

            var form = new Form();
            form.FormBorderStyle = FormBorderStyle.None;
            form.ShowInTaskbar = false;
            form.StartPosition = FormStartPosition.Manual;
            form.TopMost = true;
            form.BackColor = Color.Black;
            form.Opacity = opacity;
            form.WindowState = FormWindowState.Maximized;





            return form;
        }
    }
}
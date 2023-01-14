using System;
using System.Windows.Forms;
namespace HIMILO_ICT_PAYROLL_SYSTEM
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {



            if (Properties.Settings.Default.isConfigured)
            {
                if (Properties.Settings.Default.Verified)
                {
                    if (Properties.Settings.Default.isChecked)
                    {
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        Application.Run(new LOGIN());
                    }
                    else
                    {
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        Application.Run(new Form2());
                    }

                }
                else
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new ProductkeySender());
                }
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new configure());
            }
        }
    }
}

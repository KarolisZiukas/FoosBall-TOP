using System;
using System.Windows.Forms;

namespace RedBallTracker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IntroductionForm formObject = new IntroductionForm();

            Application.Run(formObject);

            if(formObject.GetFirstPlayerName() != string.Empty)
            {
                Application.Run(new frmMain());
            }














            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmMain());
        }
    }
}

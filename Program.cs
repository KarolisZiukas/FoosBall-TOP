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


            IntroductionForms objectForm = new IntroductionForms();

            Application.Run(new IntroductionForms());
            //if(objectForm.GetFirstPlayerName() != "" && objectForm.GetSecondPlayerName() != "")
            //{
                //objectForm.Hide();
                Application.Run(new frmMain());
            //}










        }
    }
}

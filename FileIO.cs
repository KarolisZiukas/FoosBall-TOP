using System;
using System.IO;
using System.Windows.Forms;

namespace RedBallTracker
{
    class FileIO
    {


        private static string FILE_DIR = "..\\projectFiles\\Scores.txt";

        public FileIO()
        {

        }
    //TODO Karolis Generic type
    public void writeToFile<T1, T2>(T1 redTeam, T2 blueTeam)
        {
            try
            {

                using (StreamWriter sw = File.AppendText(FILE_DIR))
                {
                    sw.Write(redTeam + " ");
                    sw.Write(blueTeam);
                    sw.WriteLine();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(Strings.ErrorToFile);
                Environment.Exit(0);
            }
        }

        public string readFromFile()
        {
            try {
                return File.ReadAllText(FILE_DIR);
            }
            catch(Exception ex)
            {
                MessageBox.Show(Strings.ErrorFromFile);
                return string.Empty;
            }
            }



    }
}

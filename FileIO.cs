using System.IO;
namespace RedBallTracker
{
    class FileIO
    {


        private static string FILE_DIR = "C:\\FoosballGeneral\\Res\\Scores.txt";

        public FileIO()
        {

        }

    public void writeToFile(int redTeam, int blueTeam)
        {

            using (StreamWriter sw = File.AppendText(FILE_DIR))
            {
                sw.Write(redTeam);
                sw.Write(" ");
                sw.Write(blueTeam);
                sw.WriteLine();
            }
        }

    public string readFromFile()
        {
            return File.ReadAllText(FILE_DIR);
        }

    }
}

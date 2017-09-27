using System.IO;
namespace RedBallTracker
{
    class FileIO
    {


        private static string FILE_DIR = "..\\projectFiles\\Scores.txt";

        public FileIO()
        {

        }
    //Generic type
    public void writeToFile<T1, T2>(T1 redTeam, T2 blueTeam)
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

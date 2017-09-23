using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace RedBallTracker
{
    class FileIO
    {

        private static string FILE_DIR = "C:\\FoosballGeneral\\ScoreHistory\\Scores.txt";
        public FileIO()
        {

        }

    public void writeToFile(int redTeam, int blueTeam)
        {

            using (StreamWriter sw = File.CreateText(FILE_DIR))
            {
                sw.WriteLine(redTeam);
                sw.WriteLine(blueTeam);
            }
        }

    public string readFromFile()
        {
            return File.ReadAllText(FILE_DIR);
        }

    }
}

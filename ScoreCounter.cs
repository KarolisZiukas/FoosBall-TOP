using System.Collections.Generic;
using System.Windows.Forms;

namespace RedBallTracker
{
    //TODO Karolis IComparer
    public class ScoreCounter : IComparer<int>
    {
        //TODO Karolis: delegate
        public delegate int CountScoreDelegate(float coordinate);

        //TODO Adomas: anonymous methods
        public delegate void ReachedMaximumScore(int x, int y);

        //TODO Karolis auto-implemented properties
        public int ScoreTeamBlue { get; set; }
        public int ScoreTeamRed { get; set; }
        public CountScoreDelegate countScoreDelegate = new CountScoreDelegate(checkCoordinate);
        public ScoreCounter()
        {

        }

        public static int checkCoordinate(float coordinate)
        {
            if(coordinate < 15)
            {
                return 1;
            }
            else if (coordinate > 599)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        //TODO Adomas: Extension methods
        public void countScore(float coordinate, CountScoreDelegate countScoreDelegate)
        {
            if (countScoreDelegate(coordinate) == 1)
            {
                ScoreTeamRed = ScoreTeamRed.IncreaseScore();
            }
            else if (countScoreDelegate(coordinate) == -1)
            {
                ScoreTeamBlue = ScoreTeamBlue.IncreaseScore();
            }
            ReachedMaximumScore maximum = delegate (int scoreBlueTeam, int scoreRedTeam)
            {
                if (scoreBlueTeam == 10)
                {
                    MessageBox.Show(Constants.PlayerPlaceHolder + PlayersStruct.name.Player1 + Constants.MaximumScoreReached);
                }
                else if (scoreRedTeam == 10)
                {
                    MessageBox.Show(Constants.PlayerPlaceHolder + PlayersStruct.name.Player1 + Constants.MaximumScoreReached);
                }
            };
            maximum(ScoreTeamBlue, ScoreTeamRed);
        }
        public int Compare(int x, int y)
        {
            if (x > y)
                return -1;
            if (x == y)
                return 0;
            if (x < y)
                return 1;
            return 0;
        }
    }
}

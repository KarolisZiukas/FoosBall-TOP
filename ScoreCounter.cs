using System;
using System.Windows.Forms;
using System.Configuration;

namespace RedBallTracker
{
    //TODO Karolis IComparer
    public class ScoreCounter
    {
        //TODO Karolis: delegate
        public delegate int CountScoreDelegate<T>(T coordinate);   //generic delegate

        //TODO Adomas: anonymous methods
        public delegate void ReachedMaximumScore (int scoreRedTeam, int scoreBlueTeam);


        public delegate void ScoredEventHandler(object source, EventArgs eventArgs);
        public event ScoredEventHandler GoalScored;

        public delegate int Coordinates(float coordinate);

        //TODO Karolis auto-implemented properties
        public CountScoreDelegate<float>  countScoreDelegate = new CountScoreDelegate<float>(checkCoordinate);
        public Coordinates Coordinate;
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
        public void countScore(float coordinate, CountScoreDelegate<float> countScoreDelegate)
        {
            if (countScoreDelegate(coordinate) == 1)
            {
                Scores.ScoreTeamRed = Scores.ScoreTeamRed.IncreaseScore();

                OnGoalScored();
            }
            else if (countScoreDelegate(coordinate) == -1)
            {
                Scores.ScoreTeamBlue = Scores.ScoreTeamBlue.IncreaseScore();
                OnGoalScored();

            }

            ReachedMaximumScore maximum = delegate (int scoreBlueTeam, int scoreRedTeam)
            {
                // TODO: Adomas configuration files = app
                int maximumPossibleScore = Int32.Parse(ConfigurationManager.AppSettings["k1"]);
                if (scoreBlueTeam == maximumPossibleScore)
                {
                    MessageBox.Show(Constants.PlayerPlaceHolder + PlayersStruct.name.Player1 + Constants.MaximumScoreReached);
                }
                else if (scoreRedTeam == maximumPossibleScore)
                {
                    MessageBox.Show(Constants.PlayerPlaceHolder + PlayersStruct.name.Player1 + Constants.MaximumScoreReached);
                }
            };
            maximum(Scores.ScoreTeamBlue, Scores.ScoreTeamRed);
        }
        //Generic method
        public int Compare<T>(ref T x, ref T y) where T : System.IComparable<T>
        {
            if (x.CompareTo(y) > 0)
                return -1;
            if (x.CompareTo(y) ==0)
                return 0;
            if (x.CompareTo(y) <0)
                return 1;
            return 0;
        }

        protected virtual void OnGoalScored()
        {
            HttpCommand post = new HttpCommand();
            post.Post();
            GoalScored?.Invoke(this, EventArgs.Empty);
        }
    }
}

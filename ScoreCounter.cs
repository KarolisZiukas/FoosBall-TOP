using System.Collections.Generic;

namespace RedBallTracker
{
    //TODO Karolis IComparer

    public class ScoreCounter : IComparer<int>
    {
        //TODO Karolis auto-implemented properties
        public int ScoreTeamBlue { get; set; }
        public int ScoreTeamRed { get; set; }


        public ScoreCounter()
        {

        }
        //TODO Adomas: Extension methods
        public void countScore(float coordinate)
        {
            if (coordinate < 15)
            {
                ScoreTeamRed = ScoreTeamRed.IncreaseScore();
            }
            else if (coordinate > 599)
            {
                ScoreTeamBlue = ScoreTeamBlue.IncreaseScore();
            }
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

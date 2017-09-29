using System.Collections.Generic;

namespace RedBallTracker
{
    //IComparer

    class ScoreCounter : IComparer<int>
    {
        private int scoreTeamBlue = 0;
        private int scoreTeamRed = 0;

        public int ScoreTeamBlue { get => scoreTeamBlue; set => scoreTeamBlue = value; }
        public int ScoreTeamRed { get => scoreTeamRed; set => scoreTeamRed = value; }


        public ScoreCounter()
        {

        }

        public void countScore(float coordinate)
        {
            if (coordinate < 15)
            {
                ScoreTeamRed++;
            }
            else if (coordinate > 599)
            {
                ScoreTeamBlue++;
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

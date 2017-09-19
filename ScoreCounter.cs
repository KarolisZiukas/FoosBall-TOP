using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBallTracker
{
    class ScoreCounter
    {
        public int scoreTeamBlue = 0;
        public int scoreTeamRed = 0;

        public int ScoreTeamBlue { get => scoreTeamBlue; set => scoreTeamBlue = value; }
        public int ScoreTeamRed { get => scoreTeamRed; set => scoreTeamRed = value; }

        public ScoreCounter()
        {

        }

        public void countScore(float coordinate)
        {
            if (coordinate < 15)
            {
                scoreTeamRed++;
            }
            else if (coordinate > 599)
            {
                scoreTeamBlue++;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBallTracker
{
    public static class ExtensionMethods
    {
        public static int IncreaseScore(this int score)
        {
            return ++score;
        }
    }
}

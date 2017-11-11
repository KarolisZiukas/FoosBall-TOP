using System;
using System.Media;
using System.Threading;

namespace RedBallTracker
{
    class SoundService
    {
        public void OnGoalScored(object source, EventArgs eventArgs)
        {
            SoundPlayer goalSoundPlayer = new SoundPlayer(@"..\\projectFiles\\scoreSound.wav");
            goalSoundPlayer.Play();
        }
    }
}

using Emgu.CV;
using System;
using System.Threading;
using System.Windows.Forms;

namespace RedBallTracker
{

    public enum EndResult
    {
        Blue = -1,
        Red = 1,
        Tie = 0
    }


    public partial class frmMain : Form
    {
        //public Names name;
        ScoreCounter scoreCounter = new ScoreCounter();
        VideoCapture capWebcam;
        BlueTeamFigures blueTeamFigures = new BlueTeamFigures();
        BallTracking tracker = new BallTracking();
        private static string VIDEO_DIR = "..\\projectFiles\\testvideo3.mp4";

        public frmMain()
        {
            InitializeComponent();
            string Player1 = string.Empty;
            string Player2 = string.Empty;

            //TODO Karolis Optional variables
            new OpeningDialogs().inputBox(Constants.EnterFirstPlayerName, Constants.FirstPlayerNameIs, ref Player1, Constants.SubmitOption);
            new OpeningDialogs().inputBox(Constants.EnterSecondPlayerName, Constants.SecondPlayerNameIs, ref Player2);
            PlayersStruct.name.Player1 = Player1;
            PlayersStruct.name.Player2 = Player2;

            try
            {
                capWebcam = new VideoCapture(VIDEO_DIR);

            }
            catch (Exception ex)
            {
                MessageBox.Show(Constants.ErrorFromFile + ex.Message);
                Environment.Exit(0);
                return;
            }
            Application.Idle += processFrameAndUpdateGUI;

        }

        void processFrameAndUpdateGUI(object sender, EventArgs arg)
        {

            Mat imgOriginal;
            imgOriginal = capWebcam.QueryFrame();
            Thread.Sleep(1000 / 120);

            if (imgOriginal == null)
            {
                //TODO Karolis Named variables
                new FileIO().writeToFile(blueTeam: scoreCounter.ScoreTeamBlue, redTeam: scoreCounter.ScoreTeamRed);
                EndResult endResult = (EndResult)scoreCounter.Compare(scoreCounter.ScoreTeamBlue, scoreCounter.ScoreTeamRed);
                MessageBox.Show(Constants.ResultMessage + endResult);

                Environment.Exit(0);
                return;
            }
            //tracker.Track(imgOriginal, scoreCounter);
            ibThresh.Image = tracker.Track(imgOriginal, scoreCounter);
            ibOriginal.Image = imgOriginal;
            lTeamBox.Text = Constants.PlayerPlaceHolder + PlayersStruct.name.Player1 + " " + scoreCounter.ScoreTeamRed;
            rTeamBox.Text = Constants.PlayerPlaceHolder + PlayersStruct.name.Player2 + " " + scoreCounter.ScoreTeamBlue;

        }

        private void loadScore_Click(object sender, EventArgs e)
        {
            loadedScore.Text = (new FileIO().readFromFile() + " ");
        }

        private void bluePlayers_Click(object sender, EventArgs e)
        {
            //TODO Karolis usage of indexed properties
            string blueTeamPlayers = string.Empty;
            for (int i = 0; i < blueTeamFigures.arraySize(); i++)
            {
                blueTeamPlayers += blueTeamFigures[i] + "\n";
            }
            MessageBox.Show(blueTeamPlayers);

        }
    }
}

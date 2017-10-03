using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Drawing;
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

    public struct Names
    {
        // TODO Adomas auto Property usage in structs
        public String Player1 { get; set; }

        public String Player2 { get; set; }
    }

    public partial class frmMain : Form
    {
        public Names name;
        ScoreCounter scoreCounter = new ScoreCounter();
        VideoCapture capWebcam;
        BlueTeamFigures blueTeamFigures = new BlueTeamFigures();

        private static string VIDEO_DIR = "..\\projectFiles\\testvideo3.mp4";

        public frmMain()
        {
            InitializeComponent();
            string Player1 = string.Empty;
            string Player2 = string.Empty;

            //TODO Karolis Optional variables
            new OpeningDialogs().inputBox(Constants.EnterFirstPlayerName, Constants.FirstPlayerNameIs, ref Player1, Constants.SubmitOption);
            new OpeningDialogs().inputBox(Constants.EnterSecondPlayerName, Constants.SecondPlayerNameIs, ref Player2);
            name.Player1 = Player1;
            name.Player2 = Player2;

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

            Mat imgHSV = new Mat(imgOriginal.Size, DepthType.Cv8U, 3);

            Mat imgThreshLow = new Mat(imgOriginal.Size, DepthType.Cv8U, 1);
            Mat imgThreshHigh = new Mat(imgOriginal.Size, DepthType.Cv8U, 1);

            Mat imgThresh = new Mat(imgOriginal.Size, DepthType.Cv8U, 1);

            CvInvoke.CvtColor(imgOriginal, imgHSV, ColorConversion.Bgr2Hsv);

            CvInvoke.InRange(imgHSV, new ScalarArray(new MCvScalar(0, 155, 155)), new ScalarArray(new MCvScalar(18, 255, 255)), imgThreshLow);
            CvInvoke.InRange(imgHSV, new ScalarArray(new MCvScalar(165, 155, 155)), new ScalarArray(new MCvScalar(179, 255, 255)), imgThreshHigh);

            CvInvoke.Add(imgThreshLow, imgThreshHigh, imgThresh);

            CvInvoke.GaussianBlur(imgThresh, imgThresh, new Size(3, 3), 500);

            Mat structuringElement = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));

            CvInvoke.Dilate(imgThresh, imgThresh, structuringElement, new Point(-1, -1), 1, BorderType.Default, new MCvScalar(0, 0, 0));
            CvInvoke.Erode(imgThresh, imgThresh, structuringElement, new Point(-1, -1), 1, BorderType.Default, new MCvScalar(0, 0, 0));

            CircleF[] circles = CvInvoke.HoughCircles(imgThresh, HoughType.Gradient, 2.0, imgThresh.Rows / 4, 100, 5, 4, 8);
            foreach (CircleF circle in circles)
            {
                CvInvoke.Circle(imgOriginal, new Point((int)circle.Center.X, (int)circle.Center.Y), (int)circle.Radius, new MCvScalar(255, 0, 0), 2, LineType.AntiAlias);
                CvInvoke.Circle(imgOriginal, new Point((int)circle.Center.X, (int)circle.Center.Y), 3, new MCvScalar(0, 255, 0), -1);
                scoreCounter.countScore(circle.Center.X);

                lTeamBox.Text = (Constants.PlayerPlaceHolder + this.name.Player1 + " " + scoreCounter.ScoreTeamRed);
                rTeamBox.Text = (Constants.PlayerPlaceHolder + this.name.Player2 + " " + scoreCounter.ScoreTeamBlue);
            }

           ibOriginal.Image = imgOriginal;
          ibThresh.Image = imgThresh;
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

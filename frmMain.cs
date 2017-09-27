using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace RedBallTracker
{
    public struct Names
    {
        public string Player1;
        public string Player2;

        // Property usage in structs
        public String player1GetSet // Getters and setters for the structure
        {
            get { return Player1; }
            set { Player1 = value; }
        }

        public String player2GetSet // Getters and setters for the structure
        {
            get { return Player2; }
            set { Player2 = value; }
        }
    }

    public partial class frmMain : Form
    {
        public Names name;
        
        VideoCapture capWebcam;
        private static string VIDEO_DIR = "..\\projectFiles\\testvideo3.mp4";


        ScoreCounter scoreCounter = new ScoreCounter();
        public frmMain()
        {
            InitializeComponent();

            string Player1 = "";
            string Player2 = "";
            //Optional variables
            new OpeningDialogs().inputBox("Enter the name of the first player", "First player name is", ref Player1, "Submit");
            new OpeningDialogs().inputBox("Enter the name of the second player", "Second player name is", ref Player2);
            name.player1GetSet = Player1;
            name.player2GetSet = Player2;
            Player2 = name.player1GetSet;

            try
            {
                capWebcam = new VideoCapture(VIDEO_DIR);
            }
            catch (Exception ex)
            {
                MessageBox.Show("unable to read from webcam, error: " + Environment.NewLine + Environment.NewLine +
                                ex.Message + Environment.NewLine + Environment.NewLine +
                                "exiting program");
                Environment.Exit(0);
                return;
            }
            Application.Idle += processFrameAndUpdateGUI;    // add process image function to the application's list of tasks   
        }
        

        void processFrameAndUpdateGUI(object sender, EventArgs arg)
        {
            Mat imgOriginal;
            imgOriginal = capWebcam.QueryFrame();

            Thread.Sleep(1000 / 60);

            if (imgOriginal == null)
            {
                //Named variables
                new FileIO().writeToFile(blueTeam: scoreCounter.ScoreTeamBlue, redTeam: scoreCounter.ScoreTeamRed);
                MessageBox.Show("team won");
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
                //txtXYRadius.AppendText("ball position x = " + circle.Center.X.ToString().PadLeft(4) + ", y = " + circle.Center.Y.ToString().PadLeft(4) + ", radius = " + circle.Radius.ToString("###.000").PadLeft(7));
          
                    CvInvoke.Circle(imgOriginal, new Point((int)circle.Center.X, (int)circle.Center.Y), (int)circle.Radius, new MCvScalar(255, 0, 0), 2, LineType.AntiAlias);
                    CvInvoke.Circle(imgOriginal, new Point((int)circle.Center.X, (int)circle.Center.Y), 3, new MCvScalar(0, 255, 0), -1);
                    scoreCounter.countScore(circle.Center.X);

                    lTeamBox.Text = ("Player " + this.name.player1GetSet + " " + scoreCounter.ScoreTeamRed);
                    rTeamBox.Text = ("Player " + this.name.player2GetSet + " " + scoreCounter.ScoreTeamBlue);



            }
            ibOriginal.Image = imgOriginal;
            ibThresh.Image = imgThresh;
        }

        private void loadScore_Click(object sender, EventArgs e)
        {
            loadedScore.Text = (new FileIO().readFromFile() + " ");
        }
    }
}

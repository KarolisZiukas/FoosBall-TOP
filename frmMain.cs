using Emgu.CV;
using System;
using System.Net.Http;
using System.Threading;
using System.Windows.Forms;
using RedBallTracker.Properties;


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
        ScoreCounter scoreCounter = new ScoreCounter();  //publisher
        SoundService soundService = new SoundService();  //subscriber

        VideoCapture capWebcam;

       
        static System.Net.HttpListener _httpListener = new System.Net.HttpListener();
         //ToDo Karolis: Lazy Initialization
        Lazy<BlueTeamFigures> blueTeamFigures = new Lazy<BlueTeamFigures>();
        BallTracking tracker = new BallTracking();
        private static string VIDEO_DIR = "..\\projectFiles\\testvideo3.mp4";
        public static readonly HttpClient client = new HttpClient();
        public static string url = "http://localhost:5000/api/scores/";

        public frmMain()
        {
            InitializeComponent();
            string Player1 = string.Empty;
            string Player2 = string.Empty;
            
            HttpPut put = new HttpPut();
            put.Put();
            //SERVERIS
            //HttpListener.Init();
            //Thread _responseThread = ResponseThread.Create();
            //_responseThread.Start(); // start the response thread

            

            int flag = 1;
            do
            {
                
                try
                {
                    //TODO Karolis Optional variables
                    new OpeningDialogs().inputBox(Constants.EnterFirstPlayerName, Constants.FirstPlayerNameIs, ref Player1, Constants.SubmitOption);
                    new OpeningDialogs().inputBox(Constants.EnterSecondPlayerName, Constants.SecondPlayerNameIs, ref Player2);
                    checkIfStringIsEmpty(Player1);
                    checkIfStringIsEmpty(Player2);
                    PlayersStruct.name.Player1 = Player1;
                    PlayersStruct.name.Player2 = Player2;
                    flag = 1;
                }
                catch (EmptyNameException emptyNameException)
                {
                    MessageBox.Show(emptyNameException.Message);
                    flag = 0;
                }
            } while (flag == 0);
                   


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
            scoreCounter.GoalScored += soundService.OnGoalScored;
            Application.Idle += processFrameAndUpdateGUI;

        }
        void processFrameAndUpdateGUI(object sender, EventArgs arg)
        {
            Mat imgOriginal;
            imgOriginal = capWebcam.QueryFrame();
            Thread.Sleep(1000 / 100);

            if (imgOriginal == null)
            {
                //TODO Karolis Named variables
                new FileIO().writeToFile(blueTeam: Scores.ScoreTeamBlue, redTeam: Scores.ScoreTeamRed);
                int scBlue = Scores.ScoreTeamBlue;
                int scRed = Scores.ScoreTeamRed;
                EndResult endResult = (EndResult)scoreCounter.Compare<int>(ref scBlue, ref scRed);
                MessageBox.Show(Constants.ResultMessage + endResult);

                Environment.Exit(0);
                return;
            }
            //tracker.Track(imgOriginal, scoreCounter);
            //scoreCounter.GoalScored += soundService.OnGoalScored;
            ibThresh.Image = tracker.Track(imgOriginal, scoreCounter);
            ibOriginal.Image = imgOriginal;
            lTeamBox.Text = Constants.PlayerPlaceHolder + PlayersStruct.name.Player1 + " " + Scores.ScoreTeamRed;
            rTeamBox.Text = Constants.PlayerPlaceHolder + PlayersStruct.name.Player2 + " " + Scores.ScoreTeamBlue;

        }

        private void loadScore_Click(object sender, EventArgs e)
        {
            //var factory = new ConnectionFactory() { HostName = "localhost" };
            //using (var connection = factory.CreateConnection())
            //using (var channel = connection.CreateModel())
            //{
            //    channel.QueueDeclare(queue: "hello",
            //                         durable: false,
            //                         exclusive: false,
            //                         autoDelete: false,
            //                         arguments: null);

            //    string message = "Hello World!";
            //    var body = Encoding.UTF8.GetBytes(message);

            //    channel.BasicPublish(exchange: "",
            //                         routingKey: "hello",
            //                         basicProperties: null,
            //                         body: body);
            //    //Console.WriteLine(" [x] Sent {0}", message);
            //    loadedScore.Text = (message);
            //}

        }

        private void bluePlayers_Click(object sender, EventArgs e)
        {
            //TODO Karolis usage of indexed properties
            string blueTeamPlayers = string.Empty;
            for (int i = 0; i < blueTeamFigures.Value.arraySize(); i++)
            {
                blueTeamPlayers += blueTeamFigures.Value[i] + "\n";
            }
            MessageBox.Show(blueTeamPlayers);

        }

        public void checkIfStringIsEmpty(string emptyString)
        {
            if(emptyString == "")
            {
                throw new EmptyNameException();
            }
        }

        // TODO: Adomas configuration files - User
        private void button1_Click(object sender, EventArgs e)
        {
            Settings.Default["Title"] = textBox1.Text;
            Settings.Default["Button"] = textBox2.Text;
            Settings.Default.Save();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Configuration for title
            this.Text = Settings.Default["Title"].ToString();
            button1.Text = Settings.Default["Button"].ToString();
        }
    }



}

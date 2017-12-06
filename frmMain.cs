using Emgu.CV;
using System;
using System.Net.Http;
using System.Threading;
using System.Windows.Forms;
using RedBallTracker.Properties;
using System.Data.SqlClient;
using System.Linq;
using System.Data.Common;
using System.Configuration;

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
        MainModel database = new MainModel(); 

        public frmMain()
        {

            
            InitializeComponent();
            string Player1 = string.Empty;
            string Player2 = string.Empty;
            
            HttpPut put = new HttpPut();
            put.Put();

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

                // App.config stores configuration data
                // System.Data.SqlClient provides classes
                // for accessing a SQL Server DB

                // connectionString defines the DB name, and
                // other parameters for connecting to the DB

                // Configurationmanager provides access to
                // config data in App.config
                string provider = ConfigurationManager.AppSettings["scores"];

                string connectionString = ConfigurationManager.AppSettings["connectionString"];

                // DbProviderFactories generates an 
                // instance of a DbProviderFactory
                DbProviderFactory factory = DbProviderFactories.GetFactory(provider);

                // The DBConnection represents the DB connection
                using (DbConnection connection =
                    factory.CreateConnection())
                {
                    // Check if a connection was made
                    if (connection == null)
                    {
                        MessageBox.Show("Connection Error");
                        Console.ReadLine();
                        return;
                    }

                    // The DB data needed to open the correct DB
                    connection.ConnectionString = connectionString;

                    // Open the DB connection
                    connection.Open();

                    // Allows you to pass queries to the DB
                    DbCommand command = factory.CreateCommand();

                    if (command == null)
                    {
                        MessageBox.Show("Command Error");
                        Console.ReadLine();
                        return;
                    }

                    // Set the DB connection for commands
                    command.Connection = connection;

                    // The query you want to issue
                    command.CommandText = "Select * From Scores";

                    // DbDataReader reads the row results
                    // from the query
                    using (DbDataReader dataReader = command.ExecuteReader())
                    {
                        // Advance to the next results
                        while (dataReader.Read())
                        {
                            // Output results using row names
                            MessageBox.Show(($"{dataReader["Id"]} " +
                                $"{dataReader["PlayerName"]}"));
                        }
                    }
                    //Console.ReadLine();
                }

                    //ToDo: Karolis Database Add
                    var result = new ScoreDB
                {
                    BlueTeam = Scores.ScoreTeamBlue,
                    RedTeam = Scores.ScoreTeamRed,
                    Date = DateTime.Now,
                    MatchResult = string.Empty + endResult
                };
                database.Scores.Add(result);
                database.SaveChanges();
                Environment.Exit(0);
                return;
            }

            ibThresh.Image = tracker.Track(imgOriginal, scoreCounter);
            ibOriginal.Image = imgOriginal;
            lTeamBox.Text = Constants.PlayerPlaceHolder + PlayersStruct.name.Player1 + " " + Scores.ScoreTeamRed;
            rTeamBox.Text = Constants.PlayerPlaceHolder + PlayersStruct.name.Player2 + " " + Scores.ScoreTeamBlue;

        }

        private void loadScore_Click(object sender, EventArgs e)
        {
  
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

        private void button2_Click(object sender, EventArgs e)
        {
            var query = from b in database.Scores
                         orderby b.Date ascending
                         select b;

            foreach (var item in query)
            {
                last_match_time.AppendText(item.Date + " ");
                last_match_result.AppendText(item.MatchResult + " ");
                red_team_last_result.AppendText(item.RedTeam + " "); ;
                blue_team_last_result.AppendText(item.BlueTeam + " "); ;
            }
          
        }
    }



}

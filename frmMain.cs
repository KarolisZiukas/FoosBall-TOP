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
using System.Data;

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
        private DbProviderFactory factory;
        DbConnection connection;
        SqlConnection connection2;
        VideoCapture capWebcam;
        DataTable scoresDatatable;
        DbCommand command;
        string connectionString;
        string selectParameter;
        string querryString = "select * from dbo.scores";



        static System.Net.HttpListener _httpListener = new System.Net.HttpListener();
        //ToDo Karolis: Lazy Initialization
        Lazy<BlueTeamFigures> blueTeamFigures = new Lazy<BlueTeamFigures>();
        BallTracking tracker = new BallTracking();
        private static string VIDEO_DIR = "..\\projectFiles\\testvideo3.mp4";
        public static readonly HttpClient client = new HttpClient();
        public static string url = "http://localhost:5000/api/scores/";
        Model1 database = new Model1();

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
            //ToDo: Karolis dataTable
            scoresDatatable = new DataTable();
            scoresDatatable.Columns.Add("blueTeam", typeof(int));
            scoresDatatable.Columns.Add("redTeam", typeof(int));
            scoresDatatable.Columns.Add("date", typeof(DateTime));
            scoresDatatable.Columns.Add("matchResult", typeof(string));


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
                //ToDo: Saves result at the end of the match

                scoresDatatable.Rows.Add(Scores.ScoreTeamBlue, Scores.ScoreTeamRed, DateTime.Now, endResult);
                var result = new Score { };
                foreach (DataRow row in scoresDatatable.Rows)
                {
                    result = new Score
                    {
                        blueTeam = row.Field<int>(0),
                        redTeam = row.Field<int>(1),
                        date = row.Field<DateTime>(2),
                        matchResult = string.Empty + row.Field<string>(3)
                    };
                }
                database.Scores.Add(result);

                database.SaveChanges();
                // Here we add five DataRows.

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
            if (emptyString == "")
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
                        orderby b.date ascending
                        select b;

            foreach (var item in query)
            {
                last_match_time.AppendText(item.date + " ");
                last_match_result.AppendText(item.matchResult + " ");
                red_team_last_result.AppendText(item.redTeam + " "); ;
                blue_team_last_result.AppendText(item.blueTeam + " "); ;
            }

        }

        public void openDatabaseConnection(string querryString)
        {
            string provider = ConfigurationManager.AppSettings["scores"];
            connectionString = ConfigurationManager.AppSettings["connectionString"];

            factory = DbProviderFactories.GetFactory(provider);


            using (connection =
                factory.CreateConnection())
            {

                if (connection == null)
                {
                    MessageBox.Show("Connection Error");
                    Console.ReadLine();
                    return;
                }
                connection.ConnectionString = connectionString;

                connection.Open();
                DataSet dataSet = DataSetFill.ConnectToData(connectionString);
                MessageBox.Show(dataSet.Tables[0].Rows[0]["redTeam"].ToString());
                selectQuerry(querryString);

            }
        }

        public void selectQuerry(String querryString)
        {
            command = factory.CreateCommand();

            if (command == null)
            {
                MessageBox.Show("Command Error");
                Console.ReadLine();
                return;
            }

            command.Connection = connection;

            command.CommandText = querryString;


            using (DbDataReader dataReader = command.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    listBox1.Items.Add(($"{dataReader[selectParameter]}"));
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            selectParameter = String.Empty;
            new OpeningDialogs().inputBox("Enter what you want to select", Constants.SecondPlayerNameIs, ref selectParameter);
            string insert = @"select " + selectParameter + " from scores";
            listBox1.Items.Clear();
            openDatabaseConnection(insert);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            openDatabaseConnection("delete from dbo.scores");
            database.SaveChanges();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            string columnToUpdate = string.Empty;
            string updatedValue = string.Empty;
            new OpeningDialogs().inputBox("Enter column you want to update", "Enter column you want to update", ref columnToUpdate);
            new OpeningDialogs().inputBox("Enter value", "Enter value", ref updatedValue);
            openDatabaseConnection("update dbo.scores set " + columnToUpdate + " = " + updatedValue + " where matchResult = 'tie'");
        }

        private void insert_button_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss";
            string insert = @" insert into dbo.Scores values (1, 4,'" + time.ToString(format) + "', 'tie')";
            openDatabaseConnection(insert);
            database.SaveChanges();


        }

        private void save_with_data_table_Click(object sender, EventArgs e)
        {

        }

        private void buttonGroup_Click(object sender, EventArgs e)
        {
            var query = from b in database.Scores
                        group b by b.redTeam into r
                        select r;

            foreach (var item in query)
            {
                listBox1.Items.Add(item.Key);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var query = from b in database.Scores
                        orderby b.date ascending
                        select b;
            var skipping = query.Skip(1).Take(3);

            foreach (var item in skipping)
            {
                listBox1.Items.Add(item.matchResult);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var query = from b in database.Scores
                        orderby b.date ascending
                        select b.matchResult;
            var sum = query.Aggregate((a, b) => a + ',' + b);

            listBox1.Items.Add(sum);
        }
    }
}

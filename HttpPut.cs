using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using System.IO;

namespace RedBallTracker
{
    class HttpPut
    {
        private class Output
        {
            public int RedTeamScore { get; set; }
            public int BlueTeamScore { get; set; }
            public Output()
            {
                RedTeamScore = Scores.ScoreTeamRed;
                BlueTeamScore = Scores.ScoreTeamBlue;
            }
        }

        public void Put()
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(frmMain.url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            Output output = new Output();
            string jsonOut = JsonConvert.SerializeObject(output);
            httpWebRequest.ContentLength = jsonOut.Length;
            using(var writer = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                writer.Write(jsonOut);
            }
            var response = httpWebRequest.GetResponse() as HttpWebResponse;
        }
    }
}

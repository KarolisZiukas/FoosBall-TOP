using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBallTracker
{
    class DataAdapterUsage
    {
        public static DataSet Connect(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();

                adapter.TableMappings.Add("ResultTable", "ScoreDB");

                connection.Open();
                SqlCommand command = new SqlCommand("SELECT MatchResult FROM dbo.ScoreDB;", connection);
                command.CommandType = CommandType.Text;
                adapter.SelectCommand = command;

                DataSet dataSet = new DataSet("Result");
                adapter.Fill(dataSet);

                return dataSet;
            }
        }
    }
}

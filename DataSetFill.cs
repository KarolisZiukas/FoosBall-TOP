using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBallTracker
{
    static class DataSetFill
    {
        public static DataSet ConnectToData(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();

                connection.Open();

                SqlCommand command = new SqlCommand("SELECT RedTeam, BlueTeam " +
                    "FROM dbo.Scores;", connection);

                command.CommandType = CommandType.Text;
                adapter.SelectCommand = command;

                DataSet dataSet = new DataSet("Score");
                adapter.Fill(dataSet);

                connection.Close();

                return dataSet;
            }
        }
    }
}

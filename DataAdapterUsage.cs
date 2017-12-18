using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBallTracker
{
    class DataAdapterUsage
    {
        public static DataSet Adapter(string connectionString)
        {
            //DbProviderFactory factory = DbProviderFactories.GetFactory(provider);


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet dataSet = new DataSet("History");
                adapter.TableMappings.Add("Score", "History");

                SqlCommand command = new SqlCommand("SELECT MatchResult FROM dbo.Score;", connection);
                command.CommandType = CommandType.Text;
                adapter.SelectCommand = command;

                adapter.Fill(dataSet);
                connection.Close();
                return dataSet;
            }
        }
    }
}

using System;
using System.Configuration;
using System.Data.Common;
using System.Windows.Forms;

namespace RedBallTracker
{
    public partial class DataBase
    {
        public DataBase() { }

        public static void DBshowData()
        {
            //TODO: Adomas - DB creation
            string provider = ConfigurationManager.AppSettings["scores"];

            string connectionString = ConfigurationManager.AppSettings["connectionString"];

            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);

            using (DbConnection connection =
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

                DbCommand command = factory.CreateCommand();

                if (command == null)
                {
                    MessageBox.Show("Command Error");
                    return;
                }

                command.Connection = connection;

                command.CommandText = "Select * From Scores";

                using (DbDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        MessageBox.Show(($"{dataReader["Id"]} " +
                            $"{dataReader["PlayerName"]}" + $"{dataReader["PlayerScore"]} "));
                    }
                }
            }
        }
    }
}

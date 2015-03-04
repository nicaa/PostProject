using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using MySql.Data.MySqlClient;
using PostProjectWebServices.Database;

namespace PostProjectWebServices.Models.Repositories
{
    public class CityRepository
    {
        private DataSource dataSource;
        private MySqlConnection databaseConnection;
        private MySqlCommand command;
        private MySqlDataReader dataReader;
        private String connectionString;
        private QueryHandler queryHandler;

        public CityRepository()
        {
            dataSource = new DataSource();
            connectionString = dataSource.Server + dataSource.Database + dataSource.User + dataSource.Password;
            databaseConnection = new MySqlConnection(connectionString);
            queryHandler = new QueryHandler();
        }

        public HashSet<String> GetCities()
        {
            HashSet<String> citiesList = new HashSet<string>();
            String query = "SELECT " + dataSource.RecipientCity + " FROM " + dataSource.TablePackages;
            String city;

            command = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                city = queryHandler.ExtractCityFromDataReader(dataReader, dataSource);
                citiesList.Add(city);
            }

            databaseConnection.Close();

            return citiesList;
        }
    }
}
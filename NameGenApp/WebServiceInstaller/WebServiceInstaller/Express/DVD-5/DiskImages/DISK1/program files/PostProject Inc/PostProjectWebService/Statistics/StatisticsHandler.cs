using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using PostProjectWebServices.Database;
using PostProjectWebServices.Models;
using PostProjectWebServices.Models.Repositories;

namespace PostProjectWebServices.Statistics
{
    public class StatisticsHandler
    {
        private DataSource dataSource;
        private MySqlConnection databaseConnection;
        private MySqlCommand command;
        private MySqlDataReader dataReader;
        private String connectionString;
        private QueryHandler queryHandler;
        private CityRepository _cityRepository;


        public StatisticsHandler()
        {
            _cityRepository = new CityRepository();
            dataSource = new DataSource();
            connectionString = dataSource.Server + dataSource.Database + dataSource.User + dataSource.Password;
            databaseConnection = new MySqlConnection(connectionString);
            queryHandler = new QueryHandler();
        }

        public void CountPackagesPerCity()
        {
            String query;
            String city;
            String count;
            CityStatistic cityStatistic = new CityStatistic();
            List<CityStatistic> cityStatistics = new List<CityStatistic>();

            databaseConnection.Open();

                query = "SELECT " + dataSource.RecipientCity + ", COUNT(*) FROM " + dataSource.TablePackages + " GROUP BY " + dataSource.RecipientCity;

                command = new MySqlCommand(query, databaseConnection);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    cityStatistic = queryHandler.ExtractCityStatisticFromDataReader(dataReader, dataSource);
                    cityStatistic.DateTime = DateTime.Now;
                    cityStatistics.Add(cityStatistic);
                }
            
            databaseConnection.Close();

            InsertCityStatistics(cityStatistics);
        }

        public void InsertCityStatistics(List<CityStatistic> cityStatistics )
        {
            String query;

            databaseConnection.Open();

            for (int i = 0; i < cityStatistics.Count; i++)
            {
                query = "insert INTO " + dataSource.TableStatistics + " (" + dataSource.StatisticCity + ", " + dataSource.StatisticCount + ", " + dataSource.StatisticDate + ") VALUES('" + cityStatistics[i].City + "', '" + cityStatistics[i].Count + "', '" + cityStatistics[i].DateTime.ToString("yyyy-MM-dd HH:mm:ss") + "')";
                command = new MySqlCommand(query, databaseConnection);
                command.ExecuteNonQuery();
            }

            databaseConnection.Close();
        }
    }
}
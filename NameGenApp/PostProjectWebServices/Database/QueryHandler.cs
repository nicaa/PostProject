using System;
using MySql.Data.MySqlClient;
using PostProjectWebServices.Models;

namespace PostProjectWebServices.Database
{
    public class QueryHandler
    {
        public Package ExtractPackageFromDataReader(MySqlDataReader dataReader, DataSource dataSource)
        {
            Package package = new Package(); // optimize when testing

            package.packageId           = Convert.ToInt32(dataReader[dataSource.PackageId]);
            package.recipientFirstName  = dataReader[dataSource.RecipientFirstName].ToString();
            package.recipientLastName   = dataReader[dataSource.RecipientLastName].ToString();
            package.recipientStreet     = dataReader[dataSource.RecipientStreet].ToString();
            package.recipientCity       = dataReader[dataSource.RecipientCity].ToString();
            package.recipientPostalCode = dataReader[dataSource.RecipientPostalCode].ToString();

            return package;
        }

        public String ExtractCityFromDataReader(MySqlDataReader dataReader, DataSource dataSource)
        {
            String city;

            city = dataReader[dataSource.RecipientCity].ToString();

            return city;
        }

        public CityStatistic ExtractCityStatisticFromDataReader(MySqlDataReader dataReader, DataSource dataSource)
        {
            CityStatistic cityStatistic = new CityStatistic();

            cityStatistic.City = dataReader[0].ToString();
            cityStatistic.Count = dataReader[1].ToString();

            return cityStatistic;
        }


    }
}

using System;
using MySql.Data.MySqlClient;
using PostProjectWebServices.Models;
using PostProjectWebServices.Models.Repositories;

namespace PostProjectWebServices.Database
{
    public class QueryHandler
    {
        public Package ExtractPackageFromDataReader(MySqlDataReader dataReader, DataSource dataSource)
        {
            Package package = new Package(); // optimize when testing

            package.packageId = Convert.ToInt32(dataReader[dataSource.PackageId]);
            package.recipientFirstName = dataReader[dataSource.FirstName].ToString();
            var recipientId = Convert.ToInt32(dataReader[dataSource.RecipientId]);
            package.destinationStreet = dataReader[dataSource.DestinationStreet].ToString();
            package.destinationCity = dataReader[dataSource.DestinationCity].ToString();
            package.destinationPostalCode = dataReader[dataSource.DestinationPostalCode].ToString();

            return package;
        }
    }
}

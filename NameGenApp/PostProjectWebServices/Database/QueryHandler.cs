﻿using System;
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
    }
}

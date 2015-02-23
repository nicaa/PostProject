using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using PostProjectWebServices.Database;

namespace PostProjectWebServices.Models.Repositories
{
    public class PackageRepository : IPackageRepository
    {

        private DataSource dataSource;
        private MySqlConnection databaseConnection;
        private MySqlCommand command;
        private MySqlDataReader dataReader;

        private String connectionString;

        private QueryHandler queryHandler;

        public PackageRepository()
        {
            dataSource = new DataSource();
            connectionString = dataSource.Server + dataSource.Database + dataSource.User + dataSource.Password;
            databaseConnection = new MySqlConnection(connectionString);
            queryHandler = new QueryHandler();
        }

        public List<Package> GetAllPackages()
        {
            List<Package> packages = new List<Package>();
            String query = "SELECT * FROM " + dataSource.TablePackages;

            command = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Package package = queryHandler.ExtractPackageFromDataReader(dataReader, dataSource);
                packages.Add(package);
            }


            databaseConnection.Close();

            return packages;
        }

        public Package GetPackage(int packageId)
        {
            Package package = new Package();
            String query = "SELECT * FROM " + dataSource.TablePackages + " WHERE " + dataSource.PackageId + " = " + packageId;
            command = new MySqlCommand(query, databaseConnection);

            databaseConnection.Open();
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                package = queryHandler.ExtractPackageFromDataReader(dataReader, dataSource);
            }

            databaseConnection.Close();

            return package;
        }

        public Package SendPackage(int packageId)
        {
            throw new NotImplementedException();
        }

        public void CreatePackage(Package package)
        {
            String query = "insert INTO " + dataSource.TablePackages + " (" + dataSource.RecipientFirstName + ", " + dataSource.RecipientLastName + ", " + dataSource.RecipientStreet + ", " + dataSource.RecipientCity + ", " + dataSource.RecipientPostalCode + ") VALUES('" + package.recipientFirstName + "', '" + package.recipientLastName + "', '" + package.recipientStreet + "', '" + package.recipientCity + "', '" + package.recipientPostalCode + "')";
            command = new MySqlCommand(query, databaseConnection);

            databaseConnection.Open();
            command.ExecuteNonQuery();
            databaseConnection.Close();
        }
    }

    public interface IPackageRepository
    {
        List<Package> GetAllPackages();
        Package GetPackage(int packageId);
        Package SendPackage(int packageId);
        void CreatePackage(Package package);

    }
}
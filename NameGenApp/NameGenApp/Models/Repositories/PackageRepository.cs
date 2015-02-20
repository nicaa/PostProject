using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using NameGenApp.Database;

namespace NameGenApp.Models.Repositories
{
    public class PackageRepository : IPackageRepository
    {
        private DataSource dataSource;
        private MySqlConnection databaseConnection;
        private MySqlCommand command;
        private MySqlDataReader dataReader;

        private String connectionString;
        private IPersonRepository _personRepository;

        private QueryHandler queryHandler;

        public PackageRepository()
        {
            dataSource = new DataSource();
            connectionString = dataSource.Server + dataSource.Database + dataSource.User + dataSource.Password;
            databaseConnection = new MySqlConnection(connectionString);
            queryHandler = new QueryHandler();
            _personRepository = new PersonRepository();
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
            String query = "SELECT * FROM " + dataSource.TablePackages +" WHERE " + dataSource.PackageId + " = " + packageId;
            command = new MySqlCommand(query, databaseConnection);
            
            databaseConnection.Open();
            dataReader = command.ExecuteReader();
            databaseConnection.Close();

            while (dataReader.Read())
            {
                queryHandler.ExtractPackageFromDataReader(dataReader, dataSource);
            }

            return package;
        }

        public Package SendPackage(int packageId)
        {
            throw new NotImplementedException();
        }

        public void CreatePackage(Package package)
        {
            String query = "INSERT into " + dataSource.TablePackages + " (" 
                + dataSource.DestinationStreet + ", " 
                + dataSource.Database + ", " 
                + dataSource.DestinationPostalCode + ")" +
                " VALUES('" 
                + package.destinationStreet + "', " 
                + package.destinationCity + "' '" 
                + package.destinationPostalCode + "')";
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

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
        private MySQLDatabase database;
        private DataSource dataSource;
        private MySqlConnection mySqlConnection;
        private MySqlCommand command;
        private MySqlDataReader dataReader;

        private String connectionString;
        private IPersonRepository _personRepository;

        private QueryHandler queryHandler;

        public PackageRepository()
        {
            database = new MySQLDatabase();
            dataSource = new DataSource();
            connectionString = dataSource.SERVER + dataSource.DATABASE + dataSource.USER + dataSource.PASSWORD;
            mySqlConnection = new MySqlConnection(connectionString);
            queryHandler = new QueryHandler();
            _personRepository = new PersonRepository();
        }

        public List<Package> GetAllPackages()
        {
            List<Package> packages = new List<Package>();
            String query = "SELECT * FROM packages";

            command = new MySqlCommand(query, mySqlConnection);
            mySqlConnection.Open();
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Package package = queryHandler.ExtractPackageFromDataReader(dataReader);
                packages.Add(package);
            }


            mySqlConnection.Close();

            return packages;
        }

        public Package GetPackage(int packageId)
        {
            Package package = new Package();
            String query = "SELECT * FROM packages WHERE packageId = " + packageId;
            command = new MySqlCommand(query, mySqlConnection);
            
            mySqlConnection.Open();
            dataReader = command.ExecuteReader();
            mySqlConnection.Close();

            while (dataReader.Read())
            {
                queryHandler.ExtractPackageFromDataReader(dataReader);
            }

            return package;
        }

        public Package SendPackage(int packageId)
        {
            throw new NotImplementedException();
        }

        public void CreatePackage(Package package)
        {
            throw new NotImplementedException();
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

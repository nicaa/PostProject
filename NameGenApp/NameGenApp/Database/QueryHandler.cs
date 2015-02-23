using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using NameGenApp.Models;
using NameGenApp.Models.Repositories;

namespace NameGenApp.Database
{
    public class QueryHandler
    {
        public Package ExtractPackageFromDataReader(MySqlDataReader dataReader, DataSource dataSource)
        {
            Package package = new Package(); // optimize when testing
            Person sender = new Person();
            Person recipient = new Person();
            IPersonRepository _personRepository = new PersonRepository();

            package.packageId = Convert.ToInt32(dataReader[dataSource.PackageId]);
            var senderId = Convert.ToInt32(dataReader[dataSource.SenderId]);
            var recipientId = Convert.ToInt32(dataReader[dataSource.RecipientId]);
            package.destinationStreet = dataReader[dataSource.DestinationStreet].ToString();
            package.destinationCity = dataReader[dataSource.DestinationCity].ToString();
            package.destinationPostalCode = dataReader[dataSource.DestinationPostalCode].ToString();

            package.sender = _personRepository.GetPerson(senderId);
            package.recipient = _personRepository.GetPerson(recipientId);

            return package;
        }

        public Person GetPersonFromDataReader(MySqlDataReader dataReader, DataSource dataSource)
        {
            Person person = new Person();
            person.id = Convert.ToInt32(dataReader[dataSource.PersonId]);
            person.fName = dataReader[dataSource.FirstName].ToString();
            person.lName = dataReader[dataSource.LastName].ToString();

            return person;
        }
    }
}

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
        public Package ExtractPackageFromDataReader(MySqlDataReader dataReader)
        {
            Package package = new Package(); // optimize when testing
            Person sender = new Person();
            Person recipient = new Person();
            IPersonRepository _personRepository = new PersonRepository();

            package.packageId = Convert.ToInt32(dataReader[0]);
            var senderId = Convert.ToInt32(dataReader[1]);
            var recipientId = Convert.ToInt32(dataReader[2]);

            package.sender = _personRepository.GetPerson(senderId);
            package.recipient = _personRepository.GetPerson(recipientId);

            return package;
        }

        public Person GetPersonFromDataReader(MySqlDataReader dataReader)
        {
            Person person = new Person();
            person.id = Convert.ToInt32(dataReader["personId"]);
            person.fName = dataReader["fName"].ToString();
            person.lName = dataReader["lName"].ToString();

            return person;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using NameGenApp.Database;

namespace NameGenApp.Models.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private MySQLDatabase database;
        private DataSource dataSource;
        private MySqlConnection mySqlConnection;
        private String connectionString;

        private MySqlCommand command;
        private MySqlDataReader dataReader;

        private QueryHandler queryHandler;

        public PersonRepository()
        {
            dataSource = new DataSource();
            connectionString = dataSource.Server + dataSource.Database + dataSource.User + dataSource.Password;
            mySqlConnection = new MySqlConnection(connectionString);
            queryHandler = new QueryHandler();
        }

        public Person GetPerson(int personId)
        {
            Person person = new Person();
            String query = "SELECT * FROM " + dataSource.TablePersons +" WHERE " + dataSource.PersonId + " = " + personId;

            command = new MySqlCommand(query, mySqlConnection);

            mySqlConnection.Open();
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                person = queryHandler.GetPersonFromDataReader(dataReader, dataSource);
            }

            mySqlConnection.Close();

            return person;


        }

        public void CreatePerson(Person person)
        {
            throw new NotImplementedException();
        }
    }

    public interface IPersonRepository
    {
        Person GetPerson(int personId);
        void CreatePerson(Person person);
    }
}

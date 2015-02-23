using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using PostProjectWebServices.Database;

namespace PostProjectWebServices.Models.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private DataSource dataSource;
        private MySqlConnection databaseConnection;
        private String connectionString;

        private MySqlCommand command;
        private MySqlDataReader dataReader;

        private QueryHandler queryHandler;

        public PersonRepository()
        {
            dataSource = new DataSource();
            connectionString = dataSource.Server + dataSource.Database + dataSource.User + dataSource.Password;
            databaseConnection = new MySqlConnection(connectionString);
            queryHandler = new QueryHandler();
        }

        public Person GetPerson(int personId)
        {
            Person person = new Person();
            String query = "SELECT * FROM " + dataSource.TablePersons +" WHERE " + dataSource.PersonId + " = " + personId;

            command = new MySqlCommand(query, databaseConnection);

            databaseConnection.Open();
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                person = queryHandler.GetPersonFromDataReader(dataReader, dataSource);
            }

            databaseConnection.Close();

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
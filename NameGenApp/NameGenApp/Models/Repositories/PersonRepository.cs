﻿using System;
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

        public PersonRepository()
        {
            dataSource = new DataSource();
            connectionString = dataSource.SERVER + dataSource.DATABASE + dataSource.USER + dataSource.PASSWORD;
            mySqlConnection = new MySqlConnection(connectionString);
        }

        public Person GetPerson(int personId)
        {
            Person person = new Person();
            String query = "SELECT * FROM test WHERE id = " + personId;

            command = new MySqlCommand(query, mySqlConnection);

            mySqlConnection.Open();
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                person.id = Convert.ToInt32(dataReader["0"]);
                person.fName = dataReader["1"].ToString();
                person.lName = dataReader["2"].ToString();
            }

            mySqlConnection.Close();



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

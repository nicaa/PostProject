using System;
using MySql.Data.MySqlClient;

namespace NameGenApp.Database
{
    public class MySQLDatabase
    {
        private String connectionString;
        private MySqlConnection con;
        String query1 = "Select * from person";
        private DataSource dataSource;
        
        

        public MySQLDatabase()
        {
            dataSource = new DataSource();
            connectionString = dataSource.SERVER + dataSource.DATABASE + dataSource.USER + dataSource.PASSWORD;
            con = new MySqlConnection(connectionString);
        }

        public void SelectAll()
        {
            con.Open();
            
            MySqlCommand command = new MySqlCommand(query1, con);
            
            MySqlDataReader myReader = command.ExecuteReader();// when reading use ExecuteReader!!
            con.Close();
        }

        public void insertRasmus(String fName, String LName)
        {
            String query2 = "insert INTO person (fName, lName) VALUES('"+fName+"', '"+LName+"')";
            con.Open();
            MySqlCommand command = new MySqlCommand(query2, con);
            command.ExecuteNonQuery();
            con.Close();
        }

        public void deleteID(String id)
        {
            if (id != null) { 
                String query3 = "delete from person Where idPerson="+Convert.ToInt32(id)+"";
                con.Open();
                MySqlCommand command = new MySqlCommand(query3, con);
                command.ExecuteNonQuery();
                con.Close();
            }
        }

    }
}

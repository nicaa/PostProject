using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace NameGenApp.Models
{
    class MySQLDatabase
    {

        String connectionString = "server=localhost;" + "database=test;" + "user=root;" + "password=1234";
        MySqlConnection con;
        String query1 = "Select * from person";
        
        
        

        public MySQLDatabase()
        {
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

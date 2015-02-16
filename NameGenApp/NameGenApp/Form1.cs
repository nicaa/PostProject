
using NameGenApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameGenApp
{
    public partial class Form1 : Form
    {
       // InitRandomPersons randomPerson = new InitRandomPersons();
        Person person = new Person();
        MySQLDatabase mySqlDB = new MySQLDatabase();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

           // randomPerson.addRandomToDb(db);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            mySqlDB.SelectAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mySqlDB.insertRasmus(fName.Text,lName.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mySqlDB.deleteID(IDText.Text);
        }
                   
    }
}

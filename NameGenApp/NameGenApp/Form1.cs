﻿
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
using NameGenApp.Database;
using NameGenApp.PackageServices;

namespace NameGenApp
{
    public partial class Form1 : Form
    {
       
        MySQLDatabase mySqlDB = new MySQLDatabase();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FindPackageForm().Show();
        }

        private void GenRandomButton_Click(object sender, EventArgs e)
        {
            InitRandomPersons randomPerson = new InitRandomPersons();
        }
                   
    }
}


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
using NameGenApp.PackagesServiceReference;
using NameGenApp.Models;

namespace NameGenApp
{
    public partial class Form1 : Form
    {

        InitRandomPersons package;
       
        public Form1()
        {
            InitializeComponent();
            package = new InitRandomPersons();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FindPackageForm().Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            PackageServicesClient client = new PackageServicesClient();
            Package newPackage  = package.getRandomPackage();


            client.CreatePackage(newPackage.recipientFirstName, newPackage.recipientLastName, newPackage.recipientStreet, newPackage.recipientCity, newPackage.recipientPostalCode);
            
            client.CreatePackage("Prut", "Prut", "Snot", "Prut", "Prut");
            
        }
                   
    }
}

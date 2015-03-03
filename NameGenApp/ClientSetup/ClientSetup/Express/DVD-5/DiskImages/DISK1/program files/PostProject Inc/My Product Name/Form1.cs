using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PostProjectClient.Models;
using PostProjectClient.PackageWebService;

namespace PostProjectClient
{
    public partial class Form1 : Form
    {
        private PackageGenerator packageGenerator;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FindPackageForm().Show();
        }

        private void getPackageBtn_Click(object sender, EventArgs e)
        {
            PackageServicesClient client = new PackageServicesClient();
            packageGenerator = new PackageGenerator();

            Package newPackage = packageGenerator.getRandomPackage();
            client.CreatePackage(newPackage.recipientFirstName, newPackage.recipientLastName, newPackage.recipientStreet, newPackage.recipientCity, newPackage.recipientPostalCode);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PackageServicesClient client = new PackageServicesClient();
            client.CountPackagesPerCity();
        }
    }
}

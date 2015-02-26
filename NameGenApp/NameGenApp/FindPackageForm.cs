using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NameGenApp.PackagesServiceReference;
using NameGenApp.ServiceReferenceIIS;
using PostProjectWebServices.Models;

namespace NameGenApp
{
    public partial class FindPackageForm : Form
    {
        public FindPackageForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void packageIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void RecipientAddressLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(packageIdTextBox.Text);
            ServiceReferenceIIS.PackageServicesClient packageServicesClient =
                new ServiceReferenceIIS.PackageServicesClient();
            Package package = packageServicesClient.GetPackage(id);

            firstNameTextBox.Text = package.recipientFirstName;
            lastNameTextBox.Text = package.recipientLastName;
            streetTextBox.Text = package.recipientStreet;
            cityTextBox.Text = package.recipientCity;
            postalCodeTextBox.Text = package.recipientPostalCode;
        }
    }
}

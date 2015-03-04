using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PostProjectClient.PackageWebService;

namespace PostProjectClient
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(packageIdTxtbox.Text);
            PackageServicesClient client = new PackageServicesClient();
            Package package = client.GetPackage(id);

            firstNameTxtbox.Text = package.recipientFirstName;
            lastNameTxtbox.Text = package.recipientLastName;
            streetTxtbox.Text = package.recipientStreet;
            cityTxtbox.Text = package.recipientCity;
            postalCodeTxtbox.Text = package.recipientPostalCode;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NameGenApp.PackageServices;

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
            PackageServicesClient packageServicesClient = new PackageServicesClient();
            packageServicesClient.GetPackage(id);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NameGenApp.Models;
using NameGenApp.Models.Repositories;

namespace NameGenApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            PackageRepository packageRepository = new PackageRepository();
            List<Package> packagesList = packageRepository.GetAllPackages();

            foreach (Package package in packagesList)
            {
                package.PrintPackage();
            }
        }
    }
}

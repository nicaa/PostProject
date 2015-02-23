using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenApp.Models
{
    public class Package
    {
        public int packageId;
        public String recipientFirstName;
        public String recipientLastName;
        public String destinationStreet;
        public String destinationCity;
        public String destinationPostalCode;

        public void PrintPackage()
        {
            Console.WriteLine();
            Console.WriteLine(packageId);
            Console.WriteLine(destinationStreet);
            Console.WriteLine(destinationCity + " " + destinationPostalCode);
            Console.WriteLine(recipientFirstName + " " + recipientLastName);
        }
    }
}

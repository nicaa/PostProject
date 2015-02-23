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
        public String recipientStreet;
        public String recipientCity;
        public String recipientPostalCode;

        public void PrintPackage()
        {
            Console.WriteLine();
            Console.WriteLine(packageId);
            Console.WriteLine(recipientStreet);
            Console.WriteLine(recipientCity + " " + recipientPostalCode);
            Console.WriteLine(recipientFirstName + " " + recipientLastName);
        }
    }
}

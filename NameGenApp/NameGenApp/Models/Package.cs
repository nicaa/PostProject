using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenApp.Models
{
    public class Package
    {
        public int packageId { get; set; }
        public String recipientFirstName { get; set; }
        public String recipientLastName { get; set; }
        public String destinationStreet { get; set; }
        public String destinationCity { get; set; }
        public String destinationPostalCode { get; set; }

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

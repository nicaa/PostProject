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
        public Person sender;
        public Person recipient;

        public String destinationStreet;
        public String destinationCity;
        public String destinationPostalCode;

        public void PrintPackage()
        {
            Console.WriteLine();
            Console.WriteLine(packageId);
            Console.WriteLine(destinationStreet);
            Console.WriteLine(destinationCity + " " + destinationPostalCode);
            Console.WriteLine(sender.fName + " " + sender.lName + " " + sender.id);
            Console.WriteLine(recipient.fName + " " + recipient.lName + " " + recipient.id);
        }
    }
}

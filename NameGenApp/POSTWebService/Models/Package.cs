using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSTWebService.Models
{
    public class Package
    {
        [Key]
        public int PackageId { get; set; }
        public int SenderId { get; set; }
        public int RecipientId { get; set; }

        [ForeignKey("SenderId")]
        public Person Sender { get; set; }
        [ForeignKey("RecipientId")]
        public Person Recipient { get; set; }
        public String DestinationStreet { get; set; }
        public String DestinationCity { get; set; }
        public String DestinationPostalCode { get; set; }

        public void PrintPackage()
        {
            Console.WriteLine();
            Console.WriteLine(PackageId);
            Console.WriteLine(DestinationStreet);
            Console.WriteLine(DestinationCity + " " + DestinationPostalCode);
            Console.WriteLine(Sender.FirstName + " " + Sender.LastName + " " + Sender.PersonId);
            Console.WriteLine(Recipient.FirstName + " " + Recipient.LastName + " " + Recipient.PersonId);
        }
    }
}

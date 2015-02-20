using System;
using System.ComponentModel.DataAnnotations;

namespace POSTWebService.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
    }
}

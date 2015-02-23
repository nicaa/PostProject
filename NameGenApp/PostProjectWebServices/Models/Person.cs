using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PostProjectWebServices.Models
{
    public class Person
    {
        [Key]
        public int id { get; set; }
        public String fName { get; set; }
        public String lName { get; set; }
    }
}
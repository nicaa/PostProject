using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NameGenApp.Models
{
    public class Person
    {
        [Key]
        public int id { get; set; }
        public String fName { get; set; }
        public String lName { get; set; }
       


    }
}

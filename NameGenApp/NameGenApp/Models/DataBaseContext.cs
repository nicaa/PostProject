using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenApp.Models
{
    class DataBaseContext : DbContext
    {
        public DbSet<Person> peson {get; set;}
    }
}

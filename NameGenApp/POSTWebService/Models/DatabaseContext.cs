using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace POSTWebService.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Rasmus\\Documents\\GitHub\\PostProject\\NameGenApp\\POSTWebService\\App_Data\\PostDatabase.mdf;Initial Catalog=PostDatabase;Integrated Security=True;Connect Timeout=30")
        {
            
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Package> Packages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Entity<Package>()
            .HasRequired(u => u.Sender)
            .WithMany()
            .WillCascadeOnDelete(false);
        }
    }
}
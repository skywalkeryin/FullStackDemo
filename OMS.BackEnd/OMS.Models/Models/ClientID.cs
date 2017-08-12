using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace OMS.Models.Models
{
    class ClientID : DbContext
    {
        public ClientID() : base("name=OMS.ClientDB")
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }
        public DbSet<StudentAddress> StudentAddress { get; set; }

        //    protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //    {
        //        //Configure domain classes using Fluent API here
        //        modelBuilder.Entity<Student>().HasOptional(s => s.Address).WithRequired(ad => ad.Student);
        //        modelBuilder.Entity<Student>().HasRequired(s => s.Standard).WithMany(st => st.Students);

        //        base.OnModelCreating(modelBuilder);
        //    }
        //}
    }
}

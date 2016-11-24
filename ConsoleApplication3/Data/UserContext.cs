using ConsoleApplication3.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3.Data
{
    public class UserContext : DbContext
    {
        public UserContext() : base ("name=ConnectionStringName")
        {

        }

        static UserContext()
        {
            Database.SetInitializer<UserContext>(null);
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("User");
            base.OnModelCreating(modelBuilder);
        }
    }
}

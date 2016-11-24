using ConsoleApplication3.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3.Data
{
    class DocumentContext : DbContext
    {
        public DocumentContext() : base("name=ConnectionStringName")
        {
            
        }

        static DocumentContext()
        {
            Database.SetInitializer<DocumentContext>(null);
        }

        public DbSet<Document> Documents { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Document");
            modelBuilder.Entity<User>().ToTable("Users", "User");
            base.OnModelCreating(modelBuilder);
        }
    }
}

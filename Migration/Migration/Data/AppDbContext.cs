using Microsoft.EntityFrameworkCore;
using ORM_Migration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Migration.Data
{
    internal class AppDbContext:DbContext
    {
        public DbSet<Library> Libraries { get; set; }
        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Library;TrustServerCertificate=true;Trusted_Connection=true;");
        }
    }
}

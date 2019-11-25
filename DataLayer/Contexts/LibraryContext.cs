using DataLayer.Configuration;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace DataLayer.Contexts
{
    public class LibraryContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibDB;User Id=LibUser;Password=P@ssw0rd;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}

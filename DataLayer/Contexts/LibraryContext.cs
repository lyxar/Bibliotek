using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Contexts
{
    public class LibraryContext : DbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Book> Books { get; set; }

        public LibraryContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}

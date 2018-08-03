using Microsoft.EntityFrameworkCore;
using System;
using YourLibrary.Models;

namespace YourLibrary.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}

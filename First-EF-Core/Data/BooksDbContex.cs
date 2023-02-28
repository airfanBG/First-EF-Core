using First_EF_Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_EF_Core.Data
{
    public class BooksDbContex:DbContext
    {

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        public DbSet<AuthorBooks>AuthorBooks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=BooksStore;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
           
        //}
    }
}

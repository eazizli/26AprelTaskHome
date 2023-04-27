using _26AprelTaskHome.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26AprelTaskHome.Datacontext
{
    internal class Taskcontexs :DbContext
    {
       // public object Books { get; internal set; }
      public  DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {optionsBuilder.UseSqlServer("Server=.;Database=BooksDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}

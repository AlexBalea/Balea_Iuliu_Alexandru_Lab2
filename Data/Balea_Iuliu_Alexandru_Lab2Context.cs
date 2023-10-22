using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Balea_Iuliu_Alexandru_Lab2.Models;

namespace Balea_Iuliu_Alexandru_Lab2.Data
{
    public class Balea_Iuliu_Alexandru_Lab2Context : DbContext
    {
        public Balea_Iuliu_Alexandru_Lab2Context (DbContextOptions<Balea_Iuliu_Alexandru_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Balea_Iuliu_Alexandru_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Balea_Iuliu_Alexandru_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Balea_Iuliu_Alexandru_Lab2.Models.Author>? Author { get; set; }
    }
}

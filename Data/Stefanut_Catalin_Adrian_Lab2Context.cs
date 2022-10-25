using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Stefanut_Catalin_Adrian_Lab2.Models;

namespace Stefanut_Catalin_Adrian_Lab2.Data
{
    public class Stefanut_Catalin_Adrian_Lab2Context : DbContext
    {
        public Stefanut_Catalin_Adrian_Lab2Context (DbContextOptions<Stefanut_Catalin_Adrian_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Stefanut_Catalin_Adrian_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Stefanut_Catalin_Adrian_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Stefanut_Catalin_Adrian_Lab2.Models.Author> Author { get; set; }

        public DbSet<Stefanut_Catalin_Adrian_Lab2.Models.Category> Category { get; set; }
    }
}

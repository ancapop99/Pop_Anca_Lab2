using Microsoft.EntityFrameworkCore;
using Pop_Anca_LAb2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pop_Anca_LAb2.Data
{
    public class Pop_Anca_LAb2Context : DbContext
    {
        public Pop_Anca_LAb2Context(DbContextOptions<Pop_Anca_LAb2Context> options)
            : base(options)
        {
        }

        public DbSet<Pop_Anca_LAb2.Models.Book> Book { get; set; } = default!;

        public DbSet<Pop_Anca_LAb2.Models.Publisher> Publisher { get; set; }

        public DbSet<Pop_Anca_LAb2.Models.Category> Category { get; set; }
    }
}

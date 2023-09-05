using Microsoft.EntityFrameworkCore;
using RantlhagoSM_Assign1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RantlhagoSM_Assign1.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
          : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}

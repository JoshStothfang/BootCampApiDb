using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BootCampApiDb.Models;

namespace BootCampApiDb.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; } = default!;

        public DbSet<Assessment> Assessments { get; set; } = default!;

        public DbSet<Score> Scores { get; set; } = default!;
    }
}

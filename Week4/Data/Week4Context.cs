using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Week4.Models;

namespace Week4.Data
{
    public class Week4Context : DbContext
    {
        public DbSet<Week4.Models.Movie> Movie { get; set; }
        public Week4Context(DbContextOptions<Week4Context> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Models.Movie>().HasData(new Models.Movie()
            {
                ID = Guid.NewGuid(),
                Name = "Movie1",
                Year = 2000,
                Type = "Action",
            });
            } 
    }
}

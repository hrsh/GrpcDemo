using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GrpcDemo.Server
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BookEntity> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BookEntity>().HasData(new List<BookEntity>
            {
                new(1, "Book1"),
                new(2, "Book2"),
                new(3, "Book3"),
                new(4, "Book4")
            });
        }
    }
}

using Data.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {
        }

        public DbSet<Auction> Auctions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Auction>(entity =>
            {
                entity.HasKey(p => p.Id);
            });
        }
    }
}

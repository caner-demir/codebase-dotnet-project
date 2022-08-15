using Layered.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layered.DAL.Concrete.EntityFramework
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Layered;Trusted_Connection=true");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerProduct>()
                .HasKey(cp => new { cp.CustomerId, cp.ProductId, cp.Date });
            modelBuilder.Entity<CustomerProduct>()
                .HasOne(cp => cp.Product)
                .WithMany(p => p.CustomerProducts)
                .HasForeignKey(cp => cp.ProductId);
            modelBuilder.Entity<CustomerProduct>()
                .HasOne(cp => cp.Customer)
                .WithMany(c => c.CustomerProducts)
                .HasForeignKey(cp => cp.CustomerId);
        }

        public DbSet<Product>? Products { get; set; }
        public DbSet<Customer>? Customers { get; set; }
        public DbSet<CustomerProduct>? CustomerProducts { get; set; }
    }
}

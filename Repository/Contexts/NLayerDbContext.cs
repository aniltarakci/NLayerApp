using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Contexts
{
    public class NLayerDbContext : DbContext
    {
        public NLayerDbContext(DbContextOptions<NLayerDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<ProductFeature>().HasData(
                new ProductFeature() { Id = 1, ProductId = 1, Color = "Kırmızı", Height = 3513, Width = 492 },
                new ProductFeature() { Id = 2, ProductId = 2, Color = "Mavi", Height = 65, Width = 42 },
                new ProductFeature() { Id = 3, ProductId = 3, Color = "Pembe", Height = 249, Width = 56 }
                );

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }
    }
}

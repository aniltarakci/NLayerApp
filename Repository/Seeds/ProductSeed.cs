using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, CategoryId = 1, Name = "Kalem 1", Price = 42, Stock = 30, CreatedDate = DateTime.Now },
                new Product { Id = 2, CategoryId = 2, Name = "Kitap 1", Price = 123, Stock = 42, CreatedDate = DateTime.Now },
                new Product { Id = 3, CategoryId = 3, Name = "Defter 1", Price = 53, Stock = 67, CreatedDate = DateTime.Now }
                );
        }
    }
}

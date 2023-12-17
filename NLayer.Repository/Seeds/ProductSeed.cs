using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Entities;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Name = "Tükenmez Kalem",
                    Stock = 20,
                    Price = 50,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 1,
                    Name = "Uçlu Kalem",
                    Stock = 50,
                    Price = 40,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 2,
                    Name = "TYT Matematik",
                    Stock = 15,
                    Price = 150,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 4,
                    CategoryId = 2,
                    Name = "AYT Matematik",
                    Stock = 10,
                    Price = 200,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 5,
                    CategoryId = 3,
                    Name = "60 Yaprak Kareli Defter",
                    Stock = 28,
                    Price = 50,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 6,
                    CategoryId = 3,
                    Name = "90 Yaprak Telli Çizgili Defter",
                    Stock = 36,
                    Price = 70,
                    CreatedDate = DateTime.Now
                }
            );
        }
    }
}

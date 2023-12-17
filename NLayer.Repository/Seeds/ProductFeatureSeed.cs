using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Entities;

namespace NLayer.Repository.Seeds
{
    internal class ProductFeatureSeed : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasData(
                new ProductFeature
                {
                    Id = 1,
                    ProductId = 1,
                    Color = "Siyah",
                    Height = 10,
                    Width = 1
                },
                new ProductFeature
                {
                    Id = 2,
                    ProductId = 3,
                    Color = "Beyaz",
                    Height = 25,
                    Width = 15
                }
            );
        }
    }
}

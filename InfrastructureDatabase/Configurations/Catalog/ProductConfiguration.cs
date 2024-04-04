
using ECommerce.DomainCore.Catalogs.Features;
using ECommerce.DomainCore.Catalogs.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ECommerce.InfrastructureDatabase.Configurations.Catalog
{
    internal sealed class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products", "Catalog");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
            .HasConversion(
                v => v.Value,
                v => new ProductId(v));

            builder.Property(e => e.Title)
            .HasMaxLength(256).IsRequired();

            builder.Property(e => e.Code)
          .HasMaxLength(16).IsRequired();

            builder.OwnsMany(s => s.ProductFeatureValues, y =>
            {
                y.WithOwner().HasForeignKey("ProductId");

                y.ToTable("ProductFeatureValues", "Catalog");

                y.Property(x => x.ProductId)
                .HasConversion(
                    v => v.Value,
                    v => new ProductId(v));

                y.Property(x => x.FeatureId)
                .HasConversion(
                    v => v.Value,
                    v => new FeatureId(v));

                y.HasKey("ProductId", "FeatureId");

            });


        }
    }
}

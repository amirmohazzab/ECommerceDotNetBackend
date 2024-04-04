
using ECommerce.DomainCore.Catalogs.Features;
using ECommerce.DomainCore.Catalogs.Categories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.InfrastructureDatabase.Configurations.Catalog
{
    internal sealed class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories", "Catalog");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
            .HasConversion(
                v => v.Value,
                v => new CategoryId(v));

            builder.Property(e => e.CategoryName)
            .HasMaxLength(128).IsRequired();

            builder.Property(e => e.Description).HasMaxLength(1024);

            builder.OwnsMany(s => s.CategoryFeatures, y =>
            {
                y.WithOwner().HasForeignKey("CategoryId");

                y.ToTable("CategoryFeatures", "Catalog");

                y.Property(x => x.CategoryId)
                .HasConversion(
                    v => v.Value,
                    v => new CategoryId(v));

                y.Property(x => x.FeatureId)
                .HasConversion(
                    v => v.Value,
                    v => new FeatureId(v));

                y.HasKey("CategoryId", "FeatureId");

            });


        }
    }
}

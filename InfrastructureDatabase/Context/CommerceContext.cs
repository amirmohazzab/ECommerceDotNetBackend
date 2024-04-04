
using ECommerce.DomainCore.Catalogs.Categories;
using ECommerce.DomainCore.Catalogs.Features;
using ECommerce.DomainCore.Catalogs.Products;
using Microsoft.EntityFrameworkCore;


namespace ECommerce.InfrastructureDatabase.Context
{
    public class CommerceContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Product> Products { get; set; }

        public CommerceContext(DbContextOptions<CommerceContext> options):base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CommerceContext).Assembly);
        }
    }
}

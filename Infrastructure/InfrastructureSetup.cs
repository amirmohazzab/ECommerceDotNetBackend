
using DevTubeCommerce.Infrastructure.Patterns;
using DevTubeCommerce.Infrastructure.Repositories.Catalog;
using ECommerce.DomainCore.Catalogs.Features;
using ECommerce.Infrastructure.Patterns;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.Infrastructure
{
    public static class InfrastructureSetup
    {
        public static void AddInfrastructureRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IFeatureRepository, FeatureRepository>();
        }
    }
}
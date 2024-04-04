
using ECommerce.Application.Services.Catalog;
using ECommerce.ApplicationContract.Interfaces.Catalog;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.Application
{
    public static class ApplicationServiceSetup
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IFeatureService, FeatureService>();
        }
    }
}

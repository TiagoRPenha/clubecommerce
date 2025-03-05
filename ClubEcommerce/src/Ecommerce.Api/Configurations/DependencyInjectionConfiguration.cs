using Ecommerce.Business.Interfaces.Repositories;
using Ecommerce.Business.Services;
using Ecommerce.Business.Services.Interfaces;
using Ecommerce.Infrastructure.Repositories;

namespace Ecommerce.Api.Configurations
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceCollection ResolveDependencyInjection(this IServiceCollection services)
        {
            // Repositories
            services.AddScoped(typeof(IBaseRepository<>),typeof(BaseRepository<>));
            services.AddScoped<IProductRepository, ProductRepository>();

            // Services
            services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
            
            return services;
        }
    }
}

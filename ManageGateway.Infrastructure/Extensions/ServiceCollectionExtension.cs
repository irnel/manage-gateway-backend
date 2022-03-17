using ManageGateway.Application.Interfaces.Services;
using ManageGateway.Domain.Enums;
using ManageGateway.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ManageGateway.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services)
        {
            // Register Services
            services.AddTransient<IGatewayService, GatewayService>();
            services.AddTransient<IDeviceService, DeviceService>();

            // Cache Services
            services.AddTransient<MemoryCacheService>();
            services.AddTransient<RedisCacheService>();
            services.AddTransient<Func<CacheTech, ICacheService>>(serviceProvider => key =>
            {
                return key switch
                {
                    CacheTech.Redis => serviceProvider.GetService<RedisCacheService>(),
                    CacheTech.Memory => serviceProvider.GetService<MemoryCacheService>(),
                    _ => serviceProvider.GetService<MemoryCacheService>(),
                };
            });

            return services;
        }
    }
}

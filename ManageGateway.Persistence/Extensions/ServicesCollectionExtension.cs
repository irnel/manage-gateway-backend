using Hangfire;
using ManageGateway.Application.Configurations;
using ManageGateway.Application.Interfaces.Repositories;
using ManageGateway.Application.Interfaces.Repositories.Base;
using ManageGateway.Persistence.AppContext;
using ManageGateway.Persistence.Repositories;
using ManageGateway.Persistence.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ManageGateway.Persistence.Extensions
{
    public static class ServicesCollectionExtension
    {
        public static IServiceCollection AddPersistenceLayer(this IServiceCollection services, IConfiguration config)
        {
            // DbContext Config
            services.AddDbContext<ApplicationDbContext>(
                options => options.UseSqlServer(
                    config.GetConnectionString("Default"),
                    b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName))
            );

            services.AddDatabaseDeveloperPageExceptionFilter();

            // For In-Memory Caching
            services.AddMemoryCache();
            services.Configure<CacheConfiguration>(config.GetSection("CacheConfiguration"));

            // Configure Background Job (Hangfire)
            services.AddHangfire(x => x.UseSqlServerStorage(config.GetConnectionString("Default")));
            services.AddHangfireServer();

            // Repositories
            services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddTransient<IGatewayRepository, GatewayRepository>();
            services.AddTransient<IDeviceRepository, DeviceRepository>();

            return services;
        }
    }
}

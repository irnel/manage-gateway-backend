using ManageGateway.Application.Mappers;
using Microsoft.Extensions.DependencyInjection;

namespace ManageGateway.Application.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
        {
            // Configure AutoMapper
            services.AddAutoMapper(typeof(MapperProfile));

            return services;
        }
    }
}

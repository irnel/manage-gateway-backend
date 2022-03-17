using FluentValidation.AspNetCore;
using ManageGateway.Application.Configurations;

namespace ManageGateway.Server.Extensions
{
    internal static class MvcBuilderExtensions
    {
        public static IMvcBuilder AddValidators(this IMvcBuilder builder)
        {
            return builder.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<AppConfiguration>());
        }
    }
}

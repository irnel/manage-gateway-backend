using ManageGateway.Server.Middlewares;

namespace ManageGateway.Server.Extensions
{
    internal static class ApplicationBuilderExtensions
    {
        internal static void UseCustomMiddlewares(this IApplicationBuilder app)
        {
            app.UseMiddleware<ErrorHandlerMiddleware>();
        }
    }
}

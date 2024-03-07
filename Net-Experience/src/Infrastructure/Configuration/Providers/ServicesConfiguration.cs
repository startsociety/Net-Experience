using Microsoft.Extensions.DependencyInjection;
using Net.Experience.Domain.Interfaces.Services;
using Net.Experience.Application.Services;

namespace Net.Experience.Configuration.Providers
{
    public static class ServiceConfiguration
    {
        public static IServiceCollection AddServiceConfiguration(this IServiceCollection services)
        {
            //Item
            services.AddScoped<IItemService, ItemService>();

            //Users
            services.AddScoped<IUserService, UserService>();

            //Authentication
            services.AddScoped<IAuthenticationService, AuthenticationService>();

            //TOKEN
            services.AddScoped<ITokenService, TokenService>();

            return services;
        }
    }
}

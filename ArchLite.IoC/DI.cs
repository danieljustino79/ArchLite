using ArchLite.Application.Services;
using ArchLite.Application.Services.Implementations;
using ArchLite.Data.Repositories;
using ArchLite.Data.Repositories.Implementations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ArchLite.IoC
{
    public static class DI
    {
        static void Main() { }

        public static void AddIoCBootstrapperServices(this IServiceCollection services, 
            IConfiguration configuration)
        {
            services.AddApplicationServices();
            services.AddDataServices();
        }

        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
        }

        public static void AddDataServices(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}

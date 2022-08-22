using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TsManager.Persistence.Context;

namespace TsManager.Persistence.Services
{
    public static class PersistenceService
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
           IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseOracle(
                    configuration.GetConnectionString("DEV"),
                    b => b.MigrationsAssembly(typeof(AppDbContext)
                            .Assembly.FullName)));

            return services;
        }

    }
}

using Sagep.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace SigespWeb.Api.ProgramConfigurations
{
    public static class DataBaseConfiguration
    {
        public static void AddDataBaseConfiguration(this IServiceCollection services, IConfiguration configuration, IWebHostEnvironment env)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddDbContext<SagepAppDbContext>(options => {
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
                
                if (!env.IsProduction())
                {
                    options.EnableDetailedErrors();
                    options.EnableSensitiveDataLogging(true);
                }
            });
        }
    }
}
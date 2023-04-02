namespace Sagep.Api.ProgramConfigurations
{
    public static class CorsConfiguration
    {
        public static void AddCorsConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddCors(options => 
            { 
                options.AddPolicy("DevelopmentPermission", policy => 
                { policy.AllowAnyHeader( 
                    ) 
                        .AllowAnyMethod() 
                        .WithOrigins("http://localhost:3000")
                        .AllowCredentials(); 
                }); 
            });
        }
    }
}   
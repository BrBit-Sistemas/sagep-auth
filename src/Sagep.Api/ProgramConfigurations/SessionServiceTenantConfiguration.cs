namespace SigespWeb.Api.ProgramConfigurations
{
    public static class SessionServiceTenantConfiguration
    {
        public static void AddSessionServiceTenantConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromSeconds(1);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
        }
    }
}
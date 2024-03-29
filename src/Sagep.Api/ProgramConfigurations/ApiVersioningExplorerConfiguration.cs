namespace Sagep.Api.ProgramConfigurations
{
    public static class ApiVersioningExplorerConfiguration
    {
        public static void AddApiVersioningExplorerConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddVersionedApiExplorer(o => {
                o.GroupNameFormat = "'v'VVV";
                o.SubstituteApiVersionInUrl = true;
            });
        }
    }
}
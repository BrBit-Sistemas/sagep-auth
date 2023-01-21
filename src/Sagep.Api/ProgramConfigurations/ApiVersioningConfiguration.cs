using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;

namespace SigespWeb.Api.ProgramConfigurations
{
    public static class ApiVersioningConfiguration
    {
        public static void AddApiVersioningConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddApiVersioning(o => {
                o.DefaultApiVersion = new ApiVersion(2, 0);
                o.AssumeDefaultVersionWhenUnspecified = true;
                o.ReportApiVersions = true;
                o.ApiVersionReader = ApiVersionReader.Combine(new UrlSegmentApiVersionReader(),
                                                              new HeaderApiVersionReader("x-api-version"),
                                                              new MediaTypeApiVersionReader("x-api-version"));
            });
        }
    }
}   
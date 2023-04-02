using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.OpenApi.Models;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Sagep.Api.ProgramConfigurations
{
    public class ConfigureSwaggerOptions : IConfigureNamedOptions<SwaggerGenOptions>
    {
        private readonly IApiVersionDescriptionProvider _provider;

        public ConfigureSwaggerOptions(IApiVersionDescriptionProvider provider)
        {
            _provider = provider;
        }

        /// <summary>
        /// Configure each API discovered for Swagger Documentation
        /// </summary>
        /// <param name="options"></param>
        public void Configure(SwaggerGenOptions options)
        {
            // add swagger document for every API version discovered
            foreach (var description in _provider.ApiVersionDescriptions)
            {
                options.SwaggerDoc(
                    description.GroupName,
                    CreateVersionInfo(description));
            }   
        }

        /// <summary>
        /// Configure Swagger Options. Inherited from the Interface
        /// </summary>
        /// <param name="name"></param>
        /// <param name="options"></param>
        public void Configure(string? name, SwaggerGenOptions options)
        {
            Configure(options);
        }

        /// <summary>
        /// Create information about the version of the API
        /// </summary>
        /// <param name="desc"></param>
        /// <returns>Information about the API</returns>
        private OpenApiInfo CreateVersionInfo(ApiVersionDescription desc)
        {
            var info = new OpenApiInfo()
            {
                Version = desc.ApiVersion.ToString(),
                Title = "Sagep Authentication and Authorization",
                Description = "Sagep Auth",
                TermsOfService = new Uri("https://www.sagep.com.br/terms-service"),
                Contact = new OpenApiContact
                {
                    Name = "Br Bit Sistemas",
                    Url = new Uri("https://www.brbit.com.br")
                },
                License = new OpenApiLicense
                {
                    Name = "Br Bit Sistemas License",
                    Url = new Uri("https://www.sagep.com.br/license")
                }
            };

            if (desc.IsDeprecated)
            {
                info.Description += " | Esta versão de API está depreciada. Por favor utilize a última versão para obter todos os recursos mais recentes.";
            }

            return info;
        }
    }
}
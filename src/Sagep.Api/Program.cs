using SigespWeb.Api.ProgramConfigurations;
using SigespWeb.Api.Middlewares;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Sagep.Api.Extensions;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("appsettings.json", true, true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", true, true)
    .AddEnvironmentVariables();

// Add services to the container.

builder.Services.AddControllers()
                                .AddJsonOptions(options =>
                                {
                                    options.JsonSerializerOptions.WriteIndented = true;
                                    options.JsonSerializerOptions.Converters.Add(new CustomJsonConverterForTypeExtensions());
                                    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
                                });

builder.Services.AddEndpointsApiExplorer();

// ----- Api version -----
builder.Services.AddApiVersioningConfiguration();

// ----- Api version explorer -----
builder.Services.AddApiVersioningExplorerConfiguration();

// ----- Swagger -----
builder.Services.AddSwaggerGenConfiguration();

// ----- Swagger Options -----
builder.Services.ConfigureOptions<ConfigureSwaggerOptions>();

// ----- DB Contexts -----
builder.Services.AddDataBaseConfiguration(builder.Configuration, builder.Environment);

// ----- AutoMapper -----
builder.Services.AddAutoMapperConfiguration();

// ----- Authentication & Authorization -----
builder.Services.AddAuthConfiguration(builder.Configuration);

// ----- HttpContextAccessor -----
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

// ----- .NET Native DI Abstraction -----
builder.Services.AddDependencyInjectionConfiguration();

// ----- IDistributedCache -----
builder.Services.AddDistributedMemoryCache();

// ----- Session to middleware of tenancy -----
builder.Services.AddSessionServiceTenantConfiguration();

// ----- Log services -----
builder.Services.AddLogging(loggingBuilder => {
                                loggingBuilder.AddConsole()
                                    .AddFilter(DbLoggerCategory.Database.Command.Name, LogLevel.Information);
                                loggingBuilder.AddDebug();
                            });

// ----- Add Cors config -----
builder.Services.AddCorsConfiguration();

// ----- Add filter Authorization -----
builder.Services.AddMvc(config =>
                        {
                            var policy = new AuthorizationPolicyBuilder()
                                            .RequireAuthenticatedUser()
                                            .Build();
                            config.Filters.Add(new AuthorizeFilter(policy));
                        });

var app = builder.Build();

var apiVersionDescriptionProvider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        foreach (var description in apiVersionDescriptionProvider.ApiVersionDescriptions.Reverse())
        {
            c.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json",
                description.GroupName.ToUpperInvariant());
        }
    });
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseCors("DevelopmentPermission");

app.UseSession();
app.UseMiddleware<TenantSecurityMiddleware>();

app.MapControllers();

app.Run();

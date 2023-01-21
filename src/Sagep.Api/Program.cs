using SigespWeb.Api.ProgramConfigurations;
using SigespWeb.Api.Middlewares;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("appsettings.json", true, true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", true, true)
    .AddEnvironmentVariables();

// Add services to the container.

builder.Services.AddControllers();

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

app.UseAuthentication();
app.UseAuthorization();

app.UseSession();
app.UseMiddleware<TenantSecurityMiddleware>();

app.MapControllers();

app.Run();

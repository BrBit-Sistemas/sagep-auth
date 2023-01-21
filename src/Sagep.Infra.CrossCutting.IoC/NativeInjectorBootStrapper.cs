using Microsoft.Extensions.DependencyInjection;
using Sagep.Infra.Data.UoW;
using Sagep.Domain.Interfaces;
using Sagep.Infra.CrossCutting.Identity.Services;
using Sagep.Infra.Data.Services;
using Sagep.Infra.Data.Repository;
using Sagep.Application.Interfaces;
using Sagep.Application.AppServices;
using Sagep.Domain.Security;
using Microsoft.AspNetCore.Http;

namespace Sagep.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // AppServices            

            // Services

            // Infra Data - Repositories ...
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ITenantRepository, TenantRepository>();
            services.AddScoped<IApplicationUserRepository, ApplicationUserRepository>();

            // Application
            services.AddScoped<INavigationAppService, NavigationAppService>();

            // Providers
            services.AddTransient<ITenantProvider, TenantProvider>();
            services.AddTransient<IUserProvider, UserProvider>();
            services.AddTransient<ITokenProvider, TokenProvider>();

            // Tipo	Mesma requisição	Requisições diferentes

            // Singleton	Mesma instância	Mesma instância
            // Scoped	    Mesma instância	Nova instância
            // Transient	Nova instância	Nova instância
            
            // Singleton: é criada uma única instância para todas requisições. Em outras palavras, é criada uma instância a primeira vez que é solicitada e todas as vezes seguintes a mesma instância é usada (design patter singleton);
            // Scoped: é criada uma única instância por requição. Ou seja, usando o exemplo de uma aplicação Web, quando recebe uma nova requisição, por exemplo, um click num botão do outro lado do navegador, é criada uma instância, onde o escopo é essa requisição. Então se for necessária a dependência multiplas vezes na mesma requisição a mesma instância será usada. Seria como um "Singleton para uma requisição";
            // Transient: sempre é criada uma nova instância cada vez que for necessário, independentede da requisição, basicamente new XXX cada vez que for necessário.
        }
    }
}
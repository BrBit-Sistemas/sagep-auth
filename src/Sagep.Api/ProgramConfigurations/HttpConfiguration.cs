using Polly;
using Polly.Extensions.Http;
using Sagep.Application.HttpServices;

namespace Sagep.Api.ProgramConfigurations
{
    public static class HttpExtension
    {
        public static IServiceCollection AddHttpFactory(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddHttpClient("SAGEP_NFSE", c =>
                {
                    var baseAddress = configuration.GetValue<string>("HttpClients:SAGEP_NFSE");
                    if (baseAddress is null)
                    {
                        throw new ArgumentException("SAGEP_NFSE base address not found in configuration.");
                    }
                    c.BaseAddress = new Uri(baseAddress);
                })
                .AddTransientHttpErrorPolicy(p => p.WaitAndRetryAsync(5, _ => TimeSpan.FromMilliseconds(500)))
                .AddPolicyHandler(GetRetryPolicy())
                .AddTypedClient(c => Refit.RestService.For<ISagepNfseServices>(c));
            
            services
                .AddHttpClient("SAGEP_CARCERAGEM", c =>
                {
                    var baseAddress = configuration.GetValue<string>("HttpClients:SAGEP_CARCERAGEM");
                    if (baseAddress is null)
                    {
                        throw new ArgumentException("SAGEP_CARCERAGEM base address not found in configuration.");
                    }
                    c.BaseAddress = new Uri(baseAddress);
                })
                .AddTransientHttpErrorPolicy(p => p.WaitAndRetryAsync(5, _ => TimeSpan.FromMilliseconds(500)))
                .AddPolicyHandler(GetRetryPolicy())
                .AddTypedClient(c => Refit.RestService.For<ISagepCarceragemServices>(c));
            
            return services;
        }

        /// <summary>
        /// Define a política de repetição e resiliência para lidar com falhas temporárias nas chamadas HTTP.
        /// A política é configurada para lidar com erros de conexão temporários, que são aqueles que ocorrem por questões de rede ou temporariamente, como limitação de recursos do servidor.
        /// A política realiza tentativas de reconexão em caso de falha, utilizando uma fórmula exponencial para definir o tempo de espera entre as tentativas. O tempo de espera é baseado na tentativa, seguindo a fórmula 2^tentativa.
        /// Neste caso, a política está configurada para realizar 5 tentativas, com um tempo de espera entre as tentativas seguindo a fórmula 2^tentativa.
        /// </summary>
        /// <returns>A política de repetição e resiliência para lidar com falhas temporárias nas chamadas HTTP.</returns>
        private static IAsyncPolicy<HttpResponseMessage> GetRetryPolicy()
        {
            return HttpPolicyExtensions
                .HandleTransientHttpError()
                .WaitAndRetryAsync(5, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)));
        }
    }
}

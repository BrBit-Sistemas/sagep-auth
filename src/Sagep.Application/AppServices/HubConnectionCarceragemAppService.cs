
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Sagep.Application.HttpServices;
using Sagep.Application.Interfaces;
using Sagep.Application.ViewModels;

namespace Sagep.Domain.Services
{
    public class HubConnectionCarceragemAppService : IHubConnectionCarceragemAppService
    {
        private readonly ILogger<HubConnectionCarceragemAppService> _logger;
        private readonly ISagepCarceragemServices _sagepCarceragemService;
        

        public HubConnectionCarceragemAppService(ILogger<HubConnectionCarceragemAppService> logger,
                                                ISagepCarceragemServices sagepCarceragemService)
        {
            _logger = logger;
            _sagepCarceragemService = sagepCarceragemService;
        }

        public async Task<IEnumerable<DetentoViewModel>> GetAllAsync()
        {
            var detentos = await _sagepCarceragemService.GetAllAsync("Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI4ZTQ0NTg2NS1hMjRkLTQ1NDMtYTZjNi05NDQzZDA0OGNkYjkiLCJ1bmlxdWVfbmFtZSI6ImFsYW4ucmV6ZW5kZWVlZUBob3RtYWlsLmNvbSIsInJvbGUiOiJNYXN0ZXIiLCJuYmYiOjE2ODA0NjYzMjQsImV4cCI6MTY4MTA3MTEyNCwiaWF0IjoxNjgwNDY2MzI0fQ.UqoR6q4kIQ6oc2a7PjwkIFJFXuF9210wu5vm7YZgdJI");
            return detentos;
        }
    }
}
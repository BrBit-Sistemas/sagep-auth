
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using AutoMapper;
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
            var detentos = await _sagepCarceragemService.GetAllAsync();
            return detentos;
        }
    }
}
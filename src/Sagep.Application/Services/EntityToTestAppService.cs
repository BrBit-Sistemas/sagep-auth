using System;
using AutoMapper;
using Sagep.Domain.Models;
using Sagep.Application.ViewModels;
using Sagep.Application.Interfaces;
using Sagep.Domain.Interfaces;

namespace Sagep.Application.Services
{
    public class EntityToTestAppService : IEntityToTestAppService
    {
        private readonly IEntityToTestRepository _entityToTestRepository;
        private readonly IMapper _mapper;

        public EntityToTestAppService(IEntityToTestRepository entityToTestRepository,
                                      IMapper mapper)
        {
            _entityToTestRepository = entityToTestRepository;
            _mapper = mapper; 
        }
        
        public bool Add(DetentoViewModel viewModel)
        {
            if (viewModel.Id == Guid.Empty)
            {
                throw new Exception("O GUID é vazio!");
            }

            if (viewModel.Id != Guid.Empty)
            {
                throw new Exception("O GUID não é vazio!");
            }

            // Map
            var detentoMapped = _mapper.Map<Detento>(viewModel);
            _entityToTestRepository.Add(detentoMapped);

            return true;
        }
        
        public void Dispose()
        {
            _entityToTestRepository.Dispose();
        }
    }
}
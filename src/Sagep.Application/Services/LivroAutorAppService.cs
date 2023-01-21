using System.Security.Cryptography;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Sagep.Domain.Interfaces;
using Sagep.Domain.Models;
using Sagep.Application.Interfaces;
using Sagep.Application.ViewModels;
using Sagep.Application.Extensions;
using Sagep.Application.ViewModels.Selects;
using Sagep.Domain.Enums;
using Sagep.Application.ViewModels.Detentos;
using System.Numerics;

namespace Sagep.Application.Services
{
    public class LivroAutorAppService : ILivroAutorAppService
    {
        private readonly ValidationResult _validationResult;
        private readonly ILivroAutorRepository _livroAutorRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public LivroAutorAppService(ValidationResult validationResult,
                                    ILivroAutorRepository livroAutorRepository, 
                                    IUnitOfWork unitOfWork, IMapper mapper)
        {
            _validationResult = validationResult;
            _livroAutorRepository = livroAutorRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<LivroAutorViewModel> GetByIdAsync(int id)
        {
            try
            {
                var autor = await _livroAutorRepository.GetByIdAsync(id);
                var autorMapped = _mapper.Map<LivroAutorViewModel>(autor);
            
                return autorMapped;    
            }
            catch { throw; }
        }
        public async Task<LivroAutorViewModel> GetByIdAsyncIncludes(int id)
        {
            try
            {
                var autor = await _livroAutorRepository.GetByIdAsync(id);
                var autorMapped = _mapper.Map<LivroAutorViewModel>(autor);
            
                return autorMapped;    
            }
            catch { throw; }
        }
        public LivroAutorViewModel GetByIdIncludes(string id)
        {
            try
            {
                var autor = _livroAutorRepository.GetByIdIncludes(Guid.Parse(id));
                var autorMapped = _mapper.Map<LivroAutorViewModel>(autor);
            
                return autorMapped;    
            }
            catch { throw; }
        }
        public async Task<IEnumerable<LivroAutorViewModel>> GetAllAsync()
        {
            try
            {
                var autores = await _livroAutorRepository.GetAllAsync();
                var autoresMapped = _mapper.Map<IEnumerable<LivroAutorViewModel>>(autores);
            
                return autoresMapped;    
            }
            catch { throw; }
        }
        public async Task<IEnumerable<LivroAutorViewModel>> GetAllAsyncIncludes()
        {
            try
            {
                var autores  = await _livroAutorRepository.GetAllAsync();
                var autoresMapped = _mapper.Map<IEnumerable<LivroAutorViewModel>>(autores);

                return autoresMapped;    
            }
            catch { throw; }
        }
        public IEnumerable<LivroAutorViewModel> GetAll()
        {
            try
            {
                var autores = _livroAutorRepository.GetAll();
                var autoresMapped = _mapper.Map<IEnumerable<LivroAutorViewModel>>(autores);
                return autoresMapped;    
            }
            catch { throw; }
        }
        public ValidationResult Add(LivroAutorViewModel livroAutorViewModel)
        {
            try
            {
                if (_livroAutorRepository.AlreadyEqualsNome(livroAutorViewModel.Nome))
                {
                    _validationResult.AddErrorMessage("Autor já cadastrado e ativo com nome informado.");
                    return _validationResult;
                };

                var autor = _mapper.Map<LivroAutor>(livroAutorViewModel);

                _livroAutorRepository.Add(autor);
                _unitOfWork.Commit();
        
                return _validationResult;
            }
            catch { throw; }
        }
        public ValidationResult Remove(Guid id)
        {
            try
            {
                _livroAutorRepository.Remove(id);
                _unitOfWork.Commit();

                return _validationResult;
            }
            catch { throw; }
        }
        public ValidationResult Update(LivroAutorViewModel livroAutorViewModel)
        {
            try
            {
                var autor = _livroAutorRepository.GetById((Guid) livroAutorViewModel.Id);
                var autorMapped = _mapper.Map<LivroAutorViewModel, LivroAutor>(livroAutorViewModel, autor);
            
                _livroAutorRepository.Update(autorMapped);
                
                _unitOfWork.Commit();    

                return _validationResult;
            }
            catch { throw; }            
        }

        public Int64 GetTotalAtivos()
        {
            var ativos = _livroAutorRepository.GetTotalAtivos();
            return ativos;
        }

        public Int64 GetTotalInativos()
        {
            var inativos = _livroAutorRepository.GetTotalInativos();
            return inativos;
        }

        public Int64 GetTotalWithIgnoreQueryFilter()
        {
            var total = _livroAutorRepository.GetTotalWithIgnoreQueryFilter();
            return total;
        }

        public void Dispose()
        {
            _livroAutorRepository.Dispose();
        }
    }
}
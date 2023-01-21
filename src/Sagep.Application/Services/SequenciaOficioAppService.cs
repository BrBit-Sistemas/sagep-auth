using System.Linq;
using System;
using System.Collections.Generic;
using AutoMapper;
using Sagep.Domain.Interfaces;
using Sagep.Domain.Models;
using Sagep.Application.Interfaces;
using Sagep.Application.ViewModels;
using Sagep.Infra.CrossCutting.Identity.Services;
using Sagep.Infra.Data.Extensions;

namespace Sagep.Application.Services
{
    public class SequenciaOficioAppService : ISequenciaOficioAppService
    {
        private readonly ValidationResult _validationResult;
        private readonly ISequenciaOficioRepository _soRepository;
        private readonly UserResolverService _userResolverService;
        private readonly IContaUsuarioRepository _contaUsuarioRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ITenantRepository _tenantRepository;

        public SequenciaOficioAppService(ValidationResult validationResult,
                                         ISequenciaOficioRepository soRepository,
                                         UserResolverService userResolverService,
                                         IContaUsuarioRepository contaUsuarioRepository,
                                         IUnitOfWork unitOfWork, IMapper mapper,
                                         ITenantRepository tenantRepository)
        {
            _validationResult = validationResult;
            _soRepository = soRepository;
            _userResolverService = userResolverService;
            _contaUsuarioRepository = contaUsuarioRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _tenantRepository = tenantRepository;
        }

        public SequenciaOficioViewModel CriarNova()
        {
            #region Tenancy resolve
            Guid tenantId;
            try
            {
                tenantId = (Guid) StringHelpers.ExtractTenantId(_tenantRepository.GetTenantId());
            }
            catch (Exception ex) { throw ex; }
            #endregion
            
            #region Get current user id
            Guid currenteUserId;
            try
            {
                currenteUserId = _userResolverService.GetUserId();
            }
            catch (Exception ex) { throw ex; }
            #endregion

            #region Get account user and user data
            var accountUser = new ContaUsuario();
            try
            {
                accountUser = _contaUsuarioRepository.GetByUserId(currenteUserId.ToString());
            }
            catch (Exception ex) { throw ex; }
            #endregion

            #region Get all sequencies to tenancy and user sector
            IEnumerable<int> sequencias = new List<int>();
            try
            {
                sequencias = _soRepository.GetSequencias(tenantId, accountUser.Setor);
                if (sequencias == null)
                    throw new Exception("Problemas ao obter as sequências. Tente novamente mais tarde.");
            }
            catch (Exception ex) { throw ex; }
            #endregion

            #region Generate new sequence
            var novaSequencia = new SequenciaOficio();
            try
            {
                novaSequencia.Setor = accountUser.Setor;
                novaSequencia.TenantId = tenantId;
                novaSequencia.Sequencia = sequencias.Count() <= 0 ? 1 : sequencias.Max() + 1;
                novaSequencia.UsuarioNomeUltimaSequencia = accountUser.Nome;
            }
            catch (Exception ex) { throw ex; }
            #endregion

            #region Persistance and commit
            _soRepository.Add(novaSequencia);
            _unitOfWork.Commit();
            #endregion

            #region Mapper
            var soMapped = new SequenciaOficioViewModel();
            try
            {
                soMapped = _mapper.Map<SequenciaOficioViewModel>(novaSequencia);    
            }
            catch (Exception ex) { throw ex; }
            #endregion
            
            return soMapped;
        }

        public void Dispose()
        {
            _soRepository.Dispose();
        }
    }
}
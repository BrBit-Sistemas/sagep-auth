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
using Sagep.Application.ViewModels.Reports;
using Sagep.Infra.Data.Context;

namespace Sagep.Application.Services
{
    public class DetentoSaidaTemporariaAppService : IDetentoSaidaTemporariaAppService
    {
        private readonly ValidationResult _validationResult;
        private readonly IDetentoSaidaTemporariaRepository _detentoSTRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DetentoSaidaTemporariaAppService(ValidationResult validationResult,
                                                IDetentoSaidaTemporariaRepository detentoSTRepository,
                                                IListaAmarelaRepository listaAmarelaRepository,
                                                IUnitOfWork unitOfWork, IMapper mapper)
        {
            _validationResult = validationResult;
            _detentoSTRepository = detentoSTRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IEnumerable<DetentoSaidaTemporariaViewModel> GetAllByFilterReportSaidasPrevistas(ListaAmarelaFilterReportSaidasPrevistasViewModel listaAmarelaFilterReportSaidasPrevistasViewModel)
        {
            var detentos = new List<Detento>();

            if (listaAmarelaFilterReportSaidasPrevistasViewModel.DataSaidaPrevistaSTInicio == null)
                listaAmarelaFilterReportSaidasPrevistasViewModel.DataSaidaPrevistaSTInicio = "0001-01-01 00:00:00";

            if (listaAmarelaFilterReportSaidasPrevistasViewModel.DataSaidaPrevistaSTFim == null)
                listaAmarelaFilterReportSaidasPrevistasViewModel.DataSaidaPrevistaSTFim = "0001-01-01 00:00:00";

            var detentosST = _detentoSTRepository
                                .GetAllByFilterReportSaidasPrevistas(Convert.ToDateTime(listaAmarelaFilterReportSaidasPrevistasViewModel.DataSaidaPrevistaSTInicio),
                                                                     Convert.ToDateTime(listaAmarelaFilterReportSaidasPrevistasViewModel.DataSaidaPrevistaSTFim),
                                                                     listaAmarelaFilterReportSaidasPrevistasViewModel.OpcaoOrdenacaoSelect2).ToList();

            return _mapper.Map<IEnumerable<DetentoSaidaTemporariaViewModel>>(detentosST);
        }

        
        public void Dispose()
        {
            _detentoSTRepository.Dispose();
        }
    }
}
using System.Threading;
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
using Sagep.Domain.Models.DataTable;
using Sagep.Domain.Enums;
using Sagep.Application.ViewModels.Reports;

namespace Sagep.Application.Services
{
    public class AlunoEnccejaAppService : IAlunoEnccejaAppService
    {
        private readonly ValidationResult _validationResult;
        private readonly IAlunoEnccejaRepository _alunoEnccejaRepository;
        private readonly IAlunoRepository _alunoRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AlunoEnccejaAppService(ValidationResult validationResult,
                                    IAlunoEnccejaRepository alunoEnccejaRepository,
                                    IAlunoRepository alunoRepository,
                                    IUnitOfWork unitOfWork, 
                                    IMapper mapper)
        {
            _validationResult = validationResult;
            _alunoEnccejaRepository = alunoEnccejaRepository;
            _alunoRepository = alunoRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Dispose()
        {
            _alunoEnccejaRepository.Dispose();
        }
    }
}
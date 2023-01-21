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
    public class AlunoRedacaoDPUAppService : IAlunoRedacaoDPUAppService
    {
        private readonly ValidationResult _validationResult;
        private readonly IAlunoRedacaoDPUAppService _alunoRedacaoDPURepository;
        private readonly IAlunoRepository _alunoRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AlunoRedacaoDPUAppService(ValidationResult validationResult,
                                            IAlunoRedacaoDPUAppService alunoRedacaoDPURepository,
                                            IAlunoRepository alunoRepository,
                                            IUnitOfWork unitOfWork, 
                                            IMapper mapper)
        {
            _validationResult = validationResult;
            _alunoRedacaoDPURepository = alunoRedacaoDPURepository;
            _alunoRepository = alunoRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Dispose()
        {
            _alunoRedacaoDPURepository.Dispose();
        }
    }
}
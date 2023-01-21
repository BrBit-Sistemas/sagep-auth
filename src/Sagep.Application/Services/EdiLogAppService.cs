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

namespace Sagep.Application.Services
{
    public class EdiLogAppService : IEdiLogAppService
    {
        public EdiLogAppService()
        {
        }

        public void Dispose() => throw new NotImplementedException();
    }
}
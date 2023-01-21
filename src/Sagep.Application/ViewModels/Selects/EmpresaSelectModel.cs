using System.Dynamic;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Sagep.Domain.Enums;
using Sagep.Domain.Models;
using Sagep.Application.ViewModels;

namespace Sagep.Application.ViewModels.Selects
{
    public class EmpresaSelectModel
    {
        public Guid? EmpresaId { get; set; }

        public string RazaoSocial { get; set; }
    }
}
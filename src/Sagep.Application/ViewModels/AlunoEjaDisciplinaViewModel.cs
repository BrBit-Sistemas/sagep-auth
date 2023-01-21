using System.Dynamic;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Sagep.Domain.Enums;
using Sagep.Domain.Models;
using Sagep.Application.ViewModels;
using System.Collections.Generic;

namespace Sagep.Application.ViewModels
{
    public class AlunoEjaDisciplinaViewModel
    {
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [DisplayName("Conceito")]
        public string Conceito { get; set; }
    }
}
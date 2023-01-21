using System.Dynamic;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Sagep.Domain.Enums;
using Sagep.Domain.Models;
using Sagep.Application.ViewModels;
using System.Collections.Generic;

namespace Sagep.Application.ViewModels.Selects
{
    public class AlunoEjaDisciplinaAndConceitoSelect2ViewModel
    {
        public List<string> Disciplinas { get; set;}
        public List<string> Conceitos { get; set;}
    }
}
using System.Dynamic;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Sagep.Domain.Enums;
using Sagep.Domain.Models;
using Sagep.Application.ViewModels;
using System.Collections.Generic;
using Sagep.Application.ViewModels.Selects;

namespace Sagep.Application.ViewModels.Cards
{
    public class EmpresaConvenioCardViewModel
    {
        public int Ativos { get; set; }
        
        public int EmAnalise { get; set; }

        public int RenovacaoAutomatica { get; set; }

        public int Encerrados { get; set; }

        public List<string> Empresas { get; set; }
        public List<string> Situacoes { get; set; }
    }
}
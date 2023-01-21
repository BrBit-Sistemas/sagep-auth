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
    public class AndamentoPenalCardViewModel
    {
        public Int64 Total { get; set; }
        public Int64 Normal { get; set; }
        public Int64 Provisorios { get; set; }
        
        public Int64 CTCs { get; set; }

        public Int64 PADs { get; set; }       

        public Int64 SaidasTemporarias { get; set; }

        public Int64 EvasoesFugas { get; set; }

        public Int64 PrisaoDomiciliar { get; set; }

        public List<string> Detentos { get; set; }
        public List<string> Regimes { get; set; }
        public List<string> InstrumentosPrisao { get; set; }
        public List<string> CondenacaoTipos { get; set; }
    }
}
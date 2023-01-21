using System.Collections;
using System;
using System.Collections.Generic;
using Sagep.Domain.Models;
using Sagep.Domain.Enums;

namespace Sagep.Application.ViewModels.Cards
{
    public class AlunoLeituraCronogramaCardViewModel
    {
        public Int64 Total { get; set; }
        public Int64 Ativos { get; set; }
        public Int64 Inativos { get; set; }
    }
}
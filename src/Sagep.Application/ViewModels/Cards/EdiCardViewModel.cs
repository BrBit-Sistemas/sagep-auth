using System.Collections;
using System;
using System.Collections.Generic;
using Sagep.Domain.Models;
using Sagep.Domain.Enums;
using Sagep.Application.ViewModels.Selects;

namespace Sagep.Application.ViewModels.Cards
{
    public class EdiCardViewModel
    {
        public int TotalImportacoes { get; set; }
        public int EmProcessamento { get; set; }
        public int Processados { get; set; }
    }
}

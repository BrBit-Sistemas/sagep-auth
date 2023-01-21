using System.Collections;
using System;
using System.Collections.Generic;
using Sagep.Domain.Models;
using Sagep.Domain.Enums;
using Sagep.Application.ViewModels.Selects;

namespace Sagep.Application.ViewModels.Cards
{
    public class EdiLogCardViewModel
    {
        public int Intervencoes { get; set; }
        public int Mudancas { get; set; }
        public int Ativacoes { get; set; }
        public int Desativacoes { get; set; }
        public int Exclusoes { get; set; }
        public int Inclusoes { get; set; }
    }
}

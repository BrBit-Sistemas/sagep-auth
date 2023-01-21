using System.Collections;
using System;
using System.Collections.Generic;
using Sagep.Domain.Models;
using Sagep.Domain.Enums;
using Sagep.Application.ViewModels.Selects;

namespace Sagep.Application.ViewModels.Cards
{
    public class LivroCardViewModel
    {
        public Int64 Ativos { get; set; }
        public Int64 Inativos { get; set; }
        public Int64 Disponiveis { get; set; }
        public Int64 Indisponiveis { get; set; }

        public List<string> Autores { get; set; }
        public List<string> Generos { get; set; }
    }
}
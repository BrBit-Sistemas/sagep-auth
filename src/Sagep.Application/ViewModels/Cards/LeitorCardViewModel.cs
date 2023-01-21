using System.Collections;
using System;
using System.Collections.Generic;
using Sagep.Domain.Models;
using Sagep.Domain.Enums;
using Sagep.Application.ViewModels.Selects;

namespace Sagep.Application.ViewModels.Cards
{
    public class LeitorCardViewModel
    {
        public Int64 Ativos { get; set; }
        public Int64 Inativos { get; set; }
        public Int64 Total { get; set; }

        public List<string> Professores { get; set; }
        public List<string> Generos { get; set; }
        public List<string> Detentos { get; set; }
        public List<string> Escolaridades { get; set; }
        public List<string> OcorrenciasDesistencia { get; set; }
    }
}
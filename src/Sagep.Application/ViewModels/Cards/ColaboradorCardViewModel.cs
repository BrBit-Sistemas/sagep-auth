using System.Collections;
using System;
using System.Collections.Generic;
using Sagep.Domain.Models;
using Sagep.Domain.Enums;
using Sagep.Application.ViewModels.Selects;

namespace Sagep.Application.ViewModels.Cards
{
    public class ColaboradorCardViewModel
    {
        public int Ativos { get; set; }
        public int Admitidos { get; set; }
        public int Demitidos { get; set; }
        public int EmProcessoAdmissao { get; set; }

        public List<string> EmpresasConvenios { get; set; }
        public List<string> Detentos { get; set; }
        public List<string> Situacoes { get; set; }
        public List<string> TiposPagamento { get; set; }
        public List<string> TiposConta { get; set; }
        public List<string> DemissaoOcorrencias { get; set; }
        public List<string> Funcoes { get; set; }
    }
}

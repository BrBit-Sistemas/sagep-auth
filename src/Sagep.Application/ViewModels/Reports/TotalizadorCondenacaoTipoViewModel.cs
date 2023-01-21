using System.Collections;
using System;
using System.Collections.Generic;
using Sagep.Domain.Models;
using Sagep.Domain.Enums;
using Sagep.Application.ViewModels.Selects;

namespace Sagep.Application.ViewModels.Reports
{
    public class TotalizadorCondenacaoTipoViewModel
    {
        public List<Condenacao> CondenacoesTipo {get; set; }
        public int TotalRegistros { get; set; }
    }

    public class Condenacao
    {
        public string Tipo { get; set; }
        public int Total { get; set; }
    }
}
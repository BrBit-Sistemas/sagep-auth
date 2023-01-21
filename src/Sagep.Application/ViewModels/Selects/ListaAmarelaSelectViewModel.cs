using System.Collections;
using System;
using System.Collections.Generic;
using Sagep.Domain.Models;
using Sagep.Domain.Enums;
using Sagep.Application.ViewModels.Selects;

namespace Sagep.Application.ViewModels.Selects
{
    public class ListaAmarelaSelectViewModel
    {
        public List<string> TransferenciaTipos { get; set; }
        public List<string> Regimes { get; set; }
        public List<string> SaidaTemporariaOpcoesOrdenacaoRelatorio { get; set; }
    }
}

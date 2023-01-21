using System.Collections;
using System;
using System.Collections.Generic;
using Sagep.Domain.Models;
using Sagep.Domain.Enums;
using Sagep.Application.ViewModels.Selects;

namespace Sagep.Application.ViewModels.Selects
{
    public class AndamentoPenalNovoSelect2ViewModel
    {
        public List<Generic2Select2ViewModel> Detentos { get; set; }
        public List<string> Statuses { get; set; }
    }
}
using System.Collections;
using System;
using System.Collections.Generic;
using Sagep.Domain.Models;
using Sagep.Domain.Enums;
using Sagep.Application.ViewModels;

namespace Sagep.Application.ViewModels.AndamentoPenal
{
    public class AndamentoPenalEdicaoViewModel
    {
        public AndamentoPenalViewModel AndamentoPenalViewModel { get; set; }
        public List<string> Statuses { get; set; }
    }
}
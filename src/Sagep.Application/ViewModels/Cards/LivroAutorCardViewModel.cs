using System.Collections;
using System;
using System.Collections.Generic;
using Sagep.Domain.Models;
using Sagep.Domain.Enums;
using Sagep.Application.ViewModels.Selects;

namespace Sagep.Application.ViewModels.Cards
{
    public class LivroAutorCardViewModel
    {
        public Int64 Ativos { get; set; }
        public Int64 Inativos { get; set; }
        public Int64 Total { get; set; }
    }
}
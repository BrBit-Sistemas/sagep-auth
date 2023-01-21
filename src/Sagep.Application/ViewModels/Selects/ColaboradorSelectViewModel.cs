using System.Collections;
using System;
using System.Collections.Generic;
using Sagep.Domain.Models;
using Sagep.Domain.Enums;
using Sagep.Application.ViewModels.Selects;

namespace Sagep.Application.ViewModels.Selects
{
    public class ColaboradorSelectViewModel
    {
        public List<string> Galerias { get; set; }
        public List<string> Situacoes { get; set; }
        public List<string> EmpresasConvenios { get; set; }
    }
}

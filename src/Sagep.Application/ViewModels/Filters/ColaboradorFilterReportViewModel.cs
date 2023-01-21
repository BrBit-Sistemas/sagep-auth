using System.Collections;
using System;
using System.Collections.Generic;
using Sagep.Domain.Models;
using Sagep.Domain.Enums;
using Sagep.Application.ViewModels.Selects;
using System.ComponentModel.DataAnnotations;

namespace Sagep.Application.ViewModels.Reports
{
    public class ColaboradorFilterReportViewModel
    {
        public string Galeria { get;set; }
        public List<string> Situacoes { get;set; }
        public string EmpresaConvenio { get;set; }
    }
}
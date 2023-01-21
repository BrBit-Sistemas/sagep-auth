using System.Dynamic;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Sagep.Domain.Enums;
using Sagep.Domain.Models;
using Sagep.Application.ViewModels;
using System.Collections.Generic;

namespace Sagep.Application.ViewModels.Detentos
{
    public class DetentoViewModelGetForModalTransferencia
    {
        public string Ipen { get; set; }
        public string Nome { get; set; }
        public string Regime { get; set; }
    }
}
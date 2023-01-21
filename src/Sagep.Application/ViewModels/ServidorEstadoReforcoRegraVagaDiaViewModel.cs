using System.Dynamic;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Sagep.Domain.Enums;
using Sagep.Domain.Models;
using Sagep.Application.ViewModels;
using System.Collections.Generic;

namespace Sagep.Application.ViewModels
{
    public class ServidorEstadoReforcoRegraVagaDiaViewModel
    {
        [DisplayName("Dia")]
        public string Dia { get; set; }

        [DisplayName("TotalVagas")]
        public int TotalVagas { get; set; }

        [DisplayName("Turno")]
        public string Turno { get; set; }
    }
}
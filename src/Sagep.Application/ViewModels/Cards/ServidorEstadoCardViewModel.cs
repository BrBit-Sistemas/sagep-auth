using System.Collections;
using System;
using System.Collections.Generic;
using Sagep.Domain.Models;
using Sagep.Domain.Enums;

namespace Sagep.Application.ViewModels.Cards
{
    public class ServidorEstadoCardViewModel
    {
        public int Total { get; set; }
        public int Expedientes { get; set; }
        public int NaoExpedientes { get; set; }
        public int FeriasAgendadasToCurrentYear { get; set; }
        public int LicencaPremioToCurrentYear { get; set; }
        public List<string> Plantoes { get; set; }
        public List<string> Galerias { get; set; }
    }
}
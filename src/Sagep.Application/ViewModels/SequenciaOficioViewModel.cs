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
    public class SequenciaOficioViewModel
    {
        public int? Sequencia { get; set; }
        public string UsuarioNomeUltimaSequencia   { get; set; }
        public string UltimaSequencia { get; set; }
        public string SequenciaGerada { get; set; }
        public string CreatedAt { get; set; }
        public string UserSetor { get; set; }
        public string TenantNomeExibicao { get; set; }
        public List<SequenciaOficioViewModel> MinhasSequencias { get; set;}
    }
}
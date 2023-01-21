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
    public class EdiViewModel
    {
        public Guid? Id { get; set; }

        [DisplayName("Arquivo nome")]
        public string ArquivoNome { get; set; }

        [DisplayName("Arquivo extensão")]
        public string ArquivoExtensao { get; set; }

        [DisplayName("Status")]
        public string Status { get; set; }

        [DisplayName("Data importação")]
        public string CreatedAt { get; set; }

        [DisplayName("Ações")]
        public string Acoes { get; set; }

        [DisplayName("Logs")]
        public string Logs { get; set; }
    }
}
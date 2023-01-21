using System.Dynamic;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Sagep.Domain.Enums;
using Sagep.Domain.Models;
using Sagep.Application.ViewModels;
using System.Collections.Generic;

namespace Sagep.Application.ViewModels.Requests
{
    public class OficioEducacaoLeituraRequestModel
    {
        [Required, MinLength(1, ErrorMessage = "Ao menos uma leitura é requerida.")]
        [DisplayName("Leituras Ids")]
        public List<string> LeiturasIds { get; set; }
    }
}
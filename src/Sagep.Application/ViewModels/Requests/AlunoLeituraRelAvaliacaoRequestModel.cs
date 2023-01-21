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
    public class AlunoLeituraRelAvaliacaoRequestModel
    {
        [DisplayName("Cronograma Id")]
        public string CronogramaId { get; set; }

        [DisplayName("Galeria")]
        public string Galeria { get; set; }

        [DisplayName("Período avaliações")]
        public string PeriodoAvaliacao { get; set; }

        [DisplayName("Leituras Ids")]
        public List<string> LeiturasIds { get; set; }
    }
}
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
    public class AlunoLeituraNovosRequestViewModel
    {
        public string LeituraTipo { get; set; }
        public string Galeria { get; set; }
        public List<string> Celas { get; set; }
        public string Cronograma { get; set;}
    }
}
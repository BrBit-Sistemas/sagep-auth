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
    public class ColocarEstanteRequestViewModel
    {
        public string Localizacao { get; set; }
        public bool Todos { get; set; }
    }
}
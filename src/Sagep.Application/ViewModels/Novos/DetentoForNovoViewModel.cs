using System.Dynamic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Sagep.Domain.Enums;
using Sagep.Domain.Models;
using Sagep.Application.ViewModels;

namespace Sagep.Application.ViewModels
{
    public class DetentoForNovoViewModel
    {
        public string Nome { get;set; }
        public string Ipen { get;set; } 
        public string Pec { get; set; }
        public string Galeria { get; set; }
        public string Cela { get; set; }
        public string Detento { get; set; }
        public string Regime { get; set; }
    }
}
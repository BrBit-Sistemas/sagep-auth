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
    public class DetentoImp
    {
        public string Ipen { get;set; } = "";
        public string Nome { get; set; } = "";
        public string Galeria { get; set; } = "";
        public string Cela { get; set; } = "";
    }
}
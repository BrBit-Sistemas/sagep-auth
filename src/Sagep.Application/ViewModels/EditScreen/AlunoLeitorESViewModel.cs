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
    public class AlunoLeitorESViewModel
    {
        public Guid? Id { get; set; }
        public string DetentoIpen { get; set; }
        public string DetentoNome { get; set; }
        public string DetentoGaleria { get; set; }
        public string DetentoCela { get; set; }
        public string DetentoRegime { get; set; }
    }
}
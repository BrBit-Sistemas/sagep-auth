using System.Dynamic;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Sagep.Domain.Enums;
using Sagep.Domain.Models;
using Sagep.Application.ViewModels;
using System.Collections.Generic;
using Sagep.Application.ViewModels.Selects;

namespace Sagep.Application.ViewModels.Charts.Info
{
    public class ColaboradorPorConvenioViewModel
    {
        public List<string> Label { get; set; }
        public List<int> Data {get; set; }
        public List<string> BackgroundsColor { get; set; }
    }
}
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
    public class DetentoSaidaTemporariaViewModel
    {
        public Guid? Id { get; set; }

        public string SaidaPrevista { get; set; }
        public string RetornoPrevisto { get; set; }

        public Detento Detento { get; set; }
    }
}
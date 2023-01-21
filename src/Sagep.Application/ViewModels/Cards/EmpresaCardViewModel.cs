using System.Dynamic;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Sagep.Domain.Enums;
using Sagep.Domain.Models;
using Sagep.Application.ViewModels;
using System.Collections.Generic;

namespace Sagep.Application.ViewModels.Cards
{
    public class EmpresaCardViewModel
    {
        public int Ativas { get; set; }
        
        public int Email { get; set; }

        public int WhatsApp { get; set; }

        public int Inativas { get; set; }

        public List<string> Empresas { get; set;}
        public List<string> Estados { get; set; }
    }
}
using System.Collections;
using System;
using System.Collections.Generic;
using Sagep.Domain.Models;
using Sagep.Domain.Enums;
using Sagep.Application.ViewModels.Selects;

namespace Sagep.Application.ViewModels.Cards
{
    public class ContaCorrenteCardViewModel
    {
        public int Ativas { get; set; }
        public int Encerradas { get; set; }
        public int Bloqueadas { get; set; }
        public decimal Saldos { get; set; }

        public List<string> Colaboradores { get; set; }
        public List<string> Empresas { get; set; }
        public List<string> Status { get; set; }
        public List<string> Tipos { get; set; }
    }
}
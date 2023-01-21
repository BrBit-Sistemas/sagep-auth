using System.Collections;
using System;
using System.Collections.Generic;
using Sagep.Domain.Models;

namespace Sagep.Application.ViewModels.Cards
{
    public class UsuarioCardViewModel
    {
        public int Ativos { get; set; }
        
        public int FalhasAcesso { get; set; }

        public int TwoFactors { get; set; }

        public int ConfirmacoesPendentes { get; set; }

        public List<string> ApplicationRoles { get; set; }
    }
}
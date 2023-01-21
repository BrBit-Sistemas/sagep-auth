using System.Collections.Generic;
using Sagep.Domain.Models;

namespace Sagep.Application.ViewModels
{
    public class ApplicationUserViewModel
    {
        public string UserId { get;set; } 
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public string Funcao { get; set; }
        public string Setor { get; set; }
        public string PerfilFoto { get; set; }
        public string Nome { get; set; }

        public List<string> Setores { get; set; }
        public List<string> Funcoes { get; set; }

        public List<string> ApplicationUserRoles { get; set; }
        
        public Tenant Tenant { get; set; }
    }
}
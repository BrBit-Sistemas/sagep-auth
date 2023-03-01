using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Sagep.Domain.Enums;

namespace Sagep.Domain.Models
{
    public class Detento : EntityAudit
    {
        public Detento(string ipen, string nome)
        {
            Ipen = ipen;
            Nome = nome;
        }

        // Constructor empty to EFCore
        public Detento() {}

        public string Ipen { get;  set; }
        public string Nome { get;  set; }
    }
}
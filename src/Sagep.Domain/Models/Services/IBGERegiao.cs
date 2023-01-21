using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Sagep.Domain.Models
{
    public class IBGERegiao
    {        
        public string Id { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }
    }
}
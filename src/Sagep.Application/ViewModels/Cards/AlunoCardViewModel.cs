using System.Collections;
using System;
using System.Collections.Generic;
using Sagep.Domain.Models;
using Sagep.Domain.Enums;

namespace Sagep.Application.ViewModels.Cards
{
    public class AlunoCardViewModel
    {
        public int Ativos { get; set; }
        public int Inativos { get; set; }
        public int Leitores { get; set; }
        public int Ejas { get; set; }
        public int Enems { get; set; }
        public int Enccejas { get; set; }
        public int Dpus { get; set; }
        public int ProjetosEspeciais { get; set; }
        public List<string> Escolaridades { get; set; }
        public List<string> AtividadesEducacionais { get; set; }
        public List<string> Detentos { get; set; }
    }
}
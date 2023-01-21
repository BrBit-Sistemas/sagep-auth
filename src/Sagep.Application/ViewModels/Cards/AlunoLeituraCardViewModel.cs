using System.Collections;
using System;
using System.Collections.Generic;
using Sagep.Domain.Models;
using Sagep.Domain.Enums;

namespace Sagep.Application.ViewModels.Cards
{
    public class AlunoLeituraCardViewModel
    {
        public Int64 Total { get; set; }
        public Int64 Ativas { get; set; }
        public Int64 Inativas { get; set; }
        public Int64 LeituraLivroTipoSocial { get; set; }
        public Int64 LeituraLivroTipoRemissao { get; set; }
        
        public List<string> AlunoLeituraTipos { get; set; }
        public List<string> Livros { get; set; }
        public List<string> AvaliacaoCriterios { get; set; }
        public List<string> AvaliacaoConceitos { get; set; }
    }
}
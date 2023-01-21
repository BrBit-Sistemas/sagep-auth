using System.Collections.Generic;

namespace Sagep.Application.ViewModels.Cards
{
    public class InfracaoAdministrativaDisciplinarCardViewModel
    {
        public int TotalInfracoesAtivas { get; set; }
        public int TotalInfracoesInativas { get; set; }
        public int TotalFaltasNaoInformadas { get; set; }
        public int TotalFaltasLeve { get; set; }
        public int TotalFaltasMedia { get; set; }
        public int TotalFaltasGrave { get; set; }
        public List<string> Faltas { get; set; }
    }
}
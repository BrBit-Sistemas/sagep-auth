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
    public class DisciplinaViewModel
    {
        public Guid? Id { get; set; }

        // [Range(minimum: 4, maximum: 4, ErrorMessage = "Permitido máximo de 4 números para o ano referência.")]
        [Required(ErrorMessage = "Nome disciplina requerido.")]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Fase requerida.")]
        [DisplayName("Fase")]
        public string Fase { get; set; }

        [Required(ErrorMessage = "Hora aula requerida.")]
        [DisplayName("Hora aula")]
        public string HoraAula { get; set; }

        [Required(ErrorMessage = "Carga horária requerida.")]
        [DisplayName("Carga horária")]
        public string CargaHoraria { get; set; }

        [Required(ErrorMessage = "Curso requerido.")]
        [DisplayName("Curso")]
        public string Curso { get; set; }

        [Required(ErrorMessage = "Nome do professor requerido.")]
        [DisplayName("Professor nome")]
        public string ProfessorNome { get; set; }

        public Professor Professor { get; set; }
    }
}
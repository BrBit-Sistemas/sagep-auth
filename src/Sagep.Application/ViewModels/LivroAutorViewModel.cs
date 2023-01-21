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
    public class LivroAutorViewModel
    {
        public Guid? Id { get; set; }

        [Required(ErrorMessage = "Nome requerido.")]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        public ICollection<LivroViewModel> Livros { get; set; }
    }
}
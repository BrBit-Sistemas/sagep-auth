using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Sagep.Domain.Enums;

namespace Sagep.Domain.Models
{
    public class LivroGenero : EntityAudit
    {
        public LivroGenero (string nome)
        {
            Nome = nome;
        }

        //Construtor vazio para o EF
        public LivroGenero() {}

        public string Nome { get; set; }


        //Relacionamentos
        public ICollection<Livro> Livros { get; set; }
    }
}
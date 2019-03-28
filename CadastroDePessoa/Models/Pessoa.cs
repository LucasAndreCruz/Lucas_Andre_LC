using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroDePessoa.Models
{
    public class Pessoa
    {

        public int PessoaId { get; set; }

        public string Nome { get; set; }

        public string DataDeNascimento { get; set; }

        public string RG { get; set; }

        public string CPF { get; set; }

    }
}
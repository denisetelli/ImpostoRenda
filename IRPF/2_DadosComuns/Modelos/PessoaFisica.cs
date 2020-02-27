using System;
using System.ComponentModel.DataAnnotations;

namespace DadosComuns
{
    public class PessoaFisica
    {
        [Required]
        public String Nome { get; set; }

        [Required]
        public String Cpf { get; set; }

        public int Idade { get; set; }

        public int NumeroDependentes { get; set; }
    }
}

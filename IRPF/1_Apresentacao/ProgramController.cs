using System;
using DadosComuns;
using Negocios;

namespace IRPF
{
    public class ProgramController
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Olá, digite seus dados para cadastro.");
            CriaPessoaFisica();
            SelecionaTipoCalculo();
        }

        public static void CriaPessoaFisica()
        {
            PessoaFisica pf = new PessoaFisica();

            Console.Write("Insira seu nome:");
            pf.Nome = Console.ReadLine();
            Console.Write("Insira seu CPF somente com numeros:");
            pf.Cpf = Console.ReadLine();
            AdicionaPessoaFisica(pf);
        }

        public static void AdicionaPessoaFisica(PessoaFisica pessoa)
        {
            CadastroPessoaFisica cadastro = new CadastroPessoaFisica();
            cadastro.PessoasFisicasCadastradas.Add(pessoa);
        }

        public static void SelecionaTipoCalculo()
        {
            CriaDeclaracao novaDeclaracao = new CriaDeclaracao();

            Console.WriteLine("Qual maneira voce quer calcular sua declaracao de imposto?\nDigite 1 para SIMPLES ou 2 para COMPLETA");
            int tipo = Convert.ToInt32(Console.ReadLine());
           
            switch (tipo)
            {
                case 1:
                    novaDeclaracao.DeclaracaoSimples();
                    break;
                case 2:
                    novaDeclaracao.DeclaracaoCompleta();
                    break;
            }
        }
    }
}

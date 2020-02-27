using System;
using System.Reflection;
using DadosComuns;
using Negocios;

namespace IRPF {
    public class CriaDeclaracao {

        CalculaDescontosServico calculaDesconto = new CalculaDescontosServico ();
        DeclaracaoServico declaracao = new DeclaracaoServico (12000,24000);

        public void DeclaracaoSimples () {

            double contribuicaoPrevidenciariaOficial;
            double totalRendimentos;

            Console.WriteLine ("Insira abaixo sua Contribuicao previdenciaria oficial:");
            contribuicaoPrevidenciariaOficial = Convert.ToDouble (Console.ReadLine ());

            Console.WriteLine ("Insira abaixo seu Total de Rendimentos no periodo:");
            totalRendimentos = Convert.ToDouble (Console.ReadLine ());

            double baseDeCalculo = declaracao.CalculaBaseDeCalculo (contribuicaoPrevidenciariaOficial, totalRendimentos);
            double baseComDesconto = calculaDesconto.CalculaDescontoDeclaracaoSimplificada (baseDeCalculo);
            declaracao.CalculaValorDevido (baseComDesconto);
        }

        public void DeclaracaoCompleta () {
            int idade;
            int nroDependentes;
            double contribuicaoPrevidenciariaOficial;
            double totalRendimentos;

            Console.WriteLine ("Insira abaixo sua idade:");
            idade = Convert.ToInt32 (Console.ReadLine ());

            Console.WriteLine ("Insira abaixo o numero de Dependentes:");
            nroDependentes = Convert.ToInt32 (Console.ReadLine ());

            Console.WriteLine ("Insira abaixo sua Contribuicao previdenciaria oficial:");
            contribuicaoPrevidenciariaOficial = Convert.ToDouble (Console.ReadLine ());

            Console.WriteLine ("Insira abaixo seu Total de Rendimentos no periodo:");
            totalRendimentos = Convert.ToDouble (Console.ReadLine ());

            double baseDeCalculo = declaracao.CalculaBaseDeCalculo (contribuicaoPrevidenciariaOficial, totalRendimentos);
            double baseComDesconto = calculaDesconto.CalculaDescontoDeclaracaoCompleta (baseDeCalculo, idade, nroDependentes);
            declaracao.CalculaValorDevido (baseComDesconto);
        }
    }
}
using System;
namespace Negocios {
    public class DeclaracaoServico : IDeclaracaoServico {

        private double faixaInicial {get;set;} 
        private double faixaIntermediaria {get;set;} 
        
        public DeclaracaoServico (double faixaInicial, double faixaIntermediaria) {
            this.faixaInicial = faixaInicial;
            this.faixaIntermediaria = faixaIntermediaria;
        }

        public double CalculaBaseDeCalculo (double contribuicaoPrevidenciariaOficial, double totalDeRendimentos) {
            return totalDeRendimentos - contribuicaoPrevidenciariaOficial;
        }

        public int DefineTipoDeclaracao (double baseDeCaCalculo) {

            if (baseDeCaCalculo < 12000)
                return 1;
            if (baseDeCaCalculo >= 12000 && baseDeCaCalculo < 24000)
                return 2;
            else
                return 3;
        }

        public void CalculaValorDevido (double baseDeCalculoFinal) {
           
            double diferencaInicial = baseDeCalculoFinal - faixaInicial;
            double diferencaIntermediaria = baseDeCalculoFinal - faixaIntermediaria;
            double percentualFaixaDois = 0.15;
            double percentualFaixaTres = 0.275;

            int tipo = DefineTipoDeclaracao (baseDeCalculoFinal);

            if (tipo == 1)
            {
                Console.WriteLine("Não precisa declarar.");
            }
            if (tipo == 2)
            {
                double valorFinal = diferencaInicial * percentualFaixaDois;
                Console.WriteLine("Declaração Simples \nValor devido: " + valorFinal);
            }
            else if (tipo == 3)
            {
                double valorFaixaAnterior = faixaInicial * percentualFaixaDois;
                double valorFinal = valorFaixaAnterior + (diferencaIntermediaria * percentualFaixaTres);
                Console.WriteLine("Declaração Completa \nValor devido: " + valorFinal);
            }
        }
    }
}

namespace Negocios
{
    public interface IDeclaracaoServico
    {

        double CalculaBaseDeCalculo(double contribuicaoPrevidenciariaOficial, double totalDeRendimentos);
        int DefineTipoDeclaracao(double baseDeCaCalculo);
        void CalculaValorDevido(double baseDeCalculoFinal);
        //void ImprimeTipoDeDeclaracao(int tipo);
    }
}

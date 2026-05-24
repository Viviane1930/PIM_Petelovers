// Arquivo: ServicoComTransporte.cs
namespace PetLovers.Domain
{
    // Aplicação de Herança: Estende a regra de serviço adicionando 
    // a responsabilidade de frete
    public class ServicoComTransporte : Servico
    {
        // Encapsulamento da taxa fixa de transporte estipulada para a 
        // região Swift
        public decimal TaxaDistanciaSwift { get; set; } = 10.00m; 

        // Polimorfismo: Sobrescreve o comportamento base, executando o 
        // cálculo original de porte
        // e incrementando o valor com a taxa logística correspondente
        public override decimal CalcularValorTotal(string porte)
        {
            return base.CalcularValorTotal(porte) + TaxaDistanciaSwift;
        }
    }
}
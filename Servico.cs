// Arquivo: Servico.cs
namespace PetLovers.Domain
{
    // Classe base que dita as regras padrão de tarifação por porte de animal
    public class Servico
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public decimal PrecoBase { get; set; }

        // Método virtual: permite modificação e redefinição de 
        // comportamento em classes filhas
        public virtual decimal CalcularValorTotal(string porte)
        {
            return porte.ToLower() switch
            {
                "médio" => PrecoBase + 15.00m,   // Adicional padrão para porte médio
                "grande" => PrecoBase + 30.00m,  // Adicional padrão para porte grande
                _ => PrecoBase                   // Porte pequeno não sofre acréscimo
            };
        }
    }
}
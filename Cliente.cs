// Arquivo: Cliente.cs
namespace PetLovers.Domain
{
    // Aplicação de Herança: Cliente estende a 
    // classe base Pessoa, herdando Id e Nome
    public class Cliente : Pessoa
    {
        // Propriedades específicas da entidade Cliente 
        // com encapsulamento automático
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}
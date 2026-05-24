// Arquivo: Agendamemento.cs
using System;
using System.Collections.Generic;

namespace PetLovers.Domain
{
    public class Agendamento
    {
        public int Id { get; set; }
        public Cliente Dono { get; set; } = new Cliente();
        public Pet PetAgendado { get; set; } = new Pet();
        
        // Coleção polimórfica que aceita instâncias de 'Servico' 
        // ou 'ServicoComTransporte'
        public List<Servico> ServicosSelecionados { get; set; } = new List<Servico>();
        public bool PrecisaTaxiPet { get; set; }
        public string Observacoes { get; set; } = string.Empty;
        public DateTime DataCriacao { get; set; } = DateTime.Now;

        // Execução do polimorfismo dinâmico na resolução de valores das coleções
        public decimal ProcessarValorTotalDoAgendamento(string portePet)
        {
            decimal total = 0;
            foreach (var servico in ServicosSelecionados)
            {
                // O compilador decide em tempo de execução se invocará a regra contida 
                // em 'Servico' ou em 'ServicoComTransporte' a depender da instância injetada
                total += servico.CalcularValorTotal(portePet);
            }
            return total;
        }
    }
}
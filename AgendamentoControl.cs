// Arquivo: AgendamentoControl.cs
using System;
using PetLovers.Domain;

namespace PetLovers.Controllers
{
    public class AgendamentoController
    {
        // Simulação de entrada e processamento de dados mapeados originários da camada de front-end
        public string ProcessarFormularioAgendamento(string nomeDono, string nomePet, string servicoNome, string opcaoTaxi, string obs)
        {
            // Instanciação e carga das entidades associativas básicas do domínio
            Cliente cliente = new Cliente { Nome = nomeDono };
            Pet pet = new Pet { Nome = nomePet };

            Agendamento novoAgendamento = new Agendamento
            {
                Dono = cliente,
                PetAgendado = pet,
                PrecisaTaxiPet = (opcaoTaxi.ToLower() == "sim"),
                Observacoes = obs
            };

            // Aplicação prática de polimorfismo no instanciamento por interface/tipo base
            Servico servico;
            if (novoAgendamento.PrecisaTaxiPet)
            {
                // Injeção de dependência da classe filha que computa taxa de transporte
                servico = new ServicoComTransporte { Nome = servicoNome, PrecoBase = 50.00m };
            }
            else
            {
                // Injeção da classe padrão sem custos de deslocamento adicionais
                servico = new Servico { Nome = servicoNome, PrecoBase = 50.00m };
            }

            // Alimentação da lista interna tratada polimorficamente pela entidade Agendamento
            novoAgendamento.ServicosSelecionados.Add(servico);

            // Execução do cálculo encapsulado (Simulando o porte médio padrão do fluxo de teste)
            decimal valorFinal = novoAgendamento.ProcessarValorTotalDoAgendamento("médio");

            // Formatação do retorno em formato String para validação e exibição em relatórios de auditoria
            return $"--- NOVO AGENDAMENTO RECEBIDO ---\n" +
                   $"Tutor: {novoAgendamento.Dono.Nome}\n" +
                   $"Pet: {novoAgendamento.PetAgendado.Nome}\n" +
                   $"Serviço: {servico.Nome}\n" +
                   $"Precisa de Táxi Dog: {(novoAgendamento.PrecisaTaxiPet ? "Sim" : "Não")}\n" +
                   $"Valor Total Estimado (Porte Médio): {valorFinal:C}\n" +
                   $"Observações: {novoAgendamento.Observacoes}";
        }
    }
}
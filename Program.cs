using System;
using PetLovers.Controllers;

namespace PetLovers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicializando Sistema de Back-end PetLovers...\n");

            // Instancia o controlador responsável por gerenciar as ações
            AgendamentoController controller = new AgendamentoController();

            // Simulação 1: Cliente  Viviane agendamento banho completo sem uso do Táxi Pet
            string resultado1 = controller.ProcessarFormularioAgendamento(
                "Viviane do Nascimento Drumond", 
                "Lua", 
                "Banho Completo", 
                "nao", 
                "Nenhuma observação."
            );
            Console.WriteLine(resultado1);
            Console.WriteLine();

            // Simulação 2: Cliente Geovani agendamento Combo com Táxi Pet 
            string resultado2 = controller.ProcessarFormularioAgendamento(
                "Geovani Martins Gama", 
                "Staurno", 
                "Combo Completo", 
                "sim", 
                "Cuidado ao transportar, ela é um pouco arisca."
            );
            Console.WriteLine(resultado2);
        }
    }
}
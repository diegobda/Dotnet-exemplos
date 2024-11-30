using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradadeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome = null; // Inicializa a variável para evitar o erro CS0165

            Console.WriteLine("Programa que efetua leitura de dados de usuários");
            Console.Write("Digite seu nome: ");

            nome = Console.ReadLine(); // Atribui o valor digitado pelo usuário

            // Verifica se a entrada é nula, vazia ou contém apenas espaços
            if (string.IsNullOrWhiteSpace(nome))
            {
                nome = "usuário desconhecido" ;
            }

            Console.WriteLine($"Olá, {nome}! Seja bem-vindo.");
            Console.ReadKey();
        }
    }
}

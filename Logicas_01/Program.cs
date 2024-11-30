// Autor: Diego dos Santos Gonçalves
// Este programa é um exemplo simples de um jogo de perguntas matemáticas em C#.

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis
            // 'number' e 'number_2' armazenam os números usados na operação matemática
            int number = 10;
            int number_2 = 5;

            // Exibe a pergunta no console
            Console.WriteLine("Quanto é o " + number + " + " + number_2 + "?");

            // Lê a resposta do usuário como entrada de texto e converte para um número inteiro (int32)
            int resposta = Convert.ToInt32(Console.ReadLine());

            // Estrutura condicional para verificar a resposta do usuário
            if (resposta == 15) // Verifica se a resposta é igual à soma dos números
            {
                // Mensagem para resposta correta
                Console.WriteLine("Parabéns, acertou!");
            }
            else
            {
                // Mensagem para resposta incorreta
                Console.WriteLine("Tente novamente");
            }
        }
    }
}

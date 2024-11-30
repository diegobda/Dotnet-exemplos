/*Programa para representar CNH 
se Positivo, pode ter habilitação
se negativo, não pode ter habilitação

Dois tipos de variaveis
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CnhDotnet
{
    internal class Program
    {
        static void Main(string[] args)
        {

           /*
             // Solicitar o ano de nascimento
            Console.WriteLine("Informe o ano de nascimento: ");
            int anoNascimento = int.Parse(Console.ReadLine());
            int idade = 2024 - anoNascimento;

            if (idade >= 18) 
            {
                System.Console.WriteLine("Poe tirar a cnh");
            }else {
                System.Console.WriteLine("nao pode tirar amigao");

            }


           
            // Variável para armazenar o ano atual
            int anoAtual = DateTime.Now.Year;

            // Calcular a idade
            int idade = anoAtual - anoNascimento;

            // Verificar se a idade é suficiente para ter habilitação (18 anos ou mais)
            if (idade >= 18)
            {
                Console.WriteLine($"Você tem {idade} anos. Pode tirar a CNH!");
            }
            else
            {
                Console.WriteLine($"Você tem {idade} anos. Não pode tirar a CNH.");
            }*/

            // Aguardar antes de encerrar o programa
            Console.ReadKey();
        }
    }
}
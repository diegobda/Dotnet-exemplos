# Verificar se Número é Par ou Ímpar

Este projeto é um programa simples escrito em C# que solicita ao usuário a entrada de um número e determina se o número é **par** ou **ímpar**.

## Descrição

O programa utiliza conceitos básicos de entrada de dados pelo console, operadores matemáticos e condicionais para verificar a paridade de um número. É ideal para iniciantes que desejam aprender lógica de programação e manipulação de dados com C#.

### Lógica do Programa

1. Solicitar ao usuário a entrada de um número inteiro.
2. Verificar se o número é divisível por 2:
   - Se for divisível, é **par**.
   - Caso contrário, é **ímpar**.
3. Exibir o resultado no console.
4. Aguardar o usuário pressionar uma tecla antes de finalizar.

## Código Fonte

```csharp
using System;

namespace Numero_impar_ou_par
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Digite um número:");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine($"O número {numero} é par.");
            }
            else
            {
                Console.WriteLine($"O número {numero} é ímpar.");
            }

            Console.ReadKey();
        }
    }
}

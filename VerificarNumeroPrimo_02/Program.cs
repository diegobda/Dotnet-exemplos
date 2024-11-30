
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificarNumeroPrimo
{   
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int divisores = 0;

            Console.WriteLine("Informe o numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            // Verificar a quantidade de divisores do numero
            for (int i=1; i<numero; i++)
            {
                if (numero % i == 0)
                divisores++;
            }

            // Depois de contar a quantidade de divisores, verifica se possui apenas 2
            // um numero e primo se possui apenas dois divisores ==> 1 e o  proprio numero
            if(divisores==2)
            Console.WriteLine("E um numero primo");
            else
            {
                Console.WriteLine("Não é um número primo");


                // Aguarda que uma tecla seja pressionada
                Console.ReadKey();
            }
        }
    }
    
}
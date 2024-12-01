using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero_impar_ou_par
{
    class Program
    {
        static void Main(string[] args)
        {
            //Desenvolvar um algoritimo que solicite a entrada
            // de um numero e clacule se o numero e par ou impar
            int  numero;

            Console.WriteLine("Digite um numero amor");
            numero = Convert.ToInt32(Console.ReadLine());

            // Para verificar se e par ou impar basta analisar se e divisivel por 2
            // Se divisivel por 2 e par
            // Se nao for divisivel por 2 nao r par
            if (numero % 2 == 0)
            {
                Console.WriteLine($"o seu numero {numero} e par.");
            }
            else {
                Console.WriteLine($"o seu Numero {numero} e impar");
            }

            // Aguarda tecla clicada para fechar
            Console.ReadKey();

        }
    }
}
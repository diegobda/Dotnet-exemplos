using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AlgoritimoDivisor
{
    class Program
    {
        static void Main(string[] args) 
        {
            // For irá pecorrer de 1 até 1000 para o valor dos dividendos
            for (int i = 1; i <= 1000; i++)
            {
                //Realiza o teste, para verifica se o número (i) e divisivel
                // Utiliza % para calcula o resto da divisao
                //i%5 ==> Verifica se é divisivel por 5, logo o resto precisa ser 0
                //i%9 ==> Verifica se é divisivel por 9, logo o resto precisa ser 0
                if(i%5 == 0 && i%9 == 0)                { 
                    Console.WriteLine(i);
                }
            }
            // Aguarda que alguma tecla seja precionada
            Console.ReadKey();
        }

    }
}
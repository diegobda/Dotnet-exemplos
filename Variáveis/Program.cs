using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    public class Program
    {
        static void Main(string[] args)
        {

            /*
            //Tipos nome valor
            string texto;
            texto = "Variáveis";
            Console.WriteLine(texto);
           
            texto = "Diego dos Santos";
            Console.WriteLine(texto);
            Console.ReadKey();
           */



            // Var Tipo number
            int n1 = 2;
            int n2 = 5;

            Console.WriteLine(n1 + " > " + n2 + " = " + (n1 > n2));
            Console.WriteLine(n1 + " < " + n2 + " = " + (n1 < n2));
            Console.WriteLine(n1 + " != " + n2 + " = " + (n1 != n2));
            Console.WriteLine(n1 + " == " + n2 + " = " + (n1 == n2));
            Console.ReadKey(); 
        }
    }
}
//Diego dos santos
// 62 99801-8126

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorld
{
    /// <summary>
        /// comentarios com 3 barras para bloco
        /// </summary>
        internal class Calculator
    {
        public int Calculate(string op, int value1, int value2)
        {
            // if (op == "+")
            // {
            //     return value1 + value2;
            // }
            // else if (op == "-")
            // {
            //     return value2 - value1;
            // }
            // else if (op == "*")
            // {
            //     return value1 * value2;
            // }
            // else if (op == "/")
            // {
            //     if (value2 == 0)
            //     {
            //         throw new DivideByZeroException("Division by zero is not allowed.");
            //     }
            //     return value1 / value2;
            // }
            // else
            // {
            //     throw new ArgumentException($"Invalid operator: {op}");
            // }


/// mesma calculadora so que com switch aceita somente uma condiçao para uma regra diferença do if
            switch (op) 
            {
                case "+":
                    return value1 + value2;
                case "-":
                    return value1 - value2;
                case "*":
                    return value1 * value2;
                case "/":
                    return value1 / value2;
                default:
                    return 0;
                                
            }
        }
    }
}

// informaçoes relevantes comentar um bloco de codigo crtl + k + c para descomentar ctyrl +k +u
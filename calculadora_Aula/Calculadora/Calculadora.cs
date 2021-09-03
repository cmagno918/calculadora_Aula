using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora1
{
    class Calculadora
    {
        public static void calculo()
        {
            double num1, num2;
            string tmp;

            Console.WriteLine("Digite o primeiro número");
            tmp = Console.ReadLine();
            num1 = int.Parse(tmp);

            Console.WriteLine("Digite o segundo número");
            tmp = Console.ReadLine();
            num2 = int.Parse(tmp);

            double resultado;

            resultado = num1 * num2;
            Console.WriteLine("O resultado da sua multiplicação é: " + resultado);

            resultado = num1 + num2;
            Console.WriteLine("========================================");
            Console.WriteLine("O resultado da sua soma é: " + resultado);
            Console.WriteLine("========================================");

            resultado = num1 - num2;
            Console.WriteLine("========================================");
            Console.WriteLine("O resultado da sua Subtração é: " + resultado);
            Console.WriteLine("========================================");


            resultado = num1 / num2;
            Console.WriteLine("========================================");
            Console.WriteLine("O resultado da sua Divisão é: " + resultado);
            Console.WriteLine("========================================");
            Console.WriteLine();
            Console.Read();
        }
    }
}

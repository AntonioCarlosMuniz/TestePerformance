using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;

            Console.WriteLine("########## SOMA ##########");

            Console.WriteLine("Digite o primeiro número:");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Resultado da Soma é = " + (num1 + num2));

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            double d;
            double media;

            Console.Write("Informe o primeiro número: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Informe o segundo número: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Informe o terceiro número: ");
            c = double.Parse(Console.ReadLine());
            Console.Write("Informe o quarto número: ");
            d = double.Parse(Console.ReadLine());

            // OPERAÇÃO

            media = (a + b + c +d ) / 4;

            Console.WriteLine("A média aritmética dos quatro valores é {0}",media);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1EX2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double D;
            double L;
            double a;
            Console.Write("Insira a Diagonal do Quadrado: ");
            D = double.Parse(Console.ReadLine());

            L = D * Math.Sqrt(2);
            a = Math.Pow(L,2);

            Console.WriteLine("A area do Quadrado é {0}.", a);
        }
    }
}

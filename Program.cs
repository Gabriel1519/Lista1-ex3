using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double D;
            double L;
            double Area;

            Console.Write("Insira o valor do Diagonal numero: ");
            D = double.Parse(Console.ReadLine());
           
            L = D/Math.Sqrt(2);
            Area = Math.Pow(L,2);

            Console.WriteLine("A Area do quadrado é {0}.", Area);
        }
    }
}

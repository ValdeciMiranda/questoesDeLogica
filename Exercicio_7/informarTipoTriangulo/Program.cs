using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace informarTipoTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Por favor, digite o primeiro valor do lado do triângulo: ");
            double A = double.Parse(Console.ReadLine());

            Console.Write("Por favor, digite o segundo valor do lado do triângulo: ");
            double B = double.Parse(Console.ReadLine());

            Console.Write("Por favor, digite o terceiro valor do lado do triângulo: ");
            double C = double.Parse(Console.ReadLine());

            if (A == B && A == C)
            {
                Console.WriteLine("Este triângulo é equilátero");
            }

            else if (A == B || A == C || B == C)
            {
                Console.WriteLine("Este triângulo é isósceles");
            }

            if (A != B && A != C && C != B)
            {
                Console.WriteLine("Este triângulo é escaleno");
            }

            Console.ReadKey();
        }
    }
}

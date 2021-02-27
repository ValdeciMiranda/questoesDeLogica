using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leituraProdutoSoma
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;
            int C;
            int D;

            Console.Write("Digite o primeiro valor a ser multiplicado: ");
            A = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor a ser somado: ");
            B = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro valor a ser multiplicado: ");
            C = int.Parse(Console.ReadLine());

            Console.Write("Digite o quarto valor a ser somado: ");
            D = int.Parse(Console.ReadLine());

            int P = A * C;
            Console.WriteLine("O produto do primeiro com o terceiro valor é de " + P);

            int S = B + D;
            Console.WriteLine("A soma entre o segundo com o quarto valor é de " + S);

            Console.ReadKey();
        }
    }
}

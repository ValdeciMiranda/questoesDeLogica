using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leituraOrdemCrescente
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;

            Console.Write("Digite o primeiro numero ");
            A = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero ");
            B = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro numero ");
            C = int.Parse(Console.ReadLine());

            Console.WriteLine("Os números digitados em forma crescente são ");

            /*
            if (A < B)
            { 
                if (B < C)
                    Console.WriteLine(A);
                    Console.WriteLine(B);
                    Console.WriteLine(C);
            }
            */

            if (A < B && B < C)
            {
                Console.WriteLine(A);
                Console.WriteLine(B);
                Console.WriteLine(C);
            }
            if (A < C && C < B)
            {
                Console.WriteLine(A);
                Console.WriteLine(C);
                Console.WriteLine(B);
            }
            if (B < A && B < C)
            {
                Console.WriteLine(B);
                Console.WriteLine(A);
                Console.WriteLine(C);
            }
            if (C < A && C < B)
            {
                Console.WriteLine(C);
                Console.WriteLine(A);
                Console.WriteLine(B);
            }

            Console.ReadLine();
        }
    }
}

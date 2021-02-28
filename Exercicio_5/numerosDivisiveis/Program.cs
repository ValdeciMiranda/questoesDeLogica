using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numerosDivisiveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Por favor, digite o primeiro numero inteiro: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Por favor, digite o segundo numero inteiro: ");
            int B = int.Parse(Console.ReadLine());

            Console.Write("Por favor, digite o terceiro numero inteiro: ");
            int C = int.Parse(Console.ReadLine());

            Console.Write("Por favor, digite o quarto numero inteiro: ");
            int D = int.Parse(Console.ReadLine());


            Console.WriteLine("Os números divisíveis por 2 e por 3 são: ");

            if (A % 3 == 0 && A % 2 == 0)
            {
                Console.WriteLine(A + " é divisível por 2 e por 3");
            }

            else if (A % 2 == 0)
            {
                Console.WriteLine(A + " é divisível por 2");
            }

            else if (A % 3 == 0)
            {
                Console.WriteLine(A + " é divisível por 3");
            }

            if (B % 3 == 0 && B % 2 == 0)
            {
                Console.WriteLine(B + " é divisível por 2 e por 3");
            }

            else if (B % 2 == 0)
            {
                Console.WriteLine(B + " é divisível por 2");
            }

            else if (B % 3 == 0)
            {
                Console.WriteLine(B + " é divisível por 3");
            }

            if (C % 3 == 0 && C % 2 == 0)
            {
                Console.WriteLine(C + " é divisível por 2 e por 3");
            }

            else if (C % 2 == 0)
            {
                Console.WriteLine(C + " é divisível por 2");
            }

            else if (C % 3 == 0)
            {
                Console.WriteLine(C + " é divisível por 3");
            }

            if (D % 3 == 0 && D % 2 == 0)
            {
                Console.WriteLine(D + " é divisível por 2 e por 3");
            }

            else if (D % 2 == 0)
            {
                Console.WriteLine(D + " é divisível por 2");
            }

            else if (D % 3 == 0)
            {
                Console.WriteLine(D + " é divisível por 3");
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrizVerificaParImparMultiplicaSoma
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[10];
            int[] B = new int[10];

            Console.WriteLine("Insira 10 valores numéricos inteiros para a multiplicação do valor por 5 caso for par, se não for será somado 5 ao valor.");

            Console.Write("1° Valor: ");
            A[0] = int.Parse(Console.ReadLine());
            Console.Write("2° Valor: ");
            A[1] = int.Parse(Console.ReadLine());
            Console.Write("3° Valor: ");
            A[2] = int.Parse(Console.ReadLine());
            Console.Write("4° Valor: ");
            A[3] = int.Parse(Console.ReadLine());
            Console.Write("5° Valor: ");
            A[4] = int.Parse(Console.ReadLine());
            Console.Write("6° Valor: ");
            A[5] = int.Parse(Console.ReadLine());
            Console.Write("7° Valor: ");
            A[6] = int.Parse(Console.ReadLine());
            Console.Write("8° Valor: ");
            A[7] = int.Parse(Console.ReadLine());
            Console.Write("9° Valor: ");
            A[8] = int.Parse(Console.ReadLine());
            Console.Write("10° Valor: ");
            A[9] = int.Parse(Console.ReadLine());

            foreach (int numero in A)
            {
                if (A[0] % 2 == 0)
                {
                    B[0] = A[0] * 5;
                }
                else
                {
                    B[0] = A[0] + 5;
                }
                if (A[1] % 2 == 0)
                {
                    B[1] = A[1] * 5;
                }
                else
                {
                    B[1] = A[1] + 5;
                }
                if (A[2] % 2 == 0)
                {
                    B[2] = A[2] * 5;
                }
                else
                {
                    B[2] = A[2] + 5;
                }
                if (A[3] % 2 == 0)
                {
                    B[3] = A[3] * 5;
                }
                else
                {
                    B[3] = A[3] + 5;
                }
                if (A[4] % 2 == 0)
                {
                    B[4] = A[4] * 5;
                }
                else
                {
                    B[4] = A[4] + 5;
                }
                if (A[5] % 2 == 0)
                {
                    B[5] = A[5] * 5;
                }
                else
                {
                    B[5] = A[5] + 5;
                }
                if (A[6] % 2 == 0)
                {
                    B[6] = A[6] * 5;
                }
                else
                {
                    B[6] = A[6] + 5;
                }
                if (A[7] % 2 == 0)
                {
                    B[7] = A[7] * 5;
                }
                else
                {
                    B[7] = A[7] + 5;
                }
                if (A[8] % 2 == 0)
                {
                    B[8] = A[8] * 5;
                }
                else
                {
                    B[8] = A[8] + 5;
                }
                if (A[9] % 2 == 0)
                {
                    B[9] = A[9] * 5;
                }
                else
                {
                    B[9] = A[9] + 5;
                }
            }

            Console.WriteLine("Os valores das matrizes A e B respectivamente são: ");

            Console.WriteLine("A");

            foreach (int numero in A)
            {
                Console.WriteLine("O valor da matriz A: " + numero);
            }

            Console.WriteLine("B");

            foreach (int numero in B)
            {
                Console.WriteLine("O valor da matriz B: " + numero);
            }

            Console.ReadKey();

        }
    }
}

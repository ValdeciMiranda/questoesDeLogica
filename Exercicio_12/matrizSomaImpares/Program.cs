using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrizSomaImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[10];
            int[] impares = new int[10];

            Console.WriteLine("Ensira 10 valores numéricos inteiros para a soma dos impares");

            Console.Write("1° Valor: ");
            A[0] = int.Parse(Console.ReadLine()) ;
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
                if (A[0] % 2 != 0)
                {
                    impares[0] = A[0];
                }
                if (A[1] % 2 != 0)
                {
                    impares[1] = A[1];
                }
                if (A[2] % 2 != 0)
                {
                    impares[2] = A[2];
                }
                if (A[3] % 2 != 0)
                {
                    impares[3] = A[3];
                }
                if (A[4] % 2 != 0)
                {
                    impares[4] = A[4];
                }
                if (A[5] % 2 != 0)
                {
                    impares[5] = A[5];
                }
                if (A[6] % 2 != 0)
                {
                    impares[6] = A[6];
                }
                if (A[7] % 2 != 0)
                {
                    impares[7] = A[7];
                }
                if (A[8] % 2 != 0)
                {
                    impares[8] = A[8];
                }
                if (A[9] % 2 != 0)
                {
                    impares[9] = A[9];
                }
            }

            int soma = impares[0] + impares[1] + impares[2] + impares[3] + impares[4] + impares[5] + impares[6] + impares[7] + impares[8] + impares[9];

            Console.WriteLine("A soma de todos os números impares inseridos são: "+ soma);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace armazenarMatrizEmOutraMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[10];
            int[] B = new int[10];

            Console.Write("Por favor digite o 1° valor da matriz A: ");
            A[0] = int.Parse(Console.ReadLine());
            Console.Write("Por favor digite o 2° valor da matriz A: ");
            A[1] = int.Parse(Console.ReadLine());
            Console.Write("Por favor digite o 3° valor da matriz A: ");
            A[2] = int.Parse(Console.ReadLine());
            Console.Write("Por favor digite o 4° valor da matriz A: ");
            A[3] = int.Parse(Console.ReadLine());
            Console.Write("Por favor digite o 5° valor da matriz A: ");
            A[4] = int.Parse(Console.ReadLine());
            Console.Write("Por favor digite o 6° valor da matriz A: ");
            A[5] = int.Parse(Console.ReadLine());
            Console.Write("Por favor digite o 7° valor da matriz A: ");
            A[6] = int.Parse(Console.ReadLine());
            Console.Write("Por favor digite o 8° valor da matriz A: ");
            A[7] = int.Parse(Console.ReadLine());
            Console.Write("Por favor digite o 9° valor da matriz A: ");
            A[8] = int.Parse(Console.ReadLine());
            Console.Write("Por favor digite o 10° valor da matriz A: ");
            A[9] = int.Parse(Console.ReadLine());


            B[0] = A[0] * 3;
            B[1] = A[1] * 3;
            B[2] = A[2] * 3;
            B[3] = A[3] * 3;
            B[4] = A[4] * 3;
            B[5] = A[5] * 3;
            B[6] = A[6] * 3;
            B[7] = A[7] * 3;
            B[8] = A[8] * 3;
            B[9] = A[9] * 3;

            Console.WriteLine("Os valores da matriz A foram multiplicados por 3 e seus valores foram armazenados na matriz B, veja: ");
            foreach (int numero in B)
            {
                Console.WriteLine("O valor da matriz B: " + numero);
            }

            Console.WriteLine("Os valores da matriz A originais eram: ");
            foreach (int numero in A)
            {
                Console.WriteLine("O valor da matriz A: " + numero);
            }

            /*
            Console.WriteLine("Os valores da matriz A foram multiplicados por 3 e seus valores foram armazenados na matriz B, veja: ");
            Console.WriteLine("O 1° valor da matriz B: " + B[0]);
            Console.WriteLine("O 2° valor da matriz B: " + B[1]);
            Console.WriteLine("O 3° valor da matriz B: " + B[2]);
            Console.WriteLine("O 4° valor da matriz B: " + B[3]);
            Console.WriteLine("O 5° valor da matriz B: " + B[4]);
            Console.WriteLine("O 6° valor da matriz B: " + B[5]);
            Console.WriteLine("O 7° valor da matriz B: " + B[6]);
            Console.WriteLine("O 8° valor da matriz B: " + B[7]);
            Console.WriteLine("O 9° valor da matriz B: " + B[8]);
            Console.WriteLine("O 10° valor da matriz B: " + B[9]);
            */


            Console.ReadKey();
        }
    }
}

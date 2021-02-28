using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leituraMaiorMenor
{
    class Program
    {
        static void Main(string[] args)
        {

            int maior = 0, menor, contador = 0;

            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());
            menor = numero;
            numero = maior;
            contador = 1;

            for (contador = 2; contador <= 5; contador++)
            {
                Console.Write("Digite um número inteiro: ");
                numero = int.Parse(Console.ReadLine());
                if (numero < menor)
                {
                    menor = numero;
                }
                if (numero > maior)
                {
                    maior = numero;
                }
            }

            Console.WriteLine("O maior número informado foi " + maior + " o menor numero informado foi " + menor);

            /*
            Console.Write("Digite o segundo número inteiro: ");
            int B = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número inteiro: ");
            int C = int.Parse(Console.ReadLine());

            Console.Write("Digite o quarto número inteiro: ");
            int D = int.Parse(Console.ReadLine());

            Console.Write("Digite o quinto número inteiro: ");
            int E = int.Parse(Console.ReadLine());
            */
            

            //MAIORES

            /*
            if (A > B && A > C && A > D && A > E)
            {
                Console.WriteLine(A + " é o maior valor.");
            }

            if (B > A && B > C && B > D && B > E)
            {
                Console.WriteLine(B + " é o maior valor.");
            }

            if (C > A && C > B && C > D && C > E)
            {
                Console.WriteLine(A + " é o maior valor.");
            }

            if (D > A && D > B && D > C && D > E)
            {
                Console.WriteLine(A + " é o maior valor.");
            }

            if (E > A && E > B && E > C && E > D)
            {
                Console.WriteLine(A + " é o maior valor.");
            }

            //MENORES

            if (A < B && A < C && A < D && A < E)
            {
                Console.WriteLine(A + " é o maior valor.");
            }

            if (B < A && B < C && B < D && B < E)
            {
                Console.WriteLine(A + " é o menor valor.");
            }

            if (C < A && C < B && C < D && C < E)
            {
                Console.WriteLine(A + " é o menor valor.");
            }

            if (D < A && D < C && D < B && D < E)
            {
                Console.WriteLine(A + " é o menor valor.");
            }

            if (E < A && E < C && E < D && E < B)
            {
                Console.WriteLine(A + " é o menor valor.");
            }
            */

            Console.ReadKey();
        }
    }
}

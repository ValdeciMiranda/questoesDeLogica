using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculoFatorialCincoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int numero = 5;
            int fatorial = 1;

            while(contador < numero)
            {
                contador++;
                fatorial = fatorial * contador;
            }

            Console.WriteLine("A fatorial de 5 é " + fatorial);
            Console.ReadKey();
        }
    }
}

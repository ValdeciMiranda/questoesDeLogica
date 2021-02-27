using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace somaMultiplicacaoDistributiva
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;
            int C;
            int D;


            Console.Write("Por favor digite o primeiro numero: ");
            A = int.Parse(Console.ReadLine());

            Console.Write("Por favor digite o segundo numero: ");
            B = int.Parse(Console.ReadLine());

            Console.Write("Por favor digite o terceiro numero: ");
            C = int.Parse(Console.ReadLine());

            Console.Write("Por favor digite o quarto numero: ");
            D = int.Parse(Console.ReadLine());

            //A
            Console.WriteLine("O resultado da soma entre o primeiro e segundo valor é de " + A + B + " e da multiplicação é de " + A * B);
            Console.WriteLine("O resultado da soma entre o primeiro e terceiro valor é de " + A + C + " e da multiplicação é de " + A * C);
            Console.WriteLine("O resultado da soma entre o primeiro e quarto valor é de " + A + D + " e da multiplicação é de " + A * D);

            //B
            Console.WriteLine("O resultado da soma entre o segundo e terceiro valor é de " + B + C + " e da multiplicação é de " + B * C);
            Console.WriteLine("O resultado da soma entre o segundo e quarto valor é de " + B + D + " e da multiplicação é de " + B * D);

            //C
            Console.WriteLine("O resultado da soma entre o terceiro e quarto valor é de " + C + D + " e da multiplicação é de " + C * D);

            Console.ReadKey();
        }
    }
}

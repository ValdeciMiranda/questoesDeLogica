using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leituraDezNomesMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];

            Console.Write("1 - Digite um nome: ");
            nomes[0] = Console.ReadLine();
            Console.Write("2 - Digite um nome: ");
            nomes[1] = Console.ReadLine();
            Console.Write("3 - Digite um nome: ");
            nomes[2] = Console.ReadLine();
            Console.Write("4 - Digite um nome: ");
            nomes[3] = Console.ReadLine();
            Console.Write("5 - Digite um nome: ");
            nomes[4] = Console.ReadLine();
            Console.Write("6 - Digite um nome: ");
            nomes[5] = Console.ReadLine();
            Console.Write("7 - Digite um nome: ");
            nomes[6] = Console.ReadLine();
            Console.Write("8 - Digite um nome: ");
            nomes[7] = Console.ReadLine();
            Console.Write("9 - Digite um nome: ");
            nomes[8] = Console.ReadLine();
            Console.Write("10 -Digite um nome: ");
            nomes[9] = Console.ReadLine();

            Console.WriteLine("Os nomes digitados foram");
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }

            Console.ReadKey();
        }
    }
}

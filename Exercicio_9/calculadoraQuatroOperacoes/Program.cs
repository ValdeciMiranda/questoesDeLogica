using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraQuatroOperacoes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Deseja fazer uma nova operação? digite 1 para SIM e 2 para NÃO: ");
            int decisao = int.Parse(Console.ReadLine());

            while(decisao == 1)
            {

                Console.WriteLine("Por favor, antes de selecionar-mos a operação desejada insira os valores que serão usados nesta ooperação.");

                Console.Write("Insira o primeiro valor: ");
                double valor1 = double.Parse(Console.ReadLine());
                Console.Write("Agora insira o segundo valor: ");
                double valor2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Por favor, selecione uma das operações da lista: ");
                Console.WriteLine("(Para seleciona-la basta digitar sua letra inicial correspondente em minusculo.)");
                Console.WriteLine("\ta - Adição");
                Console.WriteLine("\ts - Subtração");
                Console.WriteLine("\tm - Multiplicação");
                Console.WriteLine("\td - Divisão");
                Console.Write("Então, qual operação deseja efetuar? ");

                switch (Console.ReadLine())
                {
                    case "a":
                        Console.WriteLine($"O resultado da soma: {valor1} + {valor2} = " + (valor1 + valor2));
                        break;
                    case "s":
                        Console.WriteLine($"O resultado da subtração: {valor1} - {valor2} = " + (valor1 - valor2));
                        break;
                    case "m":
                        Console.WriteLine($"O resultado da multiplicação: {valor1} * {valor2} = " + (valor1 * valor2));
                        break;
                    case "d":
                        Console.WriteLine($"O resultado da divisão: {valor1} / {valor2} = " + (valor1 / valor2));
                        break;
                }

                Console.Write("Deseja fazer uma nova operação? digite 1 para SIM e 2 para NÃO: ");
                decisao = int.Parse(Console.ReadLine());
            }
            if (decisao == 2)
            {
                Console.WriteLine("Obrigado por calcular conosco.");
            }

            Console.ReadKey();
        }
    }
}

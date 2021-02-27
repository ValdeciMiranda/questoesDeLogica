using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculoCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            const int kmPorLitro = 12;
            double tempo;
            double velocidade;
            double distancia;

            Console.WriteLine("Por favor, digite para mim o tempo gasto durante a viagem: ");
            tempo = double.Parse(Console.ReadLine());

            Console.WriteLine("Por favor, agora digite para mim a velocidade média durante a viagem: ");
            velocidade = double.Parse(Console.ReadLine()); 

            distancia = tempo * velocidade;

            double litros_usados = distancia / kmPorLitro;

            Console.WriteLine("Bom, de acordo com você a velocidade média foi de " + velocidade + " o tempo gasto na viagem foi de " + tempo + " sendo assim a distância\n percorrida foi de " + distancia + ", seu automóvel faz " + kmPorLitro + " kilometros por litro, portando dividindo a distância\n percorrida por este número obtemos assim a quantidade de litros usados de " + litros_usados);

            Console.ReadKey();

        }
    }
}

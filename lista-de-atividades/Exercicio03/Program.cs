using System;

namespace Exercicio03
{
    class Program
    {
        public static void Main()
        {
            double[] numDecimal = new double[2];

            Console.WriteLine("Digite o primeiro número");
            numDecimal[0] = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            numDecimal[1] = double.Parse(Console.ReadLine());

            if (numDecimal[1] != 0)
            {
                double media = numDecimal[0] / numDecimal[1];
                Console.WriteLine("A média será: " + media);
            }
            else 
            {
                Console.WriteLine("Divisão por zero não é permitida.");
            }
            Console.ReadKey();
        }
    }
}
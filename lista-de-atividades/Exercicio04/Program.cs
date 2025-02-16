using System;

namespace Exercicio04
{
    class Program
    {
        public static void Main()
        {
            int[] numeros = new int[4];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            int maior = numeros[0];

            foreach (int numero in numeros)
            {
                if( numero > maior)
                {
                    maior = numero;
         
                }
            }
            Console.WriteLine("O maior numero é: " + maior);
            Console.ReadKey();
        }
    }
}
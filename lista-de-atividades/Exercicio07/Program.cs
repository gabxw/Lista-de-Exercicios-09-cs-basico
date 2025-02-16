using System;

namespace Exercicio07
{
    class Program
    {
        public static void Main()
        {
            int[] num1 = new int[5];
            int[] num2 = new int[5];

            for (int i = 0; i < num1.Length; i++)
            {
                Console.WriteLine($"\nDigite o {i + 1}° da primeira lista");
                num1[i] = int.Parse(Console.ReadLine());

                Console.WriteLine($"\nDigite o {i + 1}° da segunda lista");
                num2[i] = int.Parse(Console.ReadLine());
            }
            int[] somaArray = new int[num1.Length];

            for (int x = 0; x < num1.Length; x++)
            {
                somaArray[x] = num1[x] + num2[x];
            }

            Console.WriteLine("A soma dos vetores é:");
            for (int i = 0; i < somaArray.Length; i++)
            {
                Console.WriteLine($"Posição {i + 1}: {somaArray[i]}");
            }
            Console.ReadKey();
        }
    }
}
using System;

namespace Exercicio07
{
    class Program
    {
        public static void Main()
        {
            int[] num = new int[5] {7,8,5,3,4};

            Array.Sort(num);
            Array.Reverse(num);

            Console.WriteLine("Valores em ordem decrescente:");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }

            Console.WriteLine("Aperte para sair");
            Console.ReadKey();
        }
    }
}
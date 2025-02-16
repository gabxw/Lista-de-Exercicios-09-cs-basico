using System;

namespace Exercicio05
{
    class Program
    {
        public static void Main()
        {
            int[] num = new int[4];
            
            for(int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"Digite {num[i] + 1}° numero");
                num[i] = int.Parse(Console.ReadLine());
            }

            int menor = num[0];

            foreach(int nums in num)
            {
                if (nums < menor)
                {
                    menor = nums;
                }
            }
            Console.WriteLine("O menor número é: "+ menor);

            Console.ReadKey();
        }
    }
}
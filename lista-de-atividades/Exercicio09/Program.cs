using System;

namespace Exercicio09
{
    class Program
    {
        public static void Main()
        {
            string[] nome = new string[10];
            for (int i = 0; i < nome.Length; i++)
            {
                Console.WriteLine($"\nDigite da {i + 1}° pessoa");
                nome[i] = Console.ReadLine();
            }

            foreach (string x in nome)
            {
                
                Console.WriteLine(x);
            }

            Console.WriteLine("aperte algo para finalizar");
            Console.ReadKey();
        }
    }
}

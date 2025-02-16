using System;

namespace exercicio01
{
    class Program
    {
        public static void Main()
        {
            int[] numeros = new int[5];

            numeros[0] = 1;
            numeros[1] = 2;
            numeros[2] = 3;
            numeros[3] = 4;
            numeros[4] = 5;


            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("Aperte alguma tecla para poder sair");
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;

namespace Lista_de_Exercicios_08_cs_basico
{
    // Classe Pessoa
    class Pessoa
    {
        public string Nome { get; set; } // Propriedade para o nome
        public int[] Notas { get; set; } // Propriedade para as notas

        public Pessoa()
        {
            Nome = string.Empty;
            Notas = Array.Empty<int>();
        }
    }

    internal class Exercicio02
    {
        static void Main(string[] args)
        {
            // Criando uma lista de pessoas
            List<Pessoa> pessoas = new List<Pessoa>();

            // Adicionando pessoas à lista
            pessoas.Add(new Pessoa { Nome = "Gabriel", Notas = new int[] { 8, 9, 7 } });
            pessoas.Add(new Pessoa { Nome = "Matheus", Notas = new int[] { 10, 2, 7 } });
            pessoas.Add(new Pessoa { Nome = "Athur", Notas = new int[] { 4, 5, 8 } });
            pessoas.Add(new Pessoa { Nome = "Borba", Notas = new int[] { 3, 9, 5 } });
            pessoas.Add(new Pessoa { Nome = "Ana", Notas = new int[] { 6, 1, 5 } });

            // Exibindo as notas de cada pessoa
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine($"As notas de {pessoa.Nome}: {string.Join(", ", pessoa.Notas)}");
            }
        }
    }
}
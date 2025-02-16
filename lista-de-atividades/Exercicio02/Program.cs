using System;
using System.Collections.Generic;

namespace Exercicio02
{
    class Program
    {
        public static void Main()
        {
            // Cria uma lista de alunos
            List<Pessoa> alunos = new List<Pessoa>();

            // Adiciona alunos à lista com suas notas
            alunos.Add(new Pessoa("gabriel", new double[] { 7.5, 8.9 }));
            alunos.Add(new Pessoa("joão", new double[] { 4.5, 2.6 }));
            alunos.Add(new Pessoa("matheus", new double[] { 3.3, 4.9 }));
            alunos.Add(new Pessoa("vitor", new double[] { 7.2, 8.0 }));
            alunos.Add(new Pessoa("ana", new double[] { 7.7, 8.4 }));

            // Exibe os alunos e suas notas
            foreach (Pessoa aluno in alunos)
            {
                Console.WriteLine($"Aluno: {aluno.Nome}");
                Console.WriteLine("Notas: ");
                foreach (double nota in aluno.Notas)
                {
                    Console.WriteLine(nota);
                }
                Console.WriteLine(); // Linha em branco para separar os alunos
            }

            Console.WriteLine("Aperte algo para sair...");
            Console.ReadKey();
        }
    }
}
class Pessoa
{
    public string Nome { get; set; } // Propriedade para o nome do aluno
    public double[] Notas { get; set; } // Propriedade para as notas do aluno

    // Construtor para inicializar o nome e as notas
    public Pessoa(string nome, double[] notas)
    {
        Nome = nome;
        Notas = notas;
    }
}
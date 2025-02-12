using System;

namespace Lista_de_Exercicios_08_cs_basico
{
    class Aluno
    {
        // Properties
        public string Nome { get; set; }
        public double Nota { get; set; }

        // Constructor
        public Aluno(string nome, double nota)
        {
            Nome = nome;
            Nota = nota;
        }

        // Default Constructor
        public Aluno()
        {
        }
    }
}
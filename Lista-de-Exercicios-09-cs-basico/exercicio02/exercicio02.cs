
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Exercicios_08_cs_basico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno gabriel = new Aluno("gabriel", 2);
            
            Console.WriteLine($"Aluno 2: Nome = {gabriel.Nome}, Nota = {gabriel.Nota}");
        }
    }
}

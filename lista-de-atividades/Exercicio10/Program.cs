using System;
using System.Collections.Generic;

namespace Exercicio10
{
    class Program
    {
        static List<Mercadoria> mercadorias = new List<Mercadoria>();

        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("================ Menu ================");
                Console.WriteLine("1. Cadastrar mercadoria");
                Console.WriteLine("2. Exibir valor total em mercadorias da empresa");
                Console.WriteLine("3. Sair");
                Console.Write("OPÇÃO: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastrarMercadoria();
                        break;
                    case 2:
                        ExibirValorTotal();
                        break;
                    case 3:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 3);
        }

        static void CadastrarMercadoria()
        {
            Console.Clear();
            Console.WriteLine("================ Cadastramento de novo item ================");

            Console.Write("Nome da mercadoria: ");
            string nome = Console.ReadLine();

            Console.Write("Quantidade em estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.Write("Preço unitário: ");
            double preco = double.Parse(Console.ReadLine());

            mercadorias.Add(new Mercadoria(nome, quantidade, preco));
            Console.WriteLine("Mercadoria cadastrada com sucesso!");
        }

        static void ExibirValorTotal()
        {
            Console.Clear();
            Console.WriteLine("================ Valor total em mercadorias ================");

            double valorTotal = 0;
            foreach (var mercadoria in mercadorias)
            {
                valorTotal += mercadoria.QuantidadeEstoque * mercadoria.PrecoUnitario;
            }

            Console.WriteLine($"Valor total em mercadorias: R$ {valorTotal:F2}");
        }
    }

    public class Mercadoria
    {
        public string Nome { get; set; }
        public int QuantidadeEstoque { get; set; }
        public double PrecoUnitario { get; set; }

        public Mercadoria(string nome, int quantidadeEstoque, double precoUnitario)
        {
            Nome = nome;
            QuantidadeEstoque = quantidadeEstoque;
            PrecoUnitario = precoUnitario;
        }
    }
}
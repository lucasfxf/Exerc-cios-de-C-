using System;
using System.Collections.Generic; // Necessário para usar List<>

struct Produto
{
    public string Nome;
    public float Preco;
    public int Quantidade;

    public float Total()
    {
        return Preco * Quantidade;
    }
}

class Program
{
    static void Main()
    {
        // Criando a lista de produtos
        List<Produto> produtos = new List<Produto>();

        string resposta = "s";

        while (resposta == "s" || resposta == "S")
        {
            Produto p = new Produto();

            Console.WriteLine("\n=== Cadastro de Produto ===");

            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = float.Parse(Console.ReadLine());

            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            // Adiciona o produto na lista
            produtos.Add(p);

            Console.Write("\nDeseja cadastrar outro produto? (s/n): ");
            resposta = Console.ReadLine();
        }

        // Mostrar os produtos cadastrados
        Console.WriteLine("\n=== Lista de Produtos ===");

        float totalGeral = 0;

        foreach (Produto p in produtos)
        {
            Console.WriteLine($"{p.Nome} - R${p.Preco} x {p.Quantidade} = R${p.Total()}");
            totalGeral += p.Total();
        }

        Console.WriteLine($"\nValor total do estoque: R${totalGeral}");
    }
}

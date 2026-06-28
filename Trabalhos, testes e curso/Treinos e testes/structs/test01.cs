using System;

struct Produto
{
    public string Nome;
    public float Preco;
    public int Quantidade;

    // Função dentro da struct
    public float Total()
    {
        return Preco * Quantidade;
    }
}

class test01
{
    static void Main()
    {
        // Declaração do vetor de 3 produtos
        Produto[] produto = new Produto[3];

        // Entrada de dados
        for (int i = 0; i < produto.Length; i++)
        {
            Console.WriteLine("\n*** Produto ***");

            Console.Write("Nome: ");
            produto[i].Nome = Console.ReadLine();

            Console.Write("Preço: ");
            produto[i].Preco = float.Parse(Console.ReadLine()!);

            Console.Write("Quantidade: ");
            produto[i].Quantidade = int.Parse(Console.ReadLine());
        }

        // Saída de dados
        Console.WriteLine("\n=== Lista de Produtos ===");
        for (int i = 0; i < produto.Length; i++)
        {
            Console.WriteLine($"Produto {i + 1}: {produto[i].Nome} - Total: R${produto[i].Total()}");
        }
    }
}

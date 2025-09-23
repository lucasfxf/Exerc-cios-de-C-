using System;
using System.Linq;

class Carnaval
{
    static void Main()
    {
        // Lê as 5 notas em uma única linha
        string[] entrada = Console.ReadLine().Split();
        double[] notas = entrada.Select(double.Parse).ToArray();

        // Ordena as notas
        Array.Sort(notas);

        // Soma as três notas centrais (exclui menor e maior)
        double soma = notas[1] + notas[2] + notas[3];

        // Mostra resultado com uma casa decimal
        Console.WriteLine(soma.ToString("F1"));
    }
}

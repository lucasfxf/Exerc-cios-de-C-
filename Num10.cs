using System;

class Ex10
{
    static void Main()
    {
        Console.Write("Digite quantas vezes o dado será lançado: ");
        int n = int.Parse(Console.ReadLine());

        int[] resultados = new int[n];
        int[] contagem = new int[6];
        Random rnd = new Random();

        for (int i = 0; i < n; i++)
        {
            resultados[i] = rnd.Next(1, 7); // de 1 a 6
            contagem[resultados[i] - 1]++;
        }

        Console.WriteLine("Resultados: " + string.Join(", ", resultados));
        Console.WriteLine("\nOcorrências de cada face:");
        for (int i = 0; i < 6; i++)
            Console.WriteLine($"Face {i + 1}: {contagem[i]} vezes");
    }
}

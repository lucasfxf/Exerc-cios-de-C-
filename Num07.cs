using System;

class Ex7
{
    static void Main()
    {
        Console.Write("Digite o tamanho dos vetores: ");
        int n = int.Parse(Console.ReadLine());

        int[] vetor1 = new int[n];
        int[] vetor2 = new int[n];
        int[] resultado = new int[n];

        Random rnd = new Random();

        Console.WriteLine("Vetor 1:");
        for (int i = 0; i < n; i++)
        {
            vetor1[i] = rnd.Next(1, 10);
            Console.Write(vetor1[i] + " ");
        }

        Console.WriteLine("\nVetor 2:");
        for (int i = 0; i < n; i++)
        {
            vetor2[i] = rnd.Next(1, 10);
            Console.Write(vetor2[i] + " ");
        }

        Console.WriteLine("\nVetor resultado (multiplicação):");
        for (int i = 0; i < n; i++)
        {
            resultado[i] = vetor1[i] * vetor2[i];
            Console.Write(resultado[i] + " ");
        }
    }
}

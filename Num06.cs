using System;

class Matriz06
{
    static void Main()
    {
        Random rnd = new Random();

        Console.Write("Digite quantos números deseja sortear: ");
        int n = int.Parse(Console.ReadLine());

        int[] vetor = new int[n];
        for (int i = 0; i < n; i++)
            vetor[i] = rnd.Next(1, 101); // números de 1 a 100

        Console.WriteLine("Números sorteados: " + string.Join(", ", vetor));

        Console.Write("Digite um número para procurar: ");
        int procurado = int.Parse(Console.ReadLine());

        bool encontrado = false;
        for (int i = 0; i < n; i++)
        {
            if (vetor[i] == procurado)
            {
                Console.WriteLine($"Número encontrado na posição {i}");
                encontrado = true;
            }
        }

        if (!encontrado)
            Console.WriteLine("Número não encontrado no vetor.");
    }
}

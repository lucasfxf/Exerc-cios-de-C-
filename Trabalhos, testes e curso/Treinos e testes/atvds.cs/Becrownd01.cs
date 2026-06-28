using System;

class Becrownd01
{
    static void Main()
    {
        // Pergunta o tamanho do vetor
        Console.Write("Digite a quantidade de elementos (N): ");
        int N = int.Parse(Console.ReadLine()!);

        // Cria o vetor
        int[] vetor = new int[N];

        // Preenche o vetor
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Digite o valor da posição {i}: ");
            vetor[i] = int.Parse(Console.ReadLine()!);
        }

        // Apresenta o vetor
        Console.WriteLine("\nVetor digitado:");
        for (int i = 0; i < N; i++)
        {
            Console.Write(vetor[i] + " ");
        }

        // Encontra menor valor e posição
        int menor = vetor[0];
        int posicao = 0;
        for (int i = 1; i < vetor.Length; i++)
        {
            if (vetor[i] < menor)
            {
                menor = vetor[i];
                posicao = i;
            }
        }

        // Resultado
        Console.WriteLine("\n\nMenor valor do vetor: " + menor);
        Console.WriteLine("Posição do menor valor: " + posicao);
    }
}

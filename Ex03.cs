using System;

class Ex03
{
    static void Main()
    {
        // Interação
        Console.Write("Digite o tamanho do vetor: ");
        int tamanho = int.Parse(Console.ReadLine()!);

        // Declaração
        float[] vet = new float[tamanho];

        // Preenchimento do vetor
        for (int i = 0; i < tamanho; i++)
        {
            Console.Write($"Digite os valores de cada posição {i}: ");
            vet[i] = float.Parse(Console.ReadLine()!);
        }

        // Apresenta o vetor
        Console.WriteLine("\nVetor digitado:");
        for (int i = 0; i < tamanho; i++)
        {
            Console.Write(vet[i] + " ");
        }
        Console.WriteLine();

        // Chama a função para achar o menor valor
        float menor = MenorElemento(vet);

        // Resultado
        Console.WriteLine("Menor valor do vetor: " + menor);
    }

    // Função que retorna o menor elemento do vetor
    static float MenorElemento(float[] vetor)
    {
        float menor = vetor[0]; // começa com o primeiro elemento

        for (int i = 1; i < vetor.Length; i++)
        {
            if (vetor[i] < menor)
            {
                menor = vetor[i];
            }
        }

        return menor;
    }
}

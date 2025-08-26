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

        // Chama a função para achar o maior valor
        float maior = MaiorElemento(vet);

        // Resultado
        Console.WriteLine("Maior valor do vetor: " + maior);
    }

    // Função que retorna o maior elemento do vetor
    static float MaiorElemento(float[] vetor)
    {
        float maior = vetor[0]; // começa com o primeiro elemento

        for (int i = 1; i < vetor.Length; i++)
        {
            if (vetor[i] > maior)
            {
                maior = vetor[i];
            }
        }

        return maior;
    }
}

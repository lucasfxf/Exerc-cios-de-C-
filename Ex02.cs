using System;

class Ex02
{
    static void Main()
    {
        // Tamanho
        Console.Write("Digite o tamanho do vetor: ");
        int tamanho = int.Parse(Console.ReadLine()!);

        // Declaração
        int[] vet = new int[tamanho];

        // Preenchimento do vetor
        for (int i = 0; i < tamanho; i++)
        {
            Console.Write($"Digite o número da posição {i}: ");
            vet[i] = int.Parse(Console.ReadLine()!);
        }

        // Chamando a função que conta ímpares
        int quantidadeImpares = ContaImpares(vet);

        // Resultado
        Console.WriteLine("\nQuantidade de valores ímpares: " + quantidadeImpares);
    }

    // Função que conta os ímpares em um vetor
    static int ContaImpares(int[] vetor)
    {
        int contador = 0;
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] % 2 != 0)
            {
                contador++;
            }
        }
        return contador;
    }
}

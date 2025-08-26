using System;

class Ex01
{
    static void Main(string[] args)
    {
        // Pergunta o tamanho do vetor
        Console.Write("Digite a quantidade de elementos (N): ");
        int N = int.Parse(Console.ReadLine()!);

        // Cria o vetor
        int[] vetor = new int[N];

        // Preenche o vetor com valores digitados pelo usuário
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Digite o valor da posição {i}: ");
            vetor[i] = int.Parse(Console.ReadLine()!);
        }

        // Chama a função que calcula a soma
        int resultado = SomaVetor(vetor);

        // Mostra o resultado
        Console.WriteLine($"\nA soma dos elementos do vetor é: {resultado}");
    }

    // Função que recebe um vetor e retorna a soma dos elementos
    static int SomaVetor(int[] vetor)
    {
        int soma = 0;
        for (int i = 0; i < vetor.Length; i++)
        {
            soma += vetor[i];
        }
        return soma;
    }
}


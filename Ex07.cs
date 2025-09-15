using System;

class Ex07
{
    // Função que conta quantas vezes X aparece na matriz
    static int ContarOcorrencias(int[,] matriz, int x)
    {
        int contador = 0;
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] == x)
                {
                    contador++;
                }
            }
        }
        return contador;
    }

    static void Main()
    {
        int[,] matriz = {
            { 5, 2, 8 },
            { 7, 2, 9 },
            { 4, 2, 1 }
        };

        Console.Write("Digite o valor X para contar: ");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine($"O valor {x} aparece {ContarOcorrencias(matriz, x)} vezes na matriz.");
    }
}

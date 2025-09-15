using System;

class Ex05
{
    // Função que retorna o menor valor da matriz
    static int MenorValor(int[,] matriz)
    {
        int menor = matriz[0, 0];
        for (int i = 0; i < matriz.GetLength(0); i++) // linhas
        {
            for (int j = 0; j < matriz.GetLength(1); j++) // colunas
            {
                if (matriz[i, j] < menor)
                {
                    menor = matriz[i, j];
                }
            }
        }
        return menor;
    }

    static void Main()
    {
        int[,] matriz = {
            { 5, 2, 8 },
            { 7, 2, 9 },
            { 4, 2, 1 }
        };

        Console.WriteLine("Menor valor da matriz: " + MenorValor(matriz));
    }
}

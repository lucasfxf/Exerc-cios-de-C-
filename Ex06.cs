using System;

class Ex06
{
    // Função que retorna o maior valor da matriz
    static int MaiorValor(int[,] matriz)
    {
        int maior = matriz[0, 0];
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] > maior)
                {
                    maior = matriz[i, j];
                }
            }
        }
        return maior;
    }

    static void Main()
    {
        int[,] matriz = {
            { 5, 2, 8 },
            { 7, 2, 9 },
            { 4, 2, 1 }
        };

        Console.WriteLine("Maior valor da matriz: " + MaiorValor(matriz));
    }
}

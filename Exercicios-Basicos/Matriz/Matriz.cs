using System;
using MinhaBiblioteca;

class Ex08Matriz
{
    static int contarRaiosMesmoLocal(int[,] matriz)
    {
        int cont = 0;
        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matriz[i, j] > 1)
                {
                    cont++;
                }
            }
        }

        return cont;
    }

    static void Main()
    {
        int x, y, quantidadeRaios;
        int linhas, cols;

        Console.WriteLine("Quantidade de linhas e colunas da area:");
        linhas = int.Parse(Console.ReadLine());
        cols = int.Parse(Console.ReadLine());

        int[,] mapa = new int[linhas, cols];

        Console.Write("Quantos raios foram anotados: ");
        quantidadeRaios = int.Parse(Console.ReadLine());

        for (int i = 0; i < quantidadeRaios; i++)
        {
            Console.WriteLine($"Coordenadas do raio {i + 1}:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x >= 0 && x < linhas && y >= 0 && y < cols)
            {
                mapa[x, y]++;
            }
            else
            {
                Console.WriteLine("Coordenadas fora da área! Tente novamente.");
                i--; // repete esta iteração
            }
        }

        Biblioteca.mostrarMatriz(mapa);

        int repetidos = contarRaiosMesmoLocal(mapa);
        Console.WriteLine($"Quantidade de posições com mais de um raio: {repetidos}");
    }
}

using System;
using MinhaBiblioteca;

namespace MatrizDesmatamento
{
    class Program
    {
        static void Main()
        {
            // Define o tamanho da matriz (ex: 5x5)
            int linhas = 5, colunas = 5;
            int[,] matrizAntiga = new int[linhas, colunas];
            int[,] matrizAtual = new int[linhas, colunas];

            Console.WriteLine("=== MATRIZ DE DESMATAMENTO ===");
            Console.WriteLine("1 - Ler matrizes manualmente");
            Console.WriteLine("2 - Carregar de arquivo (dados.txt)");
            Console.WriteLine("3 - Gerar aleatoriamente");
            Console.Write("Escolha uma opção: ");
            int opc = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // --- Entrada das matrizes ---
            if (opc == 1)
            {
                Console.WriteLine("Área 06 meses atrás:");
                Biblioteca.lerMatriz(matrizAntiga);
                Console.WriteLine("Área atual:");
                Biblioteca.lerMatriz(matrizAtual);
            }
            else if (opc == 2)
            {
                Console.WriteLine("Carregando matriz 06 meses atrás...");
                Biblioteca.carregarArquivo(matrizAntiga);
                Console.WriteLine("Carregando matriz atual...");
                Biblioteca.carregarArquivo(matrizAtual);
            }
            else
            {
                // gera aleatoriamente valores 0 e 1
                Random rand = new Random();
                for (int i = 0; i < linhas; i++)
                    for (int j = 0; j < colunas; j++)
                    {
                        matrizAntiga[i, j] = rand.Next(2); // 0 ou 1
                        matrizAtual[i, j] = rand.Next(2);
                    }
            }

            // --- Mostra as matrizes ---
            Console.WriteLine("\nÁrea 06 meses atrás:");
            Biblioteca.mostrarMatriz(matrizAntiga);
            Console.WriteLine("\nÁrea atual:");
            Biblioteca.mostrarMatriz(matrizAtual);

            // --- Processamento ---
            int total = linhas * colunas;
            int contAntiga = contarVegetacao(matrizAntiga);
            int contAtual = contarVegetacao(matrizAtual);

            double percAntiga = (contAntiga / (double)total) * 100;
            double percAtual = (contAtual / (double)total) * 100;
            double variacao = percAtual - percAntiga;

            // --- Saída ---
            Console.WriteLine($"\nTamanho da área analisada: {linhas} x {colunas}");
            Console.WriteLine($"Cobertura 06 meses atrás: {contAntiga} células ({percAntiga:F2}%)");
            Console.WriteLine($"Cobertura atual:           {contAtual} células ({percAtual:F2}%)");

            if (variacao > 0)
                Console.WriteLine($"\nHouve um AUMENTO de {variacao:F2}% na cobertura vegetal.");
            else if (variacao < 0)
                Console.WriteLine($"\nHouve uma REDUÇÃO de {-variacao:F2}% na cobertura vegetal.");
            else
                Console.WriteLine("\nNão houve alteração na cobertura vegetal.");
        }

        // --- Função auxiliar para contar os 1s ---
        static int contarVegetacao(int[,] matriz)
        {
            int cont = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
                for (int j = 0; j < matriz.GetLength(1); j++)
                    if (matriz[i, j] == 1)
                        cont++;
            return cont;
        }
    }
}

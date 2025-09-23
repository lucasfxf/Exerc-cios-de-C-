using System;

class Ex8
{
    static void Main()
    {
        Console.Write("Digite o tamanho do vetor: ");
        int n = int.Parse(Console.ReadLine());

        int[] vetor = new int[n];
        Random rnd = new Random();

        for (int i = 0; i < n; i++)
            vetor[i] = rnd.Next(1, 11);

        Console.WriteLine("Vetor: " + string.Join(", ", vetor));

        Console.Write("Digite o valor a procurar: ");
        int valor = int.Parse(Console.ReadLine());

        int cont = 0;
        for (int i = 0; i < n; i++)
        {
            if (vetor[i] == valor)
                cont++;
        }

        Console.WriteLine($"O valor {valor} aparece {cont} vezes no vetor.");
    }
}

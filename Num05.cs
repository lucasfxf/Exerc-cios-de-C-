using System;

class Matriz02
{
    static void Main()
    {
        Console.WriteLine("Digite a sequência de DNA (A, T, C, G) com até 50 bases:");
        string dna = Console.ReadLine().ToUpper();

        char[] dnaArray = dna.ToCharArray();
        char[] complementar = new char[dnaArray.Length];

        for (int i = 0; i < dnaArray.Length; i++)
        {
            switch (dnaArray[i])
            {
                case 'A': complementar[i] = 'T'; break;
                case 'T': complementar[i] = 'A'; break;
                case 'C': complementar[i] = 'G'; break;
                case 'G': complementar[i] = 'C'; break;
                default: complementar[i] = '?'; break;
            }
        }

        Console.WriteLine("Fita DNA: " + dna);
        Console.WriteLine("Fita complementar: " + new string(complementar));
    }
}

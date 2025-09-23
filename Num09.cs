using System;

class Ex9
{
    static void Main()
    {
        Console.Write("Digite uma palavra ou frase: ");
        char[] vetor = Console.ReadLine().ToCharArray();

        Console.WriteLine("Tamanho do vetor: " + vetor.Length);

        Console.Write("Ordem inversa: ");
        Array.Reverse(vetor);
        Console.WriteLine(new string(vetor));
    }
}

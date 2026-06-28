
using System;

class Ex01
{
    static void Main()
    {
        int a, b, soma;
        Console.WriteLine("valores: ");
        a = int.Parse(Console.ReadLine()!);
        b = int.Parse(Console.ReadLine()!);

        soma = a + b;
        Console.WriteLine("x = " + soma);
    }
}

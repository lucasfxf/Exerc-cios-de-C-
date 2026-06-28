using System;

struct Alunos
{
    public string Nome;
    public float Nota01;
    public float Nota02;

    public float media()
    {
        return (Nota01 + Nota02) / 2;
    }
}

class test05
{
    static void Main()
    {
        Alunos[] alunos = new Alunos[3];

        for (int i = 0; i < alunos.Length; i++)
        {
            Console.WriteLine($"\n=== Aluno {i + 1} ===");

            Console.Write("Nome: ");
            alunos[i].Nome = Console.ReadLine();

            Console.Write("Nota01: ");
            alunos[i].Nota01 = float.Parse(Console.ReadLine());

            Console.Write("Nota02: ");
            alunos[i].Nota02 = float.Parse(Console.ReadLine());
        }

        Console.WriteLine("\n*** Resultado ***");
        for(int i = 0; i < alunos.Length; i++)
        {
            Console.WriteLine($"Media Dos Alunos: {alunos[i].media()}");
        }
    }
}
using System;

struct Aluno
{
    public string Nome;
    public float Nota01;
    public float Nota02;

    // Função média
    public float Media()
    {
        return (Nota01 + Nota02) / 2;
    }
}

class Test02
{
    static void Main()
    {
        // Declarando o vetor de alunos
        Aluno[] alunos = new Aluno[3];

        // Inserindo dados
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

        // Saída de dados com foreach
        Console.WriteLine("\n=== Resultados ===");

        foreach (Aluno a in alunos)
        {
            float media = a.Media();
            string situacao = (media >= 7) ? "Aprovado" : "Reprovado";

            Console.WriteLine($"{a.Nome} - Média: {media} - {situacao}");
        }
    }
}

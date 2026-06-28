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

class test04
{
    static void Main()
    {
        List<Alunos> alunos = new List<Alunos>();
        string control = "s";

        while (control == "s" || control == "S")
        {

            Alunos al = new Alunos();

            Console.WriteLine($"\n*** Aluno ***");

            Console.Write("Nome: ");
            al.Nome = Console.ReadLine();

            Console.Write("Nota01: ");
            al.Nota01 = float.Parse(Console.ReadLine());

            Console.Write("Nota02: ");
            al.Nota02 = float.Parse(Console.ReadLine());

            alunos.Add(al);

            Console.Write("\nDeseja cadastrar outro aluno? (s/n): ");
            control = Console.ReadLine();
        }
        
        Console.WriteLine("\nResultados: ");
        foreach(Alunos a in alunos){
            float media = a.media();
            
            if(media >= 6){
                Console.WriteLine($"\n{a.Nome} com Média!");
            } else {
                Console.WriteLine($"\n{a.Nome} sem Média");
            }
            Console.WriteLine($"Média: {a.media()}");
        }
    }
}
using suporte;

    class Funcoes
    {
        static void Main()
        {
            int a, b, soma;

            Console.WriteLine("Digite o valor de a: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de b: ");
            b = int.Parse(Console.ReadLine());

            soma = Biblioteca.FuncSomar(a, b); // chamada correta da função

            Console.WriteLine("O resultado é: " + soma);
        }

    }

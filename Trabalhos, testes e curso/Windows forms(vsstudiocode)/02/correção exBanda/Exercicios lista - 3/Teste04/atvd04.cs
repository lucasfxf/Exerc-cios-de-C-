using System;
using System.Collections.Generic;

namespace Jogos
{
    class Program
    {
        static int menu()
        {
            Console.WriteLine("***** Menu Jogos *****");
            Console.WriteLine("1 - Cadastrar jogo");
            Console.WriteLine("2 - Buscar por título");
            Console.WriteLine("3 - Listar jogos por console");
            Console.WriteLine("4 - Realizar empréstimo");
            Console.WriteLine("5 - Devolver jogo");
            Console.WriteLine("6 - Mostrar jogos emprestados");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            return int.Parse(Console.ReadLine()!);
        }

        static void cadastrar(List<Jogo> lista)
        {
            Jogo j = new Jogo();

            Console.Write("Título: ");
            j.Titulo = Console.ReadLine()!;

            Console.Write("Console: ");
            j.Console = Console.ReadLine()!;

            Console.Write("Ano: ");
            j.Ano = int.Parse(Console.ReadLine()!);

            Console.Write("Ranking: ");
            j.Ranking = int.Parse(Console.ReadLine()!);

            j.InfoEmprestimo.Emprestado = 'N';
            j.InfoEmprestimo.Data = "";
            j.InfoEmprestimo.NomePessoa = "";

            lista.Add(j);
            Console.WriteLine("Jogo cadastrado com sucesso!");
        }

        static int buscarIndiceTitulo(List<Jogo> lista, string titulo)
        {
            for (int i = 0; i < lista.Count; i++)
                if (lista[i].Titulo.ToUpper() == titulo.ToUpper())
                    return i;
            return -1;
        }

        static void buscarTitulo(List<Jogo> lista)
        {
            Console.Write("Digite o título para buscar: ");
            string titulo = Console.ReadLine()!;
            int pos = buscarIndiceTitulo(lista, titulo);

            if (pos == -1)
                Console.WriteLine("Jogo não encontrado!");
            else
                mostrarJogo(lista[pos]);
        }

        static void mostrarJogo(Jogo j)
        {
            Console.WriteLine("\n--- Informações do Jogo ---");
            Console.WriteLine($"Título: {j.Titulo}");
            Console.WriteLine($"Console: {j.Console}");
            Console.WriteLine($"Ano: {j.Ano}");
            Console.WriteLine($"Ranking: {j.Ranking}");
            Console.WriteLine($"Emprestado: {j.InfoEmprestimo.Emprestado}");
            if (j.InfoEmprestimo.Emprestado == 'S')
            {
                Console.WriteLine($"Pessoa: {j.InfoEmprestimo.NomePessoa}");
                Console.WriteLine($"Data: {j.InfoEmprestimo.Data}");
            }
        }

        static void listarPorConsole(List<Jogo> lista)
        {
            Console.Write("Informe o console: ");
            string c = Console.ReadLine()!;
            bool achou = false;

            foreach (Jogo j in lista)
            {
                if (j.Console.ToUpper() == c.ToUpper())
                {
                    mostrarJogo(j);
                    achou = true;
                }
            }

            if (!achou)
                Console.WriteLine("Nenhum jogo desse console foi encontrado.");
        }

        static void emprestar(List<Jogo> lista)
        {
            Console.Write("Informe o título do jogo: ");
            string titulo = Console.ReadLine()!;
            int pos = buscarIndiceTitulo(lista, titulo);

            if (pos == -1)
            {
                Console.WriteLine("Jogo não encontrado!");
                return;
            }

            if (lista[pos].InfoEmprestimo.Emprestado == 'S')
            {
                Console.WriteLine("Este jogo já está emprestado!");
                return;
            }

            Emprestimo e = new Emprestimo();
            e.Emprestado = 'S';
            e.Data = DateTime.Now.ToString("dd/MM/yyyy");
            Console.Write("Nome da pessoa: ");
            e.NomePessoa = Console.ReadLine()!;

            Jogo temp = lista[pos];
            temp.InfoEmprestimo = e;
            lista[pos] = temp;

            Console.WriteLine("Empréstimo registrado!");
        }

        static void devolver(List<Jogo> lista)
        {
            Console.Write("Informe o título do jogo: ");
            string titulo = Console.ReadLine()!;
            int pos = buscarIndiceTitulo(lista, titulo);

            if (pos == -1)
            {
                Console.WriteLine("Jogo não encontrado!");
                return;
            }

            if (lista[pos].InfoEmprestimo.Emprestado == 'N')
            {
                Console.WriteLine("Este jogo não está emprestado.");
                return;
            }

            Emprestimo novo = new Emprestimo();
            novo.Emprestado = 'N';
            novo.Data = "";
            novo.NomePessoa = "";

            Jogo temp = lista[pos];
            temp.InfoEmprestimo = novo;
            lista[pos] = temp;

            Console.WriteLine("Jogo devolvido com sucesso!");
        }

        static void mostrarEmprestados(List<Jogo> lista)
        {
            bool achou = false;

            foreach (Jogo j in lista)
            {
                if (j.InfoEmprestimo.Emprestado == 'S')
                {
                    mostrarJogo(j);
                    achou = true;
                }
            }

            if (!achou)
                Console.WriteLine("Nenhum jogo está emprestado.");
        }

        static void Main()
        {
            List<Jogo> lista = new List<Jogo>();
            int opc;

            do
            {
                opc = menu();
                Console.Clear();

                switch (opc)
                {
                    case 1: cadastrar(lista); break;
                    case 2: buscarTitulo(lista); break;
                    case 3: listarPorConsole(lista); break;
                    case 4: emprestar(lista); break;
                    case 5: devolver(lista); break;
                    case 6: mostrarEmprestados(lista); break;
                    case 0: Console.WriteLine("Saindo..."); break;
                    default: Console.WriteLine("Opção inválida."); break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

            } while (opc != 0);
        }
    }
}

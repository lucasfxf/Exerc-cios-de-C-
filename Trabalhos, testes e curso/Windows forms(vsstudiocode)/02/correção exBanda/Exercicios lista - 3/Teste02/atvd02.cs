using System;
using System.Collections.Generic;
using System.IO;

namespace Biblioteca
{
    class atvd02
    {
        static int menu()
        {
            Console.WriteLine("*** Sistema Library ***");
            Console.WriteLine("1 - Cadastrar Livros");
            Console.WriteLine("2 - Procurar Livros por Título");
            Console.WriteLine("3 - Mostrar Dados dos Livros");
            Console.WriteLine("4 - Ler um ano e apresentar Livros mais novos");
            Console.WriteLine("0 -  Sair e salvar");
            Console.Write("Escolha: ");
            return int.Parse(Console.ReadLine()!);
        }

        static void addLivros(List<Livraria> listaLivraria)
        {
            Livraria novoLivro = new Livraria();

            Console.Write("Título: ");
            novoLivro.Titulo = Console.ReadLine()!;

            Console.Write("Autor: ");
            novoLivro.Autor = Console.ReadLine()!;

            Console.Write("Ano: ");
            novoLivro.Ano = int.Parse(Console.ReadLine()!);

            Console.Write("Prateleira: ");
            novoLivro.Prateleira = int.Parse(Console.ReadLine()!);

            listaLivraria.Add(novoLivro);
            Console.WriteLine("Livro cadastrado com sucesso!");
        }

        static void procurarPorTitulo(List<Livraria> listaLivraria)
        {
            Console.Write("Digite o título que deseja buscar: ");
            string tituloBusca = Console.ReadLine()!;
            bool encontrado = false;

            foreach (Livraria l in listaLivraria)
            {
                if (l.Titulo.ToUpper().Contains(tituloBusca.ToUpper()))
                {
                    Console.WriteLine($"\nLivro encontrado!");
                    Console.WriteLine($"Título: {l.Titulo}");
                    Console.WriteLine($"Autor: {l.Autor}");
                    Console.WriteLine($"Prateleira: {l.Prateleira}");
                    encontrado = true;
                }
            }

            if (!encontrado)
                Console.WriteLine("Nenhum livro encontrado com esse título.");
        }

        static void mostrarLivros(List<Livraria> listaLivraria)
        {
            if (listaLivraria.Count == 0)
            {
                Console.WriteLine("Nenhum livro cadastrado.");
                return;
            }

            for (int i = 0; i < listaLivraria.Count; i++)
            {
                Console.WriteLine($"\n--- Livro {i + 1} ---");
                Console.WriteLine($"Título: {listaLivraria[i].Titulo}");
                Console.WriteLine($"Autor: {listaLivraria[i].Autor}");
                Console.WriteLine($"Ano: {listaLivraria[i].Ano}");
                Console.WriteLine($"Prateleira: {listaLivraria[i].Prateleira}");
            }
        }

        static void livrosMaisNovos(List<Livraria> listaLivraria)
        {
            Console.Write("Digite um ano: ");
            int anoBusca = int.Parse(Console.ReadLine()!);
            bool encontrado = false;

            foreach (Livraria l in listaLivraria)
            {
                if (l.Ano > anoBusca)
                {
                    Console.WriteLine($"\n--- Livro Encontrado ---");
                    Console.WriteLine($"Título: {l.Titulo}");
                    Console.WriteLine($"Ano: {l.Ano}");
                    encontrado = true;
                }
            }

            if (!encontrado)
                Console.WriteLine("Nenhum livro mais novo do que o ano informado foi encontrado.");
        }

        static void salvarDados(List<Livraria> lista, string nomeArquivo)
        {
            using (StreamWriter writer = new StreamWriter(nomeArquivo))
            {
                foreach (Livraria l in lista)
                    writer.WriteLine($"{l.Titulo};{l.Autor};{l.Ano};{l.Prateleira}");
            }
        }

        static void carregarDados(List<Livraria> lista, string nomeArquivo)
        {
            if (!File.Exists(nomeArquivo))
                return;

            string[] linhas = File.ReadAllLines(nomeArquivo);

            foreach (string linha in linhas)
            {
                string[] dados = linha.Split(';');
                Livraria livro = new Livraria();
                livro.Titulo = dados[0];
                livro.Autor = dados[1];
                livro.Ano = int.Parse(dados[2]);
                livro.Prateleira = int.Parse(dados[3]);
                lista.Add(livro);
            }
        }

        static void Main()
        {
            List<Livraria> listaLivraria = new List<Livraria>();
            string nomeArquivo = "Livros.txt";
            carregarDados(listaLivraria, nomeArquivo);

            int opcao;
            do
            {
                opcao = menu();
                Console.Clear();

                switch (opcao)
                {
                    case 1: addLivros(listaLivraria); break;
                    case 2: procurarPorTitulo(listaLivraria); break;
                    case 3: mostrarLivros(listaLivraria); break;
                    case 4: livrosMaisNovos(listaLivraria); break;
                    case 0:
                        salvarDados(listaLivraria, nomeArquivo);
                        Console.WriteLine("Dados salvos! Encerrando programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

            } while (opcao != 0);
        }
    }
}

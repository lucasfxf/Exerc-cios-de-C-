using System;

namespace BandasMusicais
{
    class atvd01
    {
        static void addBanda(List<Bandas> listaBandas)
        {
            Bandas novaBanda = new Bandas();

            Console.Write("Nome: ");
            novaBanda.Nome = Console.ReadLine()!;

            Console.Write("Gênero: ");
            novaBanda.Genero = Console.ReadLine()!;

            Console.Write("Integrantes: ");
            novaBanda.Integrantes = int.Parse(Console.ReadLine()!);

            Console.Write("Ranking: ");
            novaBanda.Ranking = int.Parse(Console.ReadLine()!);

            listaBandas.Add(novaBanda);
            Console.WriteLine("-------------");
        }


        static void mostrarBandas(List<Bandas> listaBandas)
        {
            int posicao = 1;
            for (int i = 0; i < listaBandas.Count; i++)
            {
                Console.WriteLine($"*** Banda {posicao} ***");
                Console.WriteLine($"Dados: {listaBandas[i].Nome} - {listaBandas[i].Genero} - {listaBandas[i].Integrantes} - {listaBandas[i].Ranking}");
                posicao++;
            }
        }

        static int menu()
        {
            int opcao;
            Console.WriteLine("*** Sistema de Cadastro de Bandas ***");
            Console.WriteLine("1- Adicionar Banda");
            Console.WriteLine("2- Mostrar Bandas");
            Console.WriteLine("3- Buscar Banda");
            Console.WriteLine("4- Atualizar Banda");
            Console.WriteLine("5- Remover Banda");
            Console.WriteLine("0- Sair do Sistema");
            opcao = int.Parse(Console.ReadLine()!);
            return opcao;
        }

        static void salvarDados(List<Bandas> listaBandas, string nomeArquivo)
        {
            using (StreamWriter writer = new StreamWriter(nomeArquivo))
            {
                foreach (Bandas b in listaBandas)
                {
                    writer.WriteLine($"{b.Nome}, {b.Genero}, {b.Integrantes}, {b.Ranking}");
                }
            }
            Console.WriteLine("Dados salvos com sucesso :)");
        }

        static void buscarPorRanking(List<Bandas> listaBandas, int RankingBusca)
        {
            bool encontrado = false;

            foreach (Bandas b in listaBandas)
            {
                if (b.Ranking == RankingBusca)
                {
                    Console.WriteLine("\n--- Banda encontrada ---");
                    Console.WriteLine($"Nome: {b.Nome}");
                    Console.WriteLine($"Gênero: {b.Genero}");
                    Console.WriteLine($"Integrantes: {b.Integrantes}");
                    Console.WriteLine($"Ranking: {b.Ranking}");
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Nenhuma banda com esse ranking foi encontrada.");
            }
        }

        static void Main()
        {
            List<Bandas> listaBandas = new List<Bandas>();
            int opcao = 0;

            do
            {
                opcao = menu();
                switch (opcao)
                {
                    case 1:
                        addBanda(listaBandas);
                        break;

                    case 2:
                        mostrarBandas(listaBandas);
                        break;

                    case 3:
                        Console.Write("Digite o ranking que deseja buscar: ");
                        int r = int.Parse(Console.ReadLine()!);
                        buscarPorRanking(listaBandas, r);
                        break;

                    case 4:
                        // ainda vazio
                        break;

                    case 5:
                        // vazio também
                        break;

                    case 0:
                        salvarDados(listaBandas, "Bandas.txt");
                        Console.WriteLine("Até Mais :) ");
                        break;
                }

                Console.ReadKey();
                Console.Clear();

            } while (opcao != 0);
        }
    }
}

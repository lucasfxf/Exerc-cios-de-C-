using System;
using System.Collections.Generic;
using System.IO;

namespace Energia
{
    class atvd03
    {
        static int menu()
        {
            Console.WriteLine("*** Sistema de Consumo de Energia ***");
            Console.WriteLine("1 - Cadastrar eletrodoméstico");
            Console.WriteLine("2 - Listar eletrodomésticos");
            Console.WriteLine("3 - Buscar por nome");
            Console.WriteLine("4 - Buscar por eletro que gasta mais que X");
            Console.WriteLine("5 - Calcular consumo diário/mensal da casa");
            Console.WriteLine("6 - Carregar dados do arquivo");
            Console.WriteLine("0 - Salvar e sair");
            Console.Write("Escolha: ");
            return int.Parse(Console.ReadLine()!);
        }

        static void addEletro(List<Eletro> lista)
        {
            Eletro novo = new Eletro();

            Console.Write("Nome: ");
            novo.Nome = Console.ReadLine()!;

            Console.Write("Potência (kW): ");
            novo.Potencia = double.Parse(Console.ReadLine()!);

            Console.Write("Tempo ativo por dia (horas): ");
            novo.TempoAtivo = double.Parse(Console.ReadLine()!);

            lista.Add(novo);
            Console.WriteLine("Eletrodoméstico cadastrado!");
        }

        static void mostrarEletros(List<Eletro> lista)
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum eletrodoméstico cadastrado.");
                return;
            }

            foreach (Eletro e in lista)
            {
                Console.WriteLine("\n--- Eletrodoméstico ---");
                Console.WriteLine($"Nome: {e.Nome}");
                Console.WriteLine($"Potência: {e.Potencia} kW");
                Console.WriteLine($"Tempo ativo: {e.TempoAtivo} h/dia");
            }
        }

        static void salvarDados(List<Eletro> lista, string nomeArquivo)
        {
            using (StreamWriter writer = new StreamWriter(nomeArquivo))
            {
                foreach (Eletro e in lista)
                    writer.WriteLine($"{e.Nome};{e.Potencia};{e.TempoAtivo}");
            }
            Console.WriteLine("Dados salvos!");
        }

        static void carregarDados(List<Eletro> lista, string nomeArquivo)
        {
            if (!File.Exists(nomeArquivo))
            {
                Console.WriteLine("Nenhum arquivo encontrado.");
                return;
            }

            string[] linhas = File.ReadAllLines(nomeArquivo);

            foreach (string linha in linhas)
            {
                string[] dados = linha.Split(';');
                Eletro e = new Eletro();
                e.Nome = dados[0];
                e.Potencia = double.Parse(dados[1]);
                e.TempoAtivo = double.Parse(dados[2]);
                lista.Add(e);
            }

            Console.WriteLine("Dados carregados com sucesso!");
        }

        static void buscarPorNome(List<Eletro> lista)
        {
            Console.Write("Digite o nome para buscar: ");
            string busca = Console.ReadLine()!;
            bool achou = false;

            foreach (Eletro e in lista)
            {
                if (e.Nome.ToUpper().Contains(busca.ToUpper()))
                {
                    Console.WriteLine("\n--- Encontrado ---");
                    Console.WriteLine($"Nome: {e.Nome}");
                    Console.WriteLine($"Potência: {e.Potencia} kW");
                    Console.WriteLine($"Tempo ativo: {e.TempoAtivo} h/dia");
                    achou = true;
                }
            }

            if (!achou)
                Console.WriteLine("Nenhum eletrodoméstico encontrado com esse nome.");
        }

        static void buscarPorConsumo(List<Eletro> lista)
        {
            Console.Write("Valor mínimo de consumo diário (kWh): ");
            double valorX = double.Parse(Console.ReadLine()!);
            bool achou = false;

            foreach (Eletro e in lista)
            {
                double consumoDiario = e.Potencia * e.TempoAtivo;

                if (consumoDiario > valorX)
                {
                    Console.WriteLine($"\n--- Eletrodoméstico encontrado ---");
                    Console.WriteLine($"Nome: {e.Nome}");
                    Console.WriteLine($"Consumo diário: {consumoDiario} kWh");
                    achou = true;
                }
            }

            if (!achou)
                Console.WriteLine("Nenhum eletrodoméstico ultrapassa esse consumo.");
        }

        static void consumoCasa(List<Eletro> lista)
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum eletrodoméstico cadastrado.");
                return;
            }

            Console.Write("Digite o valor do kW/h em R$: ");
            double precoKWh = double.Parse(Console.ReadLine()!);

            double consumoDiarioTotal = 0;

            foreach (Eletro e in lista)
                consumoDiarioTotal += e.Potencia * e.TempoAtivo;

            double consumoMensalTotal = consumoDiarioTotal * 30;
            double custoMensal = consumoMensalTotal * precoKWh;

            Console.WriteLine("\n--- Consumo da Casa ---");
            Console.WriteLine($"Consumo diário: {consumoDiarioTotal:F2} kWh");
            Console.WriteLine($"Consumo mensal: {consumoMensalTotal:F2} kWh");
            Console.WriteLine($"Custo mensal estimado: R$ {custoMensal:F2}");
        }

        static void Main()
        {
            List<Eletro> lista = new List<Eletro>();
            string nomeArquivo = "Eletros.txt";
            carregarDados(lista, nomeArquivo);

            int opcao;
            do
            {
                opcao = menu();
                Console.Clear();

                switch (opcao)
                {
                    case 1: addEletro(lista); break;
                    case 2: mostrarEletros(lista); break;
                    case 3: buscarPorNome(lista); break;
                    case 4: buscarPorConsumo(lista); break;
                    case 5: consumoCasa(lista); break;
                    case 6: carregarDados(lista, nomeArquivo); break;
                    case 0:
                        salvarDados(lista, nomeArquivo);
                        Console.WriteLine("Encerrando...");
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

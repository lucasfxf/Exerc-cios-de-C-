using System;

namespace FazendaGado
{
    class atvd05
    {
        static int menu()
        {
            Console.WriteLine("***** Sistema da Fazenda *****");
            Console.WriteLine("1 - Cadastrar Gado");
            Console.WriteLine("2 - Total de leite semanal");
            Console.WriteLine("3 - Total de alimento semanal");
            Console.WriteLine("4 - Listar animais para abate");
            Console.WriteLine("5 - Salvar dados");
            Console.WriteLine("6 - Carregar dados");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha: ");
            return int.Parse(Console.ReadLine()!);
        }

        static void cadastrar(List<Gado> lista)
        {
            Gado g = new Gado();
            Console.Write("Código: ");
            g.Codigo = int.Parse(Console.ReadLine()!);

            Console.Write("Litros de leite/semana: ");
            g.LeiteSemanal = double.Parse(Console.ReadLine()!);

            Console.Write("Alimento ingerido/semana (kg): ");
            g.AlimentoSemanal = double.Parse(Console.ReadLine()!);

            Console.Write("Mês de nascimento: ");
            g.Nasc.Mes = int.Parse(Console.ReadLine()!);

            Console.Write("Ano de nascimento: ");
            g.Nasc.Ano = int.Parse(Console.ReadLine()!);

            g.Abate = calcularAbate(g);

            lista.Add(g);
            Console.WriteLine("Registro cadastrado com sucesso!");
        }

        static char calcularAbate(Gado g)
        {
            int anoAtual = DateTime.Now.Year;
            int idade = anoAtual - g.Nasc.Ano;

            if (idade > 5 || g.LeiteSemanal < 40)
                return 'S';
            return 'N';
        }

        static void totalLeite(List<Gado> lista)
        {
            double soma = 0;
            foreach (Gado g in lista)
                soma += g.LeiteSemanal;

            Console.WriteLine($"\nTotal de leite semanal da fazenda: {soma} litros");
        }

        static void totalAlimento(List<Gado> lista)
        {
            double soma = 0;
            foreach (Gado g in lista)
                soma += g.AlimentoSemanal;

            Console.WriteLine($"\nTotal de alimento semanal consumido: {soma} kg");
        }

        static void listarAbate(List<Gado> lista)
        {
            bool tem = false;
            Console.WriteLine("\n--- Lista de animais para ABATE ---");

            foreach (Gado g in lista)
            {
                if (g.Abate == 'S')
                {
                    Console.WriteLine($"Código: {g.Codigo} | Idade: {DateTime.Now.Year - g.Nasc.Ano} anos | Leite: {g.LeiteSemanal}L");
                    tem = true;
                }
            }

            if (!tem)
                Console.WriteLine("Nenhum animal está marcado para abate.");
        }

        static void salvar(List<Gado> lista, string nomeArquivo)
        {
            using (StreamWriter writer = new StreamWriter(nomeArquivo))
            {
                foreach (Gado g in lista)
                {
                    writer.WriteLine($"{g.Codigo};{g.LeiteSemanal};{g.AlimentoSemanal};{g.Nasc.Mes};{g.Nasc.Ano};{g.Abate}");
                }
            }
            Console.WriteLine("Dados salvos com sucesso!");
        }

        static void carregar(List<Gado> lista, string nomeArquivo)
        {
            if (!File.Exists(nomeArquivo))
            {
                Console.WriteLine("Arquivo não encontrado!");
                return;
            }

            lista.Clear();
            string[] linhas = File.ReadAllLines(nomeArquivo);

            foreach (string linha in linhas)
            {
                string[] p = linha.Split(';');
                Gado g = new Gado();
                g.Codigo = int.Parse(p[0]);
                g.LeiteSemanal = double.Parse(p[1]);
                g.AlimentoSemanal = double.Parse(p[2]);
                g.Nasc.Mes = int.Parse(p[3]);
                g.Nasc.Ano = int.Parse(p[4]);
                g.Abate = char.Parse(p[5]);

                lista.Add(g);
            }

            Console.WriteLine("Dados carregados com sucesso!");
        }

        static void Main()
        {
            List<Gado> lista = new List<Gado>();
            int opc = 0;

            do
            {
                opc = menu();
                Console.Clear();

                switch (opc)
                {
                    case 1: cadastrar(lista); break;
                    case 2: totalLeite(lista); break;
                    case 3: totalAlimento(lista); break;
                    case 4: listarAbate(lista); break;
                    case 5: salvar(lista, "Fazenda.txt"); break;
                    case 6: carregar(lista, "Fazenda.txt"); break;
                    case 0: Console.WriteLine("Encerrando o sistema..."); break;
                    default: Console.WriteLine("Opção inválida!"); break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

            } while (opc != 0);
        }
    }
}

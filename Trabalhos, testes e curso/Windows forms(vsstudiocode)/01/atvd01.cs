using System;
namespace BandasMusicais
{

class atvd01
{
    static void addBanda(List<Bandas> listaBandas)
    {
        Bandas novaBanda = new Bandas();

        Console.Write("Nome: ");
        novaBanda.Nome = Console.ReadLine();

        Console.Write("Gênero: ");
        novaBanda.Genero = Console.ReadLine();

        Console.Write("Integrantes: ");
        novaBanda.Integrantes = int.Parse(Console.ReadLine());

        Console.Write("Ranking: ");
        novaBanda.Ranking = int.Parse(Console.ReadLine());

        listaBandas.Add(novaBanda);
        Console.WriteLine("-------------");
    }

    static void mostrarBandas(List<Bandas> listaBandas)
        {
            
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
            opcao = int.Parse(Console.ReadLine());
            return opcao;
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

                    break;

                    case 3:

                    break;

                    case 4:

                    break;

                    case 0:
                    
                    Console.WriteLine("Até Mais :) ");
                }

                Console.ReadKey();// pausa
                Console.Clear(); // limpa a tela

            } while(opcao != 0);
        
         }
    }
}
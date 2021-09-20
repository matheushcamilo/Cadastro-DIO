using System;
using Cadastros.Classes;
using Cadastros.EnumLocal;
namespace Cadastros
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha;
            RepositorioSeries Catalogo = new RepositorioSeries();
            do
            {
                escolha = EscolhaUsuario();
                switch (escolha)
                {
                    case 1:
                        Console.WriteLine(Catalogo.ToString());
                        break;
                    case 2:
                        Series NovaSerie = Cadastro();
                        Catalogo.Inserir(NovaSerie);
                        break;
                    case 3:
                        Console.WriteLine("Escolha a série que deseja alterar:");
                        int id = int.Parse(Console.ReadLine());
                        Series SerieAlterada = Cadastro();
                        Catalogo.Atualizar(id, SerieAlterada);
                        break;
                    case 4:
                        Console.WriteLine("Escolha série para excluir:");
                        int id2 = int.Parse(Console.ReadLine());
                        Catalogo.Excluir(id2);
                        break;
                    case 5:
                        Console.WriteLine("Escolha um identificador:");
                        int id3 = int.Parse(Console.ReadLine());
                        Series SerieRetornada = Catalogo.RetornaPorId(id3);
                        Console.WriteLine(SerieRetornada.toString());
                        break;
                    case 6:
                        Console.WriteLine("Saindo... Até mais!!!");
                        break;

                    default:
                        Console.WriteLine("Escolha inválida!!\nEscolha novamente!");
                        break;

                }
            } while (escolha != 6);
        }

        static int EscolhaUsuario()
        {
            Console.WriteLine("Escolha uma das opções abaixo");
            Console.WriteLine("1 - Mostrar séries Cadastradas;\n2 - Adicionar nova série;\n" +
                "3 - Atualizar cadastro de série;\n4 - Excluir série;\n5 - Procurar série por id;\n" +
                "6 - Sair");

            return int.Parse(Console.ReadLine());
        }
        static Series Cadastro()
        {
            Console.WriteLine("Escolha um gênero");
            foreach (var enumValue in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", (int)enumValue, enumValue);
            }
            int Gen = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o título da série:");
            string Titulo = Console.ReadLine();
            Console.WriteLine("Informe a descrição da série:");
            string Descricao = Console.ReadLine();
            Console.WriteLine("Informe o ano de lançamento da série:");
            int Ano = int.Parse(Console.ReadLine());
            Series ans = new Series((EnumLocal.Genero)Gen, Titulo, Descricao, Ano);
            return ans;
        }
    }
}

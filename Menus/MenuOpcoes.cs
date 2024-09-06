using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuOpcoes : Menu
{
    private Dictionary<int, Menu> opcoes = new();

    private int opecaoEscolhida { get; set; }

    void OpcoesDeMenu()
    {
        opcoes.Add(1, new MenuRegistrarBanda());
        opcoes.Add(2, new MenuRegistrarAlbum());
        opcoes.Add(3, new MenuMostrarBandas());
        opcoes.Add(4, new MenuAvaliarBanda());
        opcoes.Add(5, new MenuAvaliarAlbum());
        opcoes.Add(6, new MenuExibirDetalhes());
        opcoes.Add(-1, new MenuSair());
    }

    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        OpcoesDeMenu();

        while (opecaoEscolhida != -1)
        {
            Console.WriteLine(MensagemDoMenu.Mensagem);

            Console.WriteLine("\nDigite 1 para registrar uma banda");
            Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
            Console.WriteLine("Digite 3 para mostrar todas as bandas");
            Console.WriteLine("Digite 4 para avaliar uma banda");
            Console.WriteLine("Digite 5 para avaliar uma álbum");
            Console.WriteLine("Digite 6 para exibir os detalhes de uma banda");
            Console.WriteLine("Digite -1 para sair\n");

            Console.Write("Digite a sua opção: ");
            opecaoEscolhida = Convert.ToInt32(Console.ReadLine());

            if (opcoes.ContainsKey(opecaoEscolhida))
            {
                Menu menuASerExibido = opcoes[opecaoEscolhida];
                menuASerExibido.Executar(bandasRegistradas);
            }
            else
                Console.WriteLine("Opção inválida");
        }
    }
}
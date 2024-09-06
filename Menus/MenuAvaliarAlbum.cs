using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuAvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirMensagensDasOpcoes("Avaliar álbum");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.Write("Agora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;
            if (banda.Albuns.Any(x => x.Nome.Equals(tituloAlbum)))
            {
                Album album = banda.Albuns.First(x => x.Nome.Equals(tituloAlbum));
                Console.Write($"Qual nota que o álbum {album.Nome} merece: ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                album.AdicionarNota(nota);
                Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para a álbum {album.Nome}");
                Delay(delay: 2000);
            }
            else
                MensagemDeNaoEncontrado<Album>(new Album(string.Empty), tituloAlbum);


        }
        else
            MensagemDeNaoEncontrado<Banda>(new Banda(string.Empty), nomeDaBanda);
    }
}

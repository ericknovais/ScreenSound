using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        Console.Clear();
        ExibirMensagensDasOpcoes("Registro de álbuns");
        Console.Write("Digite a banda cujo álbum deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Console.Write("Agora digite o título do álbum: ");
            Album album = new(nome: Console.ReadLine()!);
            Banda banda = bandasRegistradas[nomeDaBanda];
            banda.AdicionarAlbum(album);
            Console.WriteLine($"O álbum {album.Nome} de {nomeDaBanda} foi registrado com sucesso!");
            Delay(delay: 4000);
        }
        else
            MensagemDeNaoEncontrado<Banda>(new Banda(string.Empty), nomeDaBanda);
    }
}

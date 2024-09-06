
using ScreenSound.Interfaces;

namespace ScreenSound.Modelos;

internal class Banda : IAvaliavel
{
    public List<Album> Albuns = new List<Album>();
    private List<Avaliacao> notas = new List<Avaliacao>();

    public Banda(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }
    public double Media => notas.Count == 0 ? 0 : notas.Average(x => x.Nota);
    public string? Resumo { get; set; }

    public void AdicionarAlbum(Album album)
    {
        Albuns.Add(album);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in Albuns)
        {
            Console.WriteLine($"Álbum {album.Nome} ({album.DuracaoTotal})");
        }
    }

    public static List<Banda> ObterBandas()
    {
        Random random = new Random();

        List<Banda> listaDeBandas = new List<Banda>()
            {
                new Banda(nome: "Ira"),
                new Banda(nome: "The Beatles"),
                new Banda(nome: "Slipknot")
            };

        foreach (var banda in listaDeBandas)
            for (int i = 0; i < random.Next(1, 10); i++)
                banda.AdicionarNota(nota: new Avaliacao(random.Next(1, 10)));

        listaDeBandas[2].AdicionarAlbum(new Album("All Hope Is Gone"));
        listaDeBandas[2].AdicionarAlbum(new Album("Iowa"));
        listaDeBandas[2].AdicionarAlbum(new Album("Slipknot"));

        foreach (Album album in listaDeBandas[2].Albuns) 
        {
            for (int i = 0; i < random.Next(1, 10); i++)
                album.AdicionarNota(nota: new Avaliacao(random.Next(1, 10)));
        }

        return listaDeBandas;
    }
}
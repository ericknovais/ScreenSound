using ScreenSound.Interfaces;

namespace ScreenSound.Modelos;

internal class Album : IAvaliavel
{
    private List<Musica> musicas = new List<Musica>();
    private List<Avaliacao> notas = new List<Avaliacao>();

    public Album(string nome)
    {
        this.Nome = nome;
        ContadorDeObjetos++;
    }

    public string Nome { get; }

    public static int ContadorDeObjetos = 0;

    public int DuracaoTotal => musicas.Sum(musica => musica.Duracao);

    public double Media => notas.Count == 0 ? 0 : notas.Average(x => x.Nota);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicaDoAlbum()
    {
        Console.WriteLine($"Lista de música do album {Nome}:\n");
        foreach (var musica in musicas)
            Console.WriteLine($"Música: {musica.Nome}");
        Console.WriteLine($"\nPara ouvir este album inteiro você precisa de {DuracaoTotal}");

    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }
}
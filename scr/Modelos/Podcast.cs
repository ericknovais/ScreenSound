using System;

namespace ScreenSound.Modelos;

internal class Podcast
{
    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios => Episodios.Count;

    private List<Episodio> Episodios = new List<Episodio>();

    public void AdicionaEpisodios(Episodio episodio)
    {
        Episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"O Podcast: {Nome} apresentado por: {Host}\n");
        Console.WriteLine("Lista de episodios:");
        foreach (Episodio episodio in Episodios.OrderBy(ep => ep.Ordem))
            Console.WriteLine(episodio.Resumo);

        Console.WriteLine($"\n\nEste podcast possui {TotalEpisodios} episodios.");
    }
}
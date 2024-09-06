using ScreenSound.Modelos;

internal class Musica
{
    public Musica(Banda banda, string nome)
    {
        this.Artista = banda;
        this.Nome = nome;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    public string DescricaoResumida => $"A música {Nome} pertence á banda {Artista}";



    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Musica: {Nome} " +
            $"\nArtista: {Artista.Nome}" +
            $"\nDuração: {Duracao}");
        if (Disponivel)
            Console.WriteLine("Disponível no plano");
        else
            Console.WriteLine("Adquira o plano Plus");
    }
}
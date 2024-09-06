namespace ScreenSound.Modelos;

internal class Episodio
{
    public Episodio(int duracao, string titulo, int ordem)
    {
        Duracao = duracao;
        Titulo = titulo;
        Ordem = ordem;
    }

    public int Ordem { get; set; }
    public string Titulo { get; }
    public int Duracao { get; }
    public string Resumo => $"Ordem: {Ordem}. {Titulo} ({Duracao} min) - {string.Join(", ", Convidados)}";

    public List<string> Convidados = new List<string>();

    public void AcidionaConvidado(string convidado)
    {
        Convidados.Add(convidado);
    }
}
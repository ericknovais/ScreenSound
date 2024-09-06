using System;

namespace ScreenSound.Modelos;

internal class Avaliacao
{
    public Avaliacao(int nota)
    {
        this.Nota = nota <= 0 ? 0 : nota >= 10 ? 10 : nota;
    }

    public int Nota { get; }

    public static Avaliacao Parse(string texto)
    {
        return new Avaliacao(int.Parse(texto));
    }
}

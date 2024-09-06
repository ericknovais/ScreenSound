using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal abstract class Menu
{
    public virtual void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
    }

    public void ExibirMensagensDasOpcoes(string titulo)
    {
        string asterisco = string.Empty.PadLeft(titulo.Length + 2, '*');
        Console.WriteLine(asterisco);
        Console.WriteLine($" {titulo}");
        Console.WriteLine($"{asterisco}\n");
    }

    public void MensagemDeNaoEncontrado<T>(T objeto, string valor)
    {
        if (objeto != null)
        {
            Console.WriteLine($"\n{objeto.GetType().Name} {valor} não foi encontrada");
            OpcaoParaVoltarAoMenu();
        }
    }

    public void OpcaoParaVoltarAoMenu() 
    {
        Console.WriteLine("Digite enter para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }

    public void Delay(int delay) 
    {
        Thread.Sleep(delay);
        Console.Clear();
    }
}
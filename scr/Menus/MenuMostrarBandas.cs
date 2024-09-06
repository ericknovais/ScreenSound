using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuMostrarBandas : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirMensagensDasOpcoes("Exibir todas as bandas resgistradas");

        foreach (string banda in bandasRegistradas.Keys)
            Console.WriteLine($"Banda {banda}");

        Console.WriteLine("\nPrecione enter para voltar para o menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
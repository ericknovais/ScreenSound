using ScreenSound.Menus;
using ScreenSound.Modelos;

namespace ScreenSound;

internal class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Banda> bandasRegistradas = new();

        void CargaDeBandas()
        {
            List<Banda> listaDeBandas = Banda.ObterBandas();
            listaDeBandas.ForEach(banda => bandasRegistradas.Add(banda.Nome, banda));
        };

        CargaDeBandas();
        MenuOpcoes menu = new MenuOpcoes();
        menu.Executar(bandasRegistradas);
    }
}
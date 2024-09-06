using ScreenSound.Modelos;
using System;

namespace ScreenSound.Menus;

internal class MenuExibirDetalhes : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirMensagensDasOpcoes("Exibir detalhes da banda");
        Console.Write("Digite o nome da banda que deseja conhecer melhor: ");

        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.WriteLine(banda.Resumo);
            Console.WriteLine($"A média da banda {banda.Nome} é de {banda.Media.ToString("F2")}");
            Console.WriteLine("\nDiscografia:");
            banda.Albuns.ForEach(album =>  Console.WriteLine($"{album.Nome} -> {album.Media.ToString("F2")}"));
            OpcaoParaVoltarAoMenu();
        }
        else
            MensagemDeNaoEncontrado<Banda>(new Banda(string.Empty), nomeDaBanda);
    }
}
using OpenAI_API;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        Console.Clear();
        ExibirMensagensDasOpcoes("Registro de banda");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        Banda banda = new(Console.ReadLine()!);
        Console.WriteLine($"A banda {banda.Nome} foi registrada com sucesso");
        var apiKey = "sk-VgLfGVFEqfxVS8t6MmqdggpWFO_ZryyoxoMQBXhqO_T3BlbkFJJorxdnWx0WemLY4O3gTjnxYqEdxX7sKQA7E1Jliv0A";
        var client = new OpenAIAPI(apiKey);
        var chat = client.Chat.CreateConversation();
        //chat.AppendSystemMessage($"Resuma a banda {banda.Nome} em 1 parágrafo. Adote um estilo informal.");
        //banda.Resumo = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
        
        bandasRegistradas.Add(banda.Nome, banda);
        OpcaoParaVoltarAoMenu();
    }
}
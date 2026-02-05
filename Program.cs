using System;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using System.IO;
using System.Text.Json;

class Program
{
    static async Task Main(string[] args)
    {
        var json = File.ReadAllText("config.json");
        var configJson = JsonSerializer.Deserialize<Config>(json);

        var token = configJson.Token;

        var config = new DiscordConfiguration()
        {
            Token = token,
            TokenType = TokenType.Bot,
            Intents = DiscordIntents.Guilds 
                    | DiscordIntents.GuildMessages 
                    | DiscordIntents.MessageContents
        };

        var client = new DiscordClient(config);

        var commandsConfig = new CommandsNextConfiguration()
        {
            StringPrefixes = new[] { "d!" }
        };

        var commands = client.UseCommandsNext(commandsConfig);

        commands.RegisterCommands<Devilly.Cmd.Commands>();

        client.Ready += async (c, e) =>
        {
            Console.WriteLine("Devil.ly está online 😈");
        };

        await client.ConnectAsync();
        await Task.Delay(-1);
    }
}

using System;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using System.IO;
using System.Text.Json;

class Program
{
    public static Devilly.Svc.StatsService StatsService { get; private set; }
    static async Task Main(string[] args)
    {
        StatsService = new Devilly.Svc.StatsService();
        
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

        var statsService = new Devilly.Svc.StatsService();

        client.MessageCreated += async (c, e) =>
        {
            if (e.Author.IsBot) return;

            statsService.RegisterMessage(
                e.Author.Id,
                e.Channel.Id,
                e.Guild.Id,
                e.Message.CreationTimestamp.UtcDateTime
            );
        };

        client.Ready += async (c, e) =>
        {
            Console.WriteLine("Devil.ly está online 😈");
        };

        await client.ConnectAsync();
        await Task.Delay(-1);

    }
}

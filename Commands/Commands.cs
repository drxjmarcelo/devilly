namespace Devilly.Cmd
{
    using DSharpPlus.CommandsNext;
    using DSharpPlus.CommandsNext.Attributes;
    using System.Threading.Tasks;

    public class Commands : BaseCommandModule
    {
        [Command("ping")]
        public async Task Ping(CommandContext ctx)
        {
            await ctx.RespondAsync("Pong 😈");
        }

        [Command("users")]
        public async Task UserStats(CommandContext ctx)
        {
            var stats = Program.StatsService.GetUserStats(ctx.User.Id);

            if (stats == null)
            {
                await ctx.RespondAsync("Sem dados ainda.");
                return;
            }

            await ctx.RespondAsync($"📊 Stats de {ctx.User.Username}\n" + $"Mensagens: {stats.MessageCount}");
            Console.WriteLine($"Mensagem de {ctx.User.Id} registrada!");
        }


        [Command("servers")]
        public async Task ServerStats(CommandContext ctx)
        {
            await ctx.RespondAsync("Função ainda não configurada.");
        }

        [Command("channels")]
        public async Task ChannelStats(CommandContext ctx)
        {
            await ctx.RespondAsync("Função ainda não configurada.");
        }
    }   
}
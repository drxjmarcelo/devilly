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
            await ctx.RespondAsync("Função ainda não configurada.");
        }

        [Command("Servers")]
        public async Task ServerStats(CommandContext ctx)
        {
            await ctx.RespondAsync("Função ainda não configurada.");
        }
    }   
}
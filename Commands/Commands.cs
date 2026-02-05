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

        [Command("help")]
        public async Task Help(CommandContext ctx)
        {
            await ctx.RespondAsync("Lista de comandos: \nd!ping - check bot. \nd!users - list user stats");
        }
    }   
}
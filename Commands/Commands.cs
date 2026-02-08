namespace Devilly.Cmd
{
    using DSharpPlus.CommandsNext;
    using DSharpPlus.CommandsNext.Attributes;
    using System.Threading.Tasks;
    using DSharpPlus.Entities;

    public class Commands : BaseCommandModule
    {
        [Command("ping")]
        public async Task Ping(CommandContext ctx)
        {
            var embed = new DiscordEmbedBuilder()
            {
                Title = "Ping",
                Description = "Pong 😈",
                Color = DiscordColor.Red
            };
            await ctx.RespondAsync(embed);
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
            
            var uResposta = new DiscordEmbedBuilder()
            {
                Title = $"📊 Stats de {ctx.User.Username}",
                Color = DiscordColor.Blurple

            }
            .AddField("Mensagens enviadas:", stats.MessageCount.ToString(), true)
            .WithFooter("Devil.ly 😈");
            //await ctx.RespondAsync($"📊 Stats de {ctx.User.Username}\n" + $"Mensagens: {stats.MessageCount}");
            await ctx.RespondAsync(uResposta);

        }


        [Command("servers")]
        public async Task ServerStats(CommandContext ctx)
        {
            /*var sResposta = new DiscordEmbedBuilder()
            {
                Title = $"📊Stats de {ctx.User.Username}",
                Color = DiscordColor.Blurple

            }
            .AddField("",)
            .WithFooter("Devil.ly 😈");
            await ctx.RespondAsync(sResposta);*/
            await ctx.RespondAsync("Função ainda não configurada.");
        }

        [Command("channels")]
        public async Task ChannelStats(CommandContext ctx)
        {
            await ctx.RespondAsync("Função ainda não configurada.");
        }
    }   
}
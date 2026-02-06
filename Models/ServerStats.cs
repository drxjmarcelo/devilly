namespace Devilly.Models
{
    public class ServerStats
    {
        public ulong GuildId { get; }
        public int MessageCount { get; set; }

        public ServerStats(ulong guildId)
        {
            GuildId = guildId;
        }
    }

}
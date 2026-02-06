namespace Devilly.Models
{
    public class ChannelStats
    {
        public ulong ChannelId { get; }
        public int MessageCount { get; set; }

        public ChannelStats(ulong channelId)
        {
            ChannelId = channelId;
        }
    }

}
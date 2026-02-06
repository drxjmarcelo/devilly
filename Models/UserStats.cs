namespace Devilly.Models
{
    public class UserStats
    {
        public ulong UserId { get; }
        public int MessageCount { get; set; }
        public DateTime LastMessageTime { get; set; }

        public UserStats(ulong userId)
        {
            UserId = userId;
        }
    }

}
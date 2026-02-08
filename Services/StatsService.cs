namespace Devilly.Svc
{
    using System;
    using System.Collections.Generic;

    public class StatsService
    {
        // USER: userId -> stats
        private Dictionary<ulong, Devilly.Models.UserStats> _userStats = new();

        // CHANNEL: channelId -> stats
        private Dictionary<ulong, Devilly.Models.ChannelStats> _channelStats = new();

        // SERVER: guildId -> stats
        private Dictionary<ulong, Devilly.Models.ServerStats> _serverStats = new();

        // =========================
        // MESSAGE TRACKING
        // =========================

        public void RegisterMessage(
            ulong userId,
            ulong channelId,
            ulong guildId,
            DateTime timestamp
        )
        {
            RegisterUserMessage(userId, timestamp);
            RegisterChannelMessage(channelId);
            RegisterServerMessage(guildId);
        }

        // =========================
        // USER
        // =========================

        private void RegisterUserMessage(ulong userId, DateTime time)
        {
            if (!_userStats.ContainsKey(userId))
                _userStats[userId] = new Devilly.Models.UserStats(userId);

            _userStats[userId].MessageCount++;
            _userStats[userId].LastMessageTime = time;
            Console.WriteLine($"Mensagem de {userId} registrada!");

        }

        public Devilly.Models.UserStats GetUserStats(ulong userId)
        {
            return _userStats.ContainsKey(userId)
                ? _userStats[userId]
                : null;
        }

        // =========================
        // CHANNEL
        // =========================

        private void RegisterChannelMessage(ulong channelId)
        {
            if (!_channelStats.ContainsKey(channelId))
                _channelStats[channelId] = new Devilly.Models.ChannelStats(channelId);

            _channelStats[channelId].MessageCount++;
        }

        public Devilly.Models.ChannelStats GetChannelStats(ulong channelId)
        {
            return _channelStats.ContainsKey(channelId)
                ? _channelStats[channelId]
                : null;
        }

        // =========================
        // SERVER
        // =========================

        private void RegisterServerMessage(ulong guildId)
        {
            if (!_serverStats.ContainsKey(guildId))
                _serverStats[guildId] = new Devilly.Models.ServerStats(guildId);

            _serverStats[guildId].MessageCount++;
        }

        public Devilly.Models.ServerStats GetServerStats(ulong guildId)
        {
            return _serverStats.ContainsKey(guildId) ? _serverStats[guildId] : null;
        }
    }

}
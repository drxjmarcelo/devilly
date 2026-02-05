# Devil.ly 😈

## Description: 📋
Devil.ly collects data from it's server and index them according to your commands. Devil.ly doesn't read the content of any messages in the server, altough it does know when and who sent messages.

## Functionalities: 🪛
### Gather Statistics: 📊
- User's stats
- Server's stats
- Channel's stats
- Top user
- Top channel
- Hour Peak
- Check for SPAM (doesn't take measures automatically)

## Commands: 📢
### Prefix: 📌
This instruction comes before every command, so common messages don't get mistaken as commands:
- d!
Example: d!command
### Stats: 📊
- "d!userstats" or "d!users" for short
- "d!serverstats" or "d!servers" for short
- "d!channelstats" or "d!channels" for short
### Top: 🥇
- d!topu
- d!topc
### Other: 🔀
- d!peak
- d!help

## Bot Structure: 🏗
### Main File 📁
- Program.cs
### Models Section 📋📁
- UserStats.cs
- ChannelStats.cs
- ServerStats.cs
### Services Section 🔧📁
- StatsService.cs
- SpamService.cs
- DBService.cs
### Commands Section 📢📁
- Commands.cs
### Database Section 🏛📁
- devil.db 

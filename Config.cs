using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTextChat
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        public string welcomeText { get; set; } = "Hey, did you know you can type with other people? Open your console (~ key) and use .msg <message> to talk!";
        public string msgWrongUsageText { get; set; } = "Wrong usage: .msg <message>";
        public string playerMutedResponse { get; set; } = "You are muted. If you think this is a mistake, contact the server's administrator.";
        public string mutePlayerNotFound { get; set; } = "Player not found.";
        public string playerAlreadyMuted { get; set; } = "This player is already muted. (Did you mean .unmute?)";
        public string playerMutedSuccessfully { get; set; } = "Player muted successfully!";
        public string playerUnmutedSuccessfully { get; set; } = "Player unmuted successfully!";
        public string msgSentSuccessfully { get; set; } = "Message sent successfully!";
        public string muteWrongUsageText { get; set; } = "Wrong usage: .mute <player>";
        public string unmuteWrongUsageText { get; set; } = "Wrong usage: .unmute <player>";
        public string playerNotMuted { get; set; } = "This player is not muted. (Did you mean .mute?)";
        public string msgAliveResponse { get; set; } = "Only dead players can use chat.";

        public bool chatOnlyWhenDead { get; set; } = true;
        public bool displayWelcomeText { get; set; } = true;
        public ushort welcomeTextDuration { get; set; } = 8;
    }
}

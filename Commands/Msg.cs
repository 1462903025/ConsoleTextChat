using CommandSystem;
using Exiled.API.Features;
using RemoteAdmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTextChat.Commands
{
    [CommandHandler(typeof(ClientCommandHandler))]
    class Msg : ICommand
    {
        public string Command { get; } = "msg";

        public string[] Aliases { get; } = { "message"};

        public string Description { get; } = "Lets you send a message to other players.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            Player player = Player.Get((sender as PlayerCommandSender).ReferenceHub);

            if(Plugin.Singleton.Config.chatOnlyWhenDead && player.Role != RoleType.Spectator)
            {
                response = Plugin.Singleton.Config.msgAliveResponse;
                return false;
            }

            if (arguments.Count < 1)
            {
                response = Plugin.Singleton.Config.msgWrongUsageText;
                return false;
            }
            else if(Plugin.Singleton.mutedPlayers.Contains(player.RawUserId))
            {
                response = Plugin.Singleton.Config.playerMutedResponse;
                return false;
            }
            else
            {
                string message = "";
                for (int i = 0; i != arguments.Count; i++)
                    message += (" " + arguments.At(i));

                foreach(Player p in Player.List)
                {
                    if (!Plugin.Singleton.Config.chatOnlyWhenDead)
                        p.SendConsoleMessage($"{player.Nickname}: {message}", "green");
                    else if(p.Role == RoleType.Spectator)
                        p.SendConsoleMessage($"{player.Nickname}: {message}", "green");
                }
                response = Plugin.Singleton.Config.msgSentSuccessfully;
                return true;
            }
        }
    }
}

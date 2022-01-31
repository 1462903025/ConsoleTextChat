using CommandSystem;
using Exiled.API.Features;
using Exiled.Permissions.Extensions;
using RemoteAdmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTextChat.Commands
{
    [CommandHandler(typeof(ClientCommandHandler))]
    class Unmute : ICommand
    {
        public string Command { get; } = "unmute";

        public string[] Aliases { get; } = { "um" };

        public string Description { get; } = "Lets you unmute other players.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            Player player = Player.Get((sender as PlayerCommandSender).ReferenceHub);

            if(player.CheckPermission("ctc.mute"))
            {
                if (arguments.Count < 1)
                {
                    response = Plugin.Singleton.Config.muteWrongUsageText;
                    return false;
                }

                Player playerToUnmute = player;
                bool isOnline = false;

                string message = "";
                for (int i = 0; i != arguments.Count; i++)
                    message += (" " + arguments.At(i));

                foreach (Player p in Exiled.API.Features.Player.List)
                {
                    if (message.Contains(p.Nickname))
                    {
                        playerToUnmute = p;
                        isOnline = true;
                    }
                }

                if(!isOnline)
                {
                    response = Plugin.Singleton.Config.mutePlayerNotFound;
                    return false;
                }
                else if(!Plugin.Singleton.mutedPlayers.Contains(playerToUnmute.RawUserId))
                {
                    response = Plugin.Singleton.Config.playerNotMuted;
                    return false;
                }
                else
                {
                    Plugin.Singleton.mutedPlayers.Remove(playerToUnmute.RawUserId);
                    response = Plugin.Singleton.Config.playerUnmutedSuccessfully;
                    return true;
                }
            }
            else
            {
                response = "ConsoleTextChat: Insufficient permissions. (missing permission: ctc.mute)";
                return false;
            }
        }
    }
}

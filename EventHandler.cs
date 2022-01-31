using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.Events.EventArgs;

namespace ConsoleTextChat
{
    public class EventHandler
    {
        public void OnPlayerVerified(VerifiedEventArgs ev)
        {
            if(Plugin.Singleton.Config.displayWelcomeText)
            {
                ev.Player.Broadcast(Plugin.Singleton.Config.welcomeTextDuration, Plugin.Singleton.Config.welcomeText);
            }
        }
    }
}

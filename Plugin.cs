using Exiled.API.Features;
using System;
using System.Collections.Generic;
using Exiled.Events;

namespace ConsoleTextChat
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Singleton;
        public EventHandler eventHandler;

        public List<string> mutedPlayers = new List<string>();

        public override void OnEnabled()
        {
            Singleton = this;
            eventHandler = new EventHandler();

            Exiled.Events.Handlers.Player.Verified += eventHandler.OnPlayerVerified;

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Verified -= eventHandler.OnPlayerVerified;

            eventHandler = null;

            base.OnDisabled();
        }
    }
}

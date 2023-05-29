using Exiled.API.Enums;
using Exiled.API.Features;
using System;
using nof = Exiled.Events.Handlers.Scp914;

namespace Better914
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Singleton;

        private EventHandlers events;

        public override string Author => "An4r3w";

        public override string Name { get; } = "Better914";

        public override string Prefix { get; } = "Better914";

        public override Version Version => new Version(2, 0, 0);

        public override Version RequiredExiledVersion => new Version(7, 0, 0);

        public override PluginPriority Priority => PluginPriority.Default;

        public override void OnEnabled()
        {
            base.OnEnabled();

            Singleton = this;
            events = new EventHandlers();

            nof.UpgradingPlayer += events.OnUpgradingPlayer;
        }

        public override void OnDisabled()
        {
            base.OnDisabled();
            nof.UpgradingPlayer -= events.OnUpgradingPlayer;

            events = null;
        }
    }
}
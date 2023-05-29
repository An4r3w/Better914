using Exiled.API.Features;
using Exiled.Events.EventArgs.Scp914;

namespace Better914
{
    public class EventHandlers
    {
        public void OnUpgradingPlayer(UpgradingPlayerEventArgs ev)
        {
            if (Plugin.Singleton.Config.KnobPlayerEffects.TryGetValue(ev.KnobSetting, out var effects))
            {
                Log.Debug("applying effect...");

                ev.Player.EnableEffects(effects);
            }
        }
    }
}
using Exiled.API.Enums;
using Exiled.Events.EventArgs.Scp914;

namespace Better914
{
    public class EventHandlers
    {
        public void OnUpgradingPlayer(UpgradingPlayerEventArgs ev)
        {
            if (ev.KnobSetting == Scp914.Scp914KnobSetting.Rough && Plugin.Singleton.Config.EffectsOnRough.Count != 0)
            {
                ev.Player.EnableEffects(Plugin.Singleton.Config.EffectsOnRough, duration: Plugin.Singleton.Config.EffectsOnRoughDuration);
            }
            else if (ev.KnobSetting == Scp914.Scp914KnobSetting.Coarse && Plugin.Singleton.Config.EffectsOnCoarse.Count != 0)
            {
                ev.Player.EnableEffects(Plugin.Singleton.Config.EffectsOnCoarse, duration: Plugin.Singleton.Config.EffectsOnCoarseDuration);
            }
            else if (ev.KnobSetting == Scp914.Scp914KnobSetting.OneToOne && Plugin.Singleton.Config.EffectsOn11.Count != 0)
            {
                ev.Player.EnableEffects(Plugin.Singleton.Config.EffectsOn11, duration: Plugin.Singleton.Config.EffectsOn11Duration);
            }
            else if (ev.KnobSetting == Scp914.Scp914KnobSetting.Fine && Plugin.Singleton.Config.EffectsOnFine.Count != 0)
            {
                ev.Player.EnableEffects(Plugin.Singleton.Config.EffectsOnFine, duration: Plugin.Singleton.Config.EffectsOnFineDuration);
            }
            else if (ev.KnobSetting == Scp914.Scp914KnobSetting.VeryFine && Plugin.Singleton.Config.EffectsOnVeryFine.Count != 0)
            {
                ev.Player.EnableEffects(Plugin.Singleton.Config.EffectsOnVeryFine, duration: Plugin.Singleton.Config.EffectsOnRoughDuration);
            }
        }
    }
}
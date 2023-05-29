using Exiled.API.Enums;
using Exiled.API.Interfaces;
using Scp914;
using System.Collections.Generic;
using System.ComponentModel;
using Effect = Exiled.API.Features.Effect;

namespace Better914
{
    public class Config : IConfig
    {
        [Description("Determines whether the Better914 plugin is enabled or not.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Enables or disables debug mode for Better914 plugin.")]
        public bool Debug { get; set; } = false;

        [Description("Specifies the effects that should be applied to the player when they enter an active SCP-914 with any knob setting.")]
        public Dictionary<Scp914KnobSetting, List<Effect>> KnobPlayerEffects { get; set; } = new Dictionary<Scp914KnobSetting, List<Effect>>
        {
            { Scp914KnobSetting.Rough, new List<Effect> { new Effect(EffectType.CardiacArrest, 15f, byte.MaxValue, false, true), new Effect(EffectType.Bleeding, 15f, byte.MaxValue, false, true) } },
            { Scp914KnobSetting.Coarse, new List<Effect> { new Effect(EffectType.Hemorrhage, 15f, byte.MaxValue, false, true), new Effect(EffectType.Blinded, 15f, byte.MaxValue, false, true) } },
            { Scp914KnobSetting.OneToOne, new List<Effect> { new Effect(EffectType.Poisoned, 15f, byte.MaxValue, false, true), new Effect(EffectType.Burned, 15f, byte.MaxValue, false, true) } },
            { Scp914KnobSetting.Fine, new List<Effect> { new Effect(EffectType.Scp207, 15f, byte.MaxValue, false, true), new Effect(EffectType.Invigorated, 15f, byte.MaxValue, false, true) } },
            { Scp914KnobSetting.VeryFine, new List<Effect> { new Effect(EffectType.DamageReduction, 15f, byte.MaxValue, false, true), new Effect(EffectType.Flashed, 15f, byte.MaxValue, false, true) } }
        };
    }
}
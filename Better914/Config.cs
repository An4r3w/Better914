using Exiled.API.Enums;
using Exiled.API.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;

namespace Better914
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;

        [Description("Decides wich effects should be applied to the player once it enters in an active 914 with specific knob setting")]
        public List<EffectType> EffectsOnRough { get; set; } = new List<EffectType>() { EffectType.CardiacArrest, EffectType.Bleeding, };

        public List<EffectType> EffectsOnCoarse { get; set; } = new List<EffectType> { EffectType.Hemorrhage, EffectType.Blinded };
        public List<EffectType> EffectsOn11 { get; set; } = new List<EffectType> { EffectType.Poisoned, EffectType.Burned };
        public List<EffectType> EffectsOnFine { get; set; } = new List<EffectType> { EffectType.Scp207, EffectType.Invigorated };
        public List<EffectType> EffectsOnVeryFine { get; set; } = new List<EffectType> { EffectType.DamageReduction, EffectType.Flashed };

        [Description("Decides the duration of the effects that are applied to the player once it enters in an active 914 with specific knob setting")]
        public float EffectsOnRoughDuration { get; set; } = 15;

        public float EffectsOnCoarseDuration { get; set; } = 15;
        public float EffectsOn11Duration { get; set; } = 15;
        public float EffectsOnFineDuration { get; set; } = 15;
        public float EffectsOnVeryFineDuration { get; set; } = 15;
    }
}
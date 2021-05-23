using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WfrpChars.Data
{
    enum SkillType
    {
        Bribery,
        Charm,
        [Description("Consume Alcohol")]
        ConsumeAlcohol,
        Cool,
        Endurance,
        [Description("Entertain (Storytelling)")]
        EntertainStorytelling,
        Evaluate,
        Gamble,
        Gossip,
        Haggle,
        Intuition,
        [Description("Language (Any)")]
        LanguageAny,
        [Description("Language (Classical)")]
        LanguageClassical,
        Leadership,
        [Description("Lore (Any)")]
        LoreAny,
        [Description("Lore (Heraldry)")]
        LoreHeraldry,
        [Description("Lore (Local)")]
        LoreLocal,
        [Description("Lore (Politics)")]
        LorePolitics,
        Perception,
        [Description("Ride (Horse)")]
        RideHorse,
    }
}

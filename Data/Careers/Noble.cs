using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Noble : CareerBase
    {
        public Noble(int level) : base(level) { }

        public override string Name => "Noble";

        public override string Path => Level switch
        {
            1 => "Scion",
            2 => "Noble",
            3 => "Magnate",
            4 => "Noble Lord",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Level;
        public override int Initiative => Bonus * Level;
        public override int Dexterity => Bonus * Level;
        public override int Intelligence => Bonus * Silver;
        public override int Willpower => Bonus * Gold;
        public override int Fellowship => Bonus * Brass;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Bribery, Types.Skills.ConsumeAlcohol, Types.Skills.Gamble, Types.Skills.Intimidate, Types.Skills.Leadership, Types.Skills.LoreHeraldry, Types.Skills.MeleeFencing, Types.Skills.PlayAny } },
            { 2, new List<Skills> { Types.Skills.Charm, Types.Skills.Gossip, Types.Skills.LanguageClassical, Types.Skills.LoreLocal, Types.Skills.RideHorse, Types.Skills.MeleeParry } },
            { 3, new List<Skills> { Types.Skills.LanguageAny, Types.Skills.Intuition, Types.Skills.LorePolitics, Types.Skills.Perception } },
            { 4, new List<Skills> { Types.Skills.LoreAny, Types.Skills.Track } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.EtiquetteNobles, Types.Talents.Luck, Types.Talents.NobleBlood, Types.Talents.ReadWrite } },
            { 2, new List<Talents> { Types.Talents.Attractive, Types.Talents.Briber, Types.Talents.Carouser, Types.Talents.Suave } },
            { 3, new List<Talents> { Types.Talents.Coolheaded, Types.Talents.Dealmaker, Types.Talents.PublicSpeaker, Types.Talents.Schemer } },
            { 4, new List<Talents> { Types.Talents.CommandingPresence, Types.Talents.IronWill, Types.Talents.Warleader, Types.Talents.Wealthy } }
        };
    }
}

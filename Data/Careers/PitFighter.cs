using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class PitFighter : CareerBase
    {
        public PitFighter(int level) : base(level)        {        }

        public override string Name => "Pit Fighter";

        public override string Path => Level switch
        {
            1 => "Pugilist",
            2 => "Pit Fighter",
            3 => "Pit Champion",
            4 => "Pit Legend",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Level;
        public override int Strength => Bonus * Level;
        public override int Toughness => Bonus * Level;
        public override int Intelligence => Bonus * Brass;
        public override int Agility => Bonus * Silver;
        public override int Fellowship => Bonus * Gold;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Athletics, Types.Skills.Cool, Types.Skills.Dodge, Types.Skills.Endurance, Types.Skills.Gamble, Types.Skills.Intimidate, Types.Skills.MeleeAny, Types.Skills.MeleeBrawling } },
            { 2, new List<Skills> { Types.Skills.Haggle, Types.Skills.Intuition, Types.Skills.MeleeBasic, Types.Skills.MeleeFlailOrTwoHanded, Types.Skills.Perception, Types.Skills.RangedEntangling } },
            { 3, new List<Skills> { Types.Skills.ConsumeAlcohol, Types.Skills.Gossip, Types.Skills.LoreAnatomy, Types.Skills.PerformFight } },
            { 4, new List<Skills> { Types.Skills.Charm, Types.Skills.RangedAny } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.DirtyFighting, Types.Talents.InFighter, Types.Talents.IronJaw, Types.Talents.Reversal } },
            { 2, new List<Talents> { Types.Talents.Ambidextrous, Types.Talents.CombatReflexes, Types.Talents.DualWielder, Types.Talents.Shieldsman } },
            { 3, new List<Talents> { Types.Talents.CombatMaster, Types.Talents.Disarm, Types.Talents.Menacing, Types.Talents.Robust } },
            { 4, new List<Talents> { Types.Talents.Frightening, Types.Talents.FuriousAssault, Types.Talents.Implacable, Types.Talents.ReactionStrike } }
        };
    }
}

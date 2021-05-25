using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Duellist : CareerBase
    {
        public Duellist(int level) : base(level) { }

        public override string Name => "Duelist";

        public override string Path => Level switch
        {
            1 => "Fencer",
            2 => "Duellist",
            3 => "Duelmaster",
            4 => "Judicial Champion",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Level;
        public override int BallisticSkill => Bonus * Brass;
        public override int Strength => Bonus * Silver;
        public override int Initiative => Bonus * Level;
        public override int Agility => Bonus * Level;
        public override int Willpower => Bonus * Gold;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Athletics, Types.Skills.Dodge, Types.Skills.Endurance, Types.Skills.Heal, Types.Skills.Intuition, Types.Skills.LanguageClassical, Types.Skills.MeleeAny, Types.Skills.Perception } },
            { 2, new List<Skills> { Types.Skills.Charm, Types.Skills.Cool, Types.Skills.Gamble, Types.Skills.MeleeParry, Types.Skills.RangedBlackpowder, Types.Skills.TradeGunsmith } },
            { 3, new List<Skills> { Types.Skills.Intimidate, Types.Skills.Leadership, Types.Skills.MeleeBasic, Types.Skills.PerformAcrobatics } },
            { 4, new List<Skills> { Types.Skills.LoreLaw, Types.Skills.MeleeAny } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.BeatBlade, Types.Talents.Distract, Types.Talents.Feint, Types.Talents.StepAside } },
            { 2, new List<Talents> { Types.Talents.CombatReflexes, Types.Talents.EtiquetteAny, Types.Talents.FastShot, Types.Talents.Reversal } },
            { 3, new List<Talents> { Types.Talents.Ambidextrous, Types.Talents.Disarm, Types.Talents.DualWielder, Types.Talents.Riposte } },
            { 4, new List<Talents> { Types.Talents.CombatMaster, Types.Talents.Menacing, Types.Talents.ReactionStrike, Types.Talents.StrikeToInjure } }
        };
    }
}

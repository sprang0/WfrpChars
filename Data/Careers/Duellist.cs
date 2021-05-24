using System;
using System.Collections.Generic;

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

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Athletics, SkillType.Dodge, SkillType.Endurance, SkillType.Heal, SkillType.Intuition, SkillType.LanguageClassical, SkillType.MeleeAny, SkillType.Perception } },
            { 2, new List<SkillType> { SkillType.Charm, SkillType.Cool, SkillType.Gamble, SkillType.MeleeParry, SkillType.RangedBlackpowder, SkillType.TradeGunsmith } },
            { 3, new List<SkillType> { SkillType.Intimidate, SkillType.Leadership, SkillType.MeleeBasic, SkillType.PerformAcrobatics } },
            { 4, new List<SkillType> { SkillType.LoreLaw, SkillType.MeleeAny } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.BeatBlade, TalentType.Distract, TalentType.Feint, TalentType.StepAside } },
            { 2, new List<TalentType> { TalentType.CombatReflexes, TalentType.EtiquetteAny, TalentType.FastShot, TalentType.Reversal } },
            { 3, new List<TalentType> { TalentType.Ambidextrous, TalentType.Disarm, TalentType.DualWielder, TalentType.Riposte } },
            { 4, new List<TalentType> { TalentType.CombatMaster, TalentType.Menacing, TalentType.ReactionStrike, TalentType.StrikeToInjure } }
        };
    }
}

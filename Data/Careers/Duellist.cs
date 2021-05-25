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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Athletics, SkillTypes.Dodge, SkillTypes.Endurance, SkillTypes.Heal, SkillTypes.Intuition, SkillTypes.LanguageClassical, SkillTypes.MeleeAny, SkillTypes.Perception } },
            { 2, new List<SkillTypes> { SkillTypes.Charm, SkillTypes.Cool, SkillTypes.Gamble, SkillTypes.MeleeParry, SkillTypes.RangedBlackpowder, SkillTypes.TradeGunsmith } },
            { 3, new List<SkillTypes> { SkillTypes.Intimidate, SkillTypes.Leadership, SkillTypes.MeleeBasic, SkillTypes.PerformAcrobatics } },
            { 4, new List<SkillTypes> { SkillTypes.LoreLaw, SkillTypes.MeleeAny } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.BeatBlade, TalentTypes.Distract, TalentTypes.Feint, TalentTypes.StepAside } },
            { 2, new List<TalentTypes> { TalentTypes.CombatReflexes, TalentTypes.EtiquetteAny, TalentTypes.FastShot, TalentTypes.Reversal } },
            { 3, new List<TalentTypes> { TalentTypes.Ambidextrous, TalentTypes.Disarm, TalentTypes.DualWielder, TalentTypes.Riposte } },
            { 4, new List<TalentTypes> { TalentTypes.CombatMaster, TalentTypes.Menacing, TalentTypes.ReactionStrike, TalentTypes.StrikeToInjure } }
        };
    }
}

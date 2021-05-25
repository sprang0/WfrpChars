using System;
using System.Collections.Generic;

namespace WfrpChars.Data.Careers
{
    class Guard : CareerBase
    {
        public Guard(int level) : base(level) { }

        public override string Name => "Guard";

        public override string Path => Level switch
        {
            1 => "Sentry",
            2 => "Guard",
            3 => "Honour Guard",
            4 => "Guard Officer",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Level;
        public override int Strength => Bonus * Silver;
        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Brass;
        public override int Agility => Bonus * Level;
        public override int Intelligence => Bonus * Gold;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.ConsumeAlcohol, SkillType.Endurance, SkillType.EntertainStorytelling, SkillType.Gamble, SkillType.Gossip, SkillType.Intuition, SkillType.MeleeBasic, SkillType.Perception } },
            { 2, new List<SkillType> { SkillType.Athletics, SkillType.Cool, SkillType.Dodge, SkillType.Intimidate, SkillType.MeleePolearm, SkillType.RangedBow } },
            { 3, new List<SkillType> { SkillType.Heal, SkillType.LanguageBattle, SkillType.LoreEtiquette, SkillType.MeleeTwoHanded } },
            { 4, new List<SkillType> { SkillType.Leadership, SkillType.LoreWarfare } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.Diceman, TalentType.EtiquetteServants, TalentType.StrikeToStun, TalentType.Tenacious } },
            { 2, new List<TalentType> { TalentType.Relentless, TalentType.Reversal, TalentType.Shieldsman, TalentType.StrikeMightyBlow } },
            { 3, new List<TalentType> { TalentType.FearlessIntruders, TalentType.JumpUp, TalentType.StoutHearted, TalentType.Unshakeable } },
            { 4, new List<TalentType> { TalentType.CombatMaster, TalentType.FuriousAssault, TalentType.IronWill, TalentType.Robust } }
        };
    }
}

using System;
using System.Collections.Generic;

namespace WfrpChars.Data.Careers
{
    class Soldier : CareerBase
    {
        public Soldier(int level) : base(level) { }

        public override string Name => "Soldier";

        public override string Path => Level switch
        {
            1 => "Recruit",
            2 => "Soldier",
            3 => "Sergeant",
            4 => "Officer",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Level;
        public override int BallisticSkill => Bonus * Brass;
        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Silver;
        public override int Willpower => Bonus * Level;
        public override int Fellowship => Bonus * Gold;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Athletics, SkillType.Climb, SkillType.Cool, SkillType.Dodge, SkillType.Endurance, SkillType.LanguageBattle, SkillType.MeleeBasic, SkillType.PlayDrumOrFife } },
            { 2, new List<SkillType> { SkillType.ConsumeAlcohol, SkillType.Gamble, SkillType.Gossip, SkillType.MeleeAny, SkillType.RangedAny, SkillType.OutdoorSurvival } },
            { 3, new List<SkillType> { SkillType.Heal, SkillType.Intuition, SkillType.Leadership, SkillType.Perception } },
            { 4, new List<SkillType> { SkillType.LoreWarfare, SkillType.Navigation } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.Diceman, TalentType.Marksman, TalentType.StrongBack, TalentType.WarriorBorn } },
            { 2, new List<TalentType> { TalentType.Drilled, TalentType.EtiquetteSoldiers, TalentType.RapidReload, TalentType.Shieldsman } },
            { 3, new List<TalentType> { TalentType.CombatAware, TalentType.EnclosedFighter, TalentType.Unshakeable, TalentType.Warleader } },
            { 4, new List<TalentType> { TalentType.Inspiring, TalentType.PublicSpeaker, TalentType.SeasonedTraveler, TalentType.StoutHearted } }
        };
    }
}

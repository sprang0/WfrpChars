using System;
using System.Collections.Generic;

namespace WfrpChars.Data.Careers
{
    class Watchman : CareerBase
    {
        public Watchman(int level) : base(level) { }

        public override string Name => "Watchman";

        public override string Path => Level switch
        {
            1 => "Watch Recruit",
            2 => "Watchman",
            3 => "Watch Sergeant",
            4 => "Watch Captain",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Level;
        public override int Strength => Bonus * Level;
        public override int Initiative => Bonus * Silver;
        public override int Intelligence => Bonus * Gold;
        public override int Willpower => Bonus * Brass;
        public override int Fellowship => Bonus * Level;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Athletics, SkillType.Climb, SkillType.ConsumeAlcohol, SkillType.Dodge, SkillType.Endurance, SkillType.Gamble, SkillType.MeleeAny, SkillType.Perception } },
            { 2, new List<SkillType> { SkillType.Charm, SkillType.Cool, SkillType.Gossip, SkillType.Intimidate, SkillType.Intuition, SkillType.LoreLocal } },
            { 3, new List<SkillType> { SkillType.EntertainStorytelling, SkillType.Haggle, SkillType.Leadership, SkillType.LoreLaw } },
            { 4, new List<SkillType> { SkillType.LorePolitics, SkillType.RideHorse } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.Drilled, TalentType.Hardy, TalentType.StrikeToStun, TalentType.Tenacious } },
            { 2, new List<TalentType> { TalentType.BreakAndEnter, TalentType.Criminal, TalentType.NightVision, TalentType.Sprinter } },
            { 3, new List<TalentType> { TalentType.Disarm, TalentType.EtiquetteSoldiers, TalentType.FearlessCriminals, TalentType.NoseForTrouble } },
            { 4, new List<TalentType> { TalentType.PublicSpeaker, TalentType.Robust, TalentType.Kingpin, TalentType.Schemer } }
        };
    }
}

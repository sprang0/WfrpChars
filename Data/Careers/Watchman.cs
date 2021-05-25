using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Athletics, SkillTypes.Climb, SkillTypes.ConsumeAlcohol, SkillTypes.Dodge, SkillTypes.Endurance, SkillTypes.Gamble, SkillTypes.MeleeAny, SkillTypes.Perception } },
            { 2, new List<SkillTypes> { SkillTypes.Charm, SkillTypes.Cool, SkillTypes.Gossip, SkillTypes.Intimidate, SkillTypes.Intuition, SkillTypes.LoreLocal } },
            { 3, new List<SkillTypes> { SkillTypes.EntertainStorytelling, SkillTypes.Haggle, SkillTypes.Leadership, SkillTypes.LoreLaw } },
            { 4, new List<SkillTypes> { SkillTypes.LorePolitics, SkillTypes.RideHorse } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.Drilled, TalentTypes.Hardy, TalentTypes.StrikeToStun, TalentTypes.Tenacious } },
            { 2, new List<TalentTypes> { TalentTypes.BreakAndEnter, TalentTypes.Criminal, TalentTypes.NightVision, TalentTypes.Sprinter } },
            { 3, new List<TalentTypes> { TalentTypes.Disarm, TalentTypes.EtiquetteSoldiers, TalentTypes.FearlessCriminals, TalentTypes.NoseForTrouble } },
            { 4, new List<TalentTypes> { TalentTypes.PublicSpeaker, TalentTypes.Robust, TalentTypes.Kingpin, TalentTypes.Schemer } }
        };
    }
}

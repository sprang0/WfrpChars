using System;
using System.Collections.Generic;

namespace WfrpChars.Data.Careers
{
    class BountyHunter : CareerBase
    {
        public BountyHunter(int level) : base(level) { }

        public override string Name => "Bounty Hunter";

        public override string Path => Level switch
        {
            1 => "Thief-taker",
            2 => "Bounty Hunter",
            3 => "Master Bounty Hunter",
            4 => "Bounty Hunter General",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Level;
        public override int BallisticSkill => Bonus * Brass;
        public override int Strength => Bonus * Silver;
        public override int Toughness => Bonus * Level;
        public override int Agility => Bonus * Level;
        public override int Intelligence => Bonus * Gold;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Bribery, SkillType.Charm, SkillType.Gossip, SkillType.Haggle, SkillType.Intuition, SkillType.MeleeBasic, SkillType.OutdoorSurvival, SkillType.Perception } },
            { 2, new List<SkillType> { SkillType.Athletics, SkillType.Endurance, SkillType.Intimidate, SkillType.RangedCrossbow, SkillType.RangedEntangling, SkillType.Track } },
            { 3, new List<SkillType> { SkillType.AnimalCare, SkillType.Climb, SkillType.RideHorse, SkillType.Swim } },
            { 4, new List<SkillType> { SkillType.Drive, SkillType.LoreLaw } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.BreakAndEnter, TalentType.Shadow, TalentType.StrikeToStun, TalentType.Suave } },
            { 2, new List<TalentType> { TalentType.Marksman, TalentType.Relentless, TalentType.SeasonedTraveler, TalentType.StrongBack } },
            { 3, new List<TalentType> { TalentType.AccurateShot, TalentType.CarefulStrike, TalentType.DualWielder, TalentType.Sprinter } },
            { 4, new List<TalentType> { TalentType.DeadeyeShot, TalentType.FearlessBounties, TalentType.Hardy, TalentType.SureShot } }
        };
    }
}

using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Bribery, SkillTypes.Charm, SkillTypes.Gossip, SkillTypes.Haggle, SkillTypes.Intuition, SkillTypes.MeleeBasic, SkillTypes.OutdoorSurvival, SkillTypes.Perception } },
            { 2, new List<SkillTypes> { SkillTypes.Athletics, SkillTypes.Endurance, SkillTypes.Intimidate, SkillTypes.RangedCrossbow, SkillTypes.RangedEntangling, SkillTypes.Track } },
            { 3, new List<SkillTypes> { SkillTypes.AnimalCare, SkillTypes.Climb, SkillTypes.RideHorse, SkillTypes.Swim } },
            { 4, new List<SkillTypes> { SkillTypes.Drive, SkillTypes.LoreLaw } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.BreakAndEnter, TalentTypes.Shadow, TalentTypes.StrikeToStun, TalentTypes.Suave } },
            { 2, new List<TalentTypes> { TalentTypes.Marksman, TalentTypes.Relentless, TalentTypes.SeasonedTraveler, TalentTypes.StrongBack } },
            { 3, new List<TalentTypes> { TalentTypes.AccurateShot, TalentTypes.CarefulStrike, TalentTypes.DualWielder, TalentTypes.Sprinter } },
            { 4, new List<TalentTypes> { TalentTypes.DeadeyeShot, TalentTypes.FearlessBounties, TalentTypes.Hardy, TalentTypes.SureShot } }
        };
    }
}

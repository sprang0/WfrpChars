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

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Bribery, Types.Skills.Charm, Types.Skills.Gossip, Types.Skills.Haggle, Types.Skills.Intuition, Types.Skills.MeleeBasic, Types.Skills.OutdoorSurvival, Types.Skills.Perception } },
            { 2, new List<Skills> { Types.Skills.Athletics, Types.Skills.Endurance, Types.Skills.Intimidate, Types.Skills.RangedCrossbow, Types.Skills.RangedEntangling, Types.Skills.Track } },
            { 3, new List<Skills> { Types.Skills.AnimalCare, Types.Skills.Climb, Types.Skills.RideHorse, Types.Skills.Swim } },
            { 4, new List<Skills> { Types.Skills.Drive, Types.Skills.LoreLaw } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.BreakAndEnter, Types.Talents.Shadow, Types.Talents.StrikeToStun, Types.Talents.Suave } },
            { 2, new List<Talents> { Types.Talents.Marksman, Types.Talents.Relentless, Types.Talents.SeasonedTraveler, Types.Talents.StrongBack } },
            { 3, new List<Talents> { Types.Talents.AccurateShot, Types.Talents.CarefulStrike, Types.Talents.DualWielder, Types.Talents.Sprinter } },
            { 4, new List<Talents> { Types.Talents.DeadeyeShot, Types.Talents.FearlessBounties, Types.Talents.Hardy, Types.Talents.SureShot } }
        };
    }
}

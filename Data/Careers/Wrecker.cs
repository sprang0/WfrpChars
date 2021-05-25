using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Wrecker : CareerBase
    {
        public Wrecker(int level) : base(level) { }

        public override string Name => "Wrecker";

        public override string Path => Level switch
        {
            1 => "Cargo Scavenger",
            2 => "Wrecker",
            3 => "River Pirate",
            4 => "Wrecker Captain",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Level;
        public override int BallisticSkill => Bonus * Silver;
        public override int Strength => Bonus * Level;
        public override int Initiative => Bonus * Level;
        public override int Willpower => Bonus * Brass;
        public override int Fellowship => Bonus * Gold;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Climb, Types.Skills.ConsumeAlcohol, Types.Skills.Dodge, Types.Skills.Endurance, Types.Skills.Row, Types.Skills.MeleeBasic, Types.Skills.OutdoorSurvival, Types.Skills.Swim } },
            { 2, new List<Skills> { Types.Skills.Bribery, Types.Skills.Cool, Types.Skills.Intuition, Types.Skills.Navigation, Types.Skills.Perception, Types.Skills.SetTrap } },
            { 3, new List<Skills> { Types.Skills.Gossip, Types.Skills.Intimidate, Types.Skills.RangedCrossbow, Types.Skills.StealthRural } },
            { 4, new List<Skills> { Types.Skills.Leadership, Types.Skills.LoreRiverways } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.BreakAndEnter, Types.Talents.Criminal, Types.Talents.Fisherman, Types.Talents.StrongBack } },
            { 2, new List<Talents> { Types.Talents.Flee, Types.Talents.Rover, Types.Talents.StrongSwimmer, Types.Talents.Trapper } },
            { 3, new List<Talents> { Types.Talents.DirtyFighting, Types.Talents.EtiquetteCriminals, Types.Talents.Menacing, Types.Talents.Waterman } },
            { 4, new List<Talents> { Types.Talents.FuriousAssault, Types.Talents.InFighter, Types.Talents.Pilot, Types.Talents.WarriorBorn } }
        };
    }
}

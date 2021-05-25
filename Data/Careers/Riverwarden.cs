using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Riverwarden : CareerBase
    {
        public Riverwarden(int level) : base(level) { }

        public override string Name => "Riverwarden";

        public override string Path => Level switch
        {
            1 => "River Recruit",
            2 => "Riverwarden",
            3 => "Shipsword",
            4 => "Shipsword Master",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Brass;
        public override int BallisticSkill => Bonus * Level;
        public override int Strength => Bonus * Level;
        public override int Initiative => Bonus * Silver;
        public override int Intelligence => Bonus * Gold;
        public override int Fellowship => Bonus * Level;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Athletics, Types.Skills.Dodge, Types.Skills.Endurance, Types.Skills.MeleeBasic, Types.Skills.Perception, Types.Skills.Row, Types.Skills.Sail, Types.Skills.Swim } },
            { 2, new List<Skills> { Types.Skills.Bribery, Types.Skills.Charm, Types.Skills.Intimidate, Types.Skills.Gossip, Types.Skills.LoreRiverways, Types.Skills.RangedBlackpowder } },
            { 3, new List<Skills> { Types.Skills.Climb, Types.Skills.Cool, Types.Skills.Intuition, Types.Skills.Leadership } },
            { 4, new List<Skills> { Types.Skills.LoreLaw, Types.Skills.Navigation } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.StrongSwimmer, Types.Talents.StrongBack, Types.Talents.VeryStrong, Types.Talents.Waterman } },
            { 2, new List<Talents> { Types.Talents.Criminal, Types.Talents.Gunner, Types.Talents.Fisherman, Types.Talents.SeasonedTraveler } },
            { 3, new List<Talents> { Types.Talents.FearlessWreckers, Types.Talents.HatredAny, Types.Talents.Pilot, Types.Talents.SeaLegs } },
            { 4, new List<Talents> { Types.Talents.CommandingPresence, Types.Talents.Kingpin, Types.Talents.Menacing, Types.Talents.Orientation } }
        };
    }
}

using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Thief : CareerBase
    {
        public Thief(int level) : base(level) { }

        public override string Name => "Thief";

        public override string Path => Level switch
        {
            1 => "Prowler",
            2 => "Thief",
            3 => "Master Thief",
            4 => "Cat Burglar",
            _ => throw new Exception("No such Level")
        };

        public override int Strength => Bonus * Silver;
        public override int Initiative => Bonus * Level;
        public override int Agility => Bonus * Level;
        public override int Dexterity => Bonus * Brass;
        public override int Willpower => Bonus * Level;
        public override int Fellowship => Bonus * Gold;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Athletics, Types.Skills.Climb, Types.Skills.Cool, Types.Skills.Dodge, Types.Skills.Endurance, Types.Skills.Intuition, Types.Skills.Perception, Types.Skills.StealthUrban } },
            { 2, new List<Skills> { Types.Skills.Evaluate, Types.Skills.Gossip, Types.Skills.LoreLocal, Types.Skills.PickLock, Types.Skills.SecretSignsThief, Types.Skills.SleightOfHand } },
            { 3, new List<Skills> { Types.Skills.Bribery, Types.Skills.Gamble, Types.Skills.Intimidate, Types.Skills.RangedCrossbow } },
            { 4, new List<Skills> { Types.Skills.Charm, Types.Skills.SetTrap } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.AlleyCat, Types.Talents.Criminal, Types.Talents.Flee, Types.Talents.StrikeToStun } },
            { 2, new List<Talents> { Types.Talents.BreakAndEnter, Types.Talents.EtiquetteCriminals, Types.Talents.FastHands, Types.Talents.Shadow } },
            { 3, new List<Talents> { Types.Talents.NightVision, Types.Talents.NimbleFingered, Types.Talents.StepAside, Types.Talents.Trapper } },
            { 4, new List<Talents> { Types.Talents.Catfall, Types.Talents.ScaleSheerSurface, Types.Talents.StrongLegs, Types.Talents.Wealthy } }
        };
    }
}

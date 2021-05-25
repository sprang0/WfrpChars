using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class GraveRobber : CareerBase
    {
        public GraveRobber(int level) : base(level) { }

        public override string Name => "Grave Robber";

        public override string Path => Level switch
        {
            1 => "Body Snatcher",
            2 => "Grave Robber",
            3 => "Tomb Robber",
            4 => "Treasure Hunter",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Brass;
        public override int Strength => Bonus * Level;
        public override int Initiative => Bonus * Level;
        public override int Dexterity => Bonus * Silver;
        public override int Intelligence => Bonus * Gold;
        public override int Willpower => Bonus * Level;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Climb, Types.Skills.Cool, Types.Skills.Dodge, Types.Skills.Endurance, Types.Skills.Gossip, Types.Skills.Intuition, Types.Skills.Perception, Types.Skills.StealthAny } },
            { 2, new List<Skills> { Types.Skills.Bribery, Types.Skills.Drive, Types.Skills.Evaluate, Types.Skills.Haggle, Types.Skills.LoreMedicine, Types.Skills.MeleeBasic } },
            { 3, new List<Skills> { Types.Skills.LoreHistory, Types.Skills.PickLock, Types.Skills.Research, Types.Skills.SetTrap } },
            { 4, new List<Skills> { Types.Skills.Navigation, Types.Skills.TradeEngineer } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.AlleyCat, Types.Talents.Criminal, Types.Talents.Flee, Types.Talents.StrongBack } },
            { 2, new List<Talents> { Types.Talents.BreakAndEnter, Types.Talents.NightVision, Types.Talents.ResistanceDisease, Types.Talents.VeryStrong } },
            { 3, new List<Talents> { Types.Talents.ReadWrite, Types.Talents.StrikeMightyBlow, Types.Talents.Tenacious, Types.Talents.TunnelRat } },
            { 4, new List<Talents> { Types.Talents.FearlessUndead, Types.Talents.SixthSense, Types.Talents.StrongMinded, Types.Talents.Trapper } }
        };
    }
}

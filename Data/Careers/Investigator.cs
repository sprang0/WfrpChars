using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Investigator : CareerBase
    {
        public Investigator(int level) : base(level) { }

        public override string Name => "Investigator";

        public override string Path => Level switch
        {
            1 => "Sleuth",
            2 => "Investigator",
            3 => "Master Investigator",
            4 => "Detective",
            _ => throw new Exception("No such Level")
        };

        public override int Initiative => Bonus * Level;
        public override int Agility => Bonus * Level;
        public override int Dexterity => Bonus * Silver;
        public override int Intelligence => Bonus * Level;
        public override int Willpower => Bonus * Gold;
        public override int Fellowship => Bonus * Brass;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Charm, Types.Skills.Climb, Types.Skills.Cool, Types.Skills.Gossip, Types.Skills.Intuition, Types.Skills.Perception, Types.Skills.StealthUrban, Types.Skills.Track } },
            { 2, new List<Skills> { Types.Skills.ConsumeAlcohol, Types.Skills.Dodge, Types.Skills.LoreLaw, Types.Skills.MeleeBrawling, Types.Skills.PickLock, Types.Skills.SleightOfHand } },
            { 3, new List<Skills> { Types.Skills.Bribery, Types.Skills.Evaluate, Types.Skills.Leadership, Types.Skills.LoreAny } },
            { 4, new List<Skills> { Types.Skills.Intimidate, Types.Skills.LoreAny } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.AlleyCat, Types.Talents.BeneathNotice, Types.Talents.ReadWrite, Types.Talents.Sharp } },
            { 2, new List<Talents> { Types.Talents.EtiquetteAny, Types.Talents.Savvy, Types.Talents.Shadow, Types.Talents.Tenacious } },
            { 3, new List<Talents> { Types.Talents.Bookish, Types.Talents.BreakAndEnter, Types.Talents.SixthSense, Types.Talents.Suave } },
            { 4, new List<Talents> { Types.Talents.AcuteSenseAny, Types.Talents.SavantAny, Types.Talents.Speedreader, Types.Talents.TowerOfMemories } }
        };
    }
}

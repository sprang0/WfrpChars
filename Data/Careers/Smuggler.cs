using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Smuggler : CareerBase
    {
        public Smuggler(int level) : base(level) { }

        public override string Name => "Smuggler";

        public override string Path => Level switch
        {
            1 => "River Runner",
            2 => "Smuggler",
            3 => "Master Smuggler",
            4 => "Smuggler King",
            _ => throw new Exception("No such Level")
        };

        public override int Initiative => Bonus * Brass;
        public override int Agility => Bonus * Level;
        public override int Dexterity => Bonus * Level;
        public override int Intelligence => Bonus * Silver;
        public override int Willpower => Bonus * Level;
        public override int Fellowship => Bonus * Gold;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Athletics, Types.Skills.Bribery, Types.Skills.Cool, Types.Skills.ConsumeAlcohol, Types.Skills.Row, Types.Skills.Sail, Types.Skills.StealthRuralOrUrban, Types.Skills.Swim } },
            { 2, new List<Skills> { Types.Skills.Haggle, Types.Skills.Gossip, Types.Skills.LoreLocal, Types.Skills.MeleeBasic, Types.Skills.Perception, Types.Skills.SecretSignsSmuggler } },
            { 3, new List<Skills> { Types.Skills.Evaluate, Types.Skills.Intimidate, Types.Skills.Intuition, Types.Skills.LoreRiverways } },
            { 4, new List<Skills> { Types.Skills.LanguageAny, Types.Skills.Leadership } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.Criminal, Types.Talents.Fisherman, Types.Talents.StriderMarshes, Types.Talents.StrongBack } },
            { 2, new List<Talents> { Types.Talents.Dealmaker, Types.Talents.EtiquetteCriminals, Types.Talents.Waterman, Types.Talents.VeryStrong } },
            { 3, new List<Talents> { Types.Talents.Briber, Types.Talents.FearlessRiverwardens, Types.Talents.Pilot, Types.Talents.StrongSwimmer } },
            { 4, new List<Talents> { Types.Talents.Kingpin, Types.Talents.Savvy, Types.Talents.StriderCoastal, Types.Talents.SeaLegs } }
        };
    }
}

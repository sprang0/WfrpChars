using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Pedlar : CareerBase
    {
        public Pedlar(int level) : base(level) { }

        public override string Name => "Pedlar";

        public override string Path => Level switch
        {
            1 => "Vagabond",
            2 => "Pedlar",
            3 => "Master Pedlar",
            4 => "Wandering Trader",
            _ => throw new Exception("No such Level")
        };

        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Silver;
        public override int Dexterity => Bonus * Level;
        public override int Intelligence => Bonus * Gold;
        public override int Willpower => Bonus * Level;
        public override int Fellowship => Bonus * Brass;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Charm, Types.Skills.Endurance, Types.Skills.EntertainStorytelling, Types.Skills.Gossip, Types.Skills.Haggle, Types.Skills.Intuition, Types.Skills.OutdoorSurvival, Types.Skills.StealthRuralOrUrban } },
            { 2, new List<Skills> { Types.Skills.AnimalCare, Types.Skills.CharmAnimal, Types.Skills.ConsumeAlcohol, Types.Skills.Evaluate, Types.Skills.RideHorse, Types.Skills.TradeTinker } },
            { 3, new List<Skills> { Types.Skills.Drive, Types.Skills.Intimidate, Types.Skills.LanguageAny, Types.Skills.Perception } },
            { 4, new List<Skills> { Types.Skills.LoreLocal, Types.Skills.LoreGeography } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.Fisherman, Types.Talents.Flee, Types.Talents.Rover, Types.Talents.Tinker } },
            { 2, new List<Talents> { Types.Talents.Dealmaker, Types.Talents.Orientation, Types.Talents.SeasonedTraveler, Types.Talents.StrongBack } },
            { 3, new List<Talents> { Types.Talents.Numismatics, Types.Talents.Sturdy, Types.Talents.WellPrepared, Types.Talents.VeryResilient } },
            { 4, new List<Talents> { Types.Talents.CatTongued, Types.Talents.StrongMinded, Types.Talents.Suave, Types.Talents.Tenacious } }
        };
    }
}

using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Scout : CareerBase
    {
        public Scout(int level) : base(level) { }

        public override string Name => "Scout";

        public override string Path => Level switch
        {
            1 => "Guide",
            2 => "Scout",
            3 => "Pathfinder",
            4 => "Explorer",
            _ => throw new Exception("No such Level")
        };

        public override int BallisticSkill => Bonus * Brass;
        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Level;
        public override int Agility => Bonus * Level;
        public override int Dexterity => Bonus * Gold;
        public override int Intelligence => Bonus * Silver;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.CharmAnimal, Types.Skills.Climb, Types.Skills.Endurance, Types.Skills.Gossip, Types.Skills.LoreLocal, Types.Skills.MeleeBasic, Types.Skills.OutdoorSurvival, Types.Skills.Perception } },
            { 2, new List<Skills> { Types.Skills.Athletics, Types.Skills.Navigation, Types.Skills.RangedBow, Types.Skills.RideHorse, Types.Skills.StealthRural, Types.Skills.Track } },
            { 3, new List<Skills> { Types.Skills.AnimalCare, Types.Skills.Haggle, Types.Skills.SecretSignsHunter, Types.Skills.Swim } },
            { 4, new List<Skills> { Types.Skills.LanguageAny, Types.Skills.TradeCartographer } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.Orientation, Types.Talents.Rover, Types.Talents.Sharp, Types.Talents.StriderAny } },
            { 2, new List<Talents> { Types.Talents.CombatAware, Types.Talents.NightVision, Types.Talents.NoseForTrouble, Types.Talents.SeasonedTraveler } },
            { 3, new List<Talents> { Types.Talents.AcuteSenseSight, Types.Talents.SixthSense, Types.Talents.StrongLegs, Types.Talents.VeryResilient } },
            { 4, new List<Talents> { Types.Talents.Hardy, Types.Talents.Linguistics, Types.Talents.SavantLocal, Types.Talents.Tenacious } }
        };
    }
}

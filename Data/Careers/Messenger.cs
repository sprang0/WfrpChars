using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Messenger : CareerBase
    {
        public Messenger(int level) : base(level) { }

        public override string Name => "Messenger";

        public override string Path => Level switch
        {
            1 => "Runner",
            2 => "Messenger",
            3 => "Courier",
            4 => "Courier-Captain",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Brass;
        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Level;
        public override int Agility => Bonus * Level;
        public override int Willpower => Bonus * Silver;
        public override int Fellowship => Bonus * Gold;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Athletics, Types.Skills.Climb, Types.Skills.Dodge, Types.Skills.Endurance, Types.Skills.Gossip, Types.Skills.Navigation, Types.Skills.Perception, Types.Skills.MeleeBrawling } },
            { 2, new List<Skills> { Types.Skills.AnimalCare, Types.Skills.Charm, Types.Skills.Cool, Types.Skills.LoreLocal, Types.Skills.MeleeBasic, Types.Skills.RideHorse } },
            { 3, new List<Skills> { Types.Skills.CharmAnimal, Types.Skills.Bribery, Types.Skills.ConsumeAlcohol, Types.Skills.OutdoorSurvival } },
            { 4, new List<Skills> { Types.Skills.Intimidate, Types.Skills.Leadership } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.Flee, Types.Talents.FleetFooted, Types.Talents.Sprinter, Types.Talents.StepAside } },
            { 2, new List<Talents> { Types.Talents.CrackTheWhip, Types.Talents.Criminal, Types.Talents.Orientation, Types.Talents.SeasonedTraveler } },
            { 3, new List<Talents> { Types.Talents.NoseForTrouble, Types.Talents.Relentless, Types.Talents.Tenacious, Types.Talents.TrickRiding } },
            { 4, new List<Talents> { Types.Talents.Dealmaker, Types.Talents.HatredOutlaws, Types.Talents.Kingpin, Types.Talents.VeryResilient } }
        };
    }
}

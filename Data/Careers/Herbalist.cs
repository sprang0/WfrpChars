using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Herbalist : CareerBase
    {
        public Herbalist(int level) : base(level) { }

        public override string Name => "Herbalist";

        public override string Path => Level switch
        {
            1 => "Herb Gatherer",
            2 => "Herbalist",
            3 => "Herb Master",
            4 => "Herbwise",
            _ => throw new Exception("No such Level")
        };

        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Level;
        public override int Agility => Bonus * Level;
        public override int Dexterity => Bonus * Brass;
        public override int Intelligence => Bonus * Gold;
        public override int Fellowship => Bonus * Silver;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.CharmAnimal, Types.Skills.Climb, Types.Skills.Endurance, Types.Skills.LoreHerbs, Types.Skills.OutdoorSurvival, Types.Skills.Perception, Types.Skills.Swim, Types.Skills.TradeHerbalist } },
            { 2, new List<Skills> { Types.Skills.ConsumeAlcohol, Types.Skills.Cool, Types.Skills.Gossip, Types.Skills.Haggle, Types.Skills.Heal, Types.Skills.LoreLocal } },
            { 3, new List<Skills> { Types.Skills.Intuition, Types.Skills.Leadership, Types.Skills.LoreMedicine, Types.Skills.TradePoisons } },
            { 4, new List<Skills> { Types.Skills.Drive, Types.Skills.Navigation } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.AcuteSenseTaste, Types.Talents.Orientation, Types.Talents.Rover, Types.Talents.StriderAny } },
            { 2, new List<Talents> { Types.Talents.Dealmaker, Types.Talents.NimbleFingered, Types.Talents.Sharp, Types.Talents.Sturdy } },
            { 3, new List<Talents> { Types.Talents.CraftsmanHerbalist, Types.Talents.FieldDressing, Types.Talents.Hardy, Types.Talents.Savvy } },
            { 4, new List<Talents> { Types.Talents.Concoct, Types.Talents.MasterTradesmanHerbalist, Types.Talents.ResistancePoison, Types.Talents.SavantHerbs } }
        };
    }
}

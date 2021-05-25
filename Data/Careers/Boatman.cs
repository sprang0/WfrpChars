using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Boatman : CareerBase
    {
        public Boatman(int level) : base(level) { }

        public override string Name => "Boatman";

        public override string Path => Level switch
        {
            1 => "Boat-hand",
            2 => "Boatman",
            3 => "Bargeswain",
            4 => "Barge Master",
            _ => throw new Exception("No such Level")
        };

        public override int Strength => Bonus * Level;
        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Brass;
        public override int Agility => Bonus * Level;
        public override int Dexterity => Bonus * Silver;
        public override int Intelligence => Bonus * Gold;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.ConsumeAlcohol, Types.Skills.Dodge, Types.Skills.Endurance, Types.Skills.Gossip, Types.Skills.MeleeBrawling, Types.Skills.Row, Types.Skills.Sail, Types.Skills.Swim } },
            { 2, new List<Skills> { Types.Skills.Athletics, Types.Skills.EntertainStorytelling, Types.Skills.Haggle, Types.Skills.Intuition, Types.Skills.LoreRiverways, Types.Skills.Perception } },
            { 3, new List<Skills> { Types.Skills.Climb, Types.Skills.EntertainSinging, Types.Skills.Heal, Types.Skills.TradeBoatbuilding } },
            { 4, new List<Skills> { Types.Skills.Leadership, Types.Skills.Navigation } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.DirtyFighting, Types.Talents.Fisherman, Types.Talents.StrongBack, Types.Talents.StrongSwimmer } },
            { 2, new List<Talents> { Types.Talents.EtiquetteGuilder, Types.Talents.SeasonedTraveler, Types.Talents.VeryStrong, Types.Talents.Waterman } },
            { 3, new List<Talents> { Types.Talents.Dealmaker, Types.Talents.Embezzle, Types.Talents.NoseForTrouble, Types.Talents.StrikeMightyBlow } },
            { 4, new List<Talents> { Types.Talents.Menacing, Types.Talents.Orientation, Types.Talents.Pilot, Types.Talents.PublicSpeaker } }
        };
    }
}

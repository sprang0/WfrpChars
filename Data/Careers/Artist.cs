using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Artist : CareerBase
    {
        public Artist(int level) : base(level) { }

        public override string Name => "Artist";

        public override string Path => Level switch
        {
            1 => "Apprentice Artist",
            2 => "Artist",
            3 => "Master Artist",
            4 => "Maestro",
            _ => throw new Exception("No such Level")
        };

        public override int Strength => Bonus * Level;
        public override int Initiative => Bonus * Level;
        public override int Dexterity => Bonus * Level;
        public override int Intelligence => Bonus * Gold;
        public override int Willpower => Bonus * Silver;
        public override int Fellowship => Bonus * Brass;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.ArtAny, Types.Skills.Cool, Types.Skills.ConsumeAlcohol, Types.Skills.Evaluate, Types.Skills.Endurance, Types.Skills.Gossip, Types.Skills.Perception, Types.Skills.StealthUrban } },
            { 2, new List<Skills> { Types.Skills.Climb, Types.Skills.Gamble, Types.Skills.Haggle, Types.Skills.Intuition, Types.Skills.LanguageClassical, Types.Skills.TradeArtSupplies } },
            { 3, new List<Skills> { Types.Skills.Charm, Types.Skills.Leadership, Types.Skills.LoreArt, Types.Skills.LoreHeraldry } },
            { 4, new List<Skills> { Types.Skills.Research, Types.Skills.RideHorse } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.Artistic, Types.Talents.Sharp, Types.Talents.StrongBack, Types.Talents.Tenacious } },
            { 2, new List<Talents> { Types.Talents.Carouser, Types.Talents.Criminal, Types.Talents.Gregarious, Types.Talents.NimbleFingered } },
            { 3, new List<Talents> { Types.Talents.AcuteSenseAny, Types.Talents.Dealmaker, Types.Talents.EtiquetteAny, Types.Talents.NoseForTrouble } },
            { 4, new List<Talents> { Types.Talents.Ambidextrous, Types.Talents.Kingpin, Types.Talents.MagnumOpus, Types.Talents.ReadWrite } }
        };
    }
}

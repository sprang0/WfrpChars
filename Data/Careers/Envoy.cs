using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Envoy : CareerBase
    {
        public Envoy(int level) : base(level) { }

        public override string Name => "Envoy";

        public override string Path => Level switch
        {
            1 => "Herald",
            2 => "Envoy",
            3 => "Diplomat",
            4 => "Ambassador",
            _ => throw new Exception("No such Level")
        };

        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Silver;
        public override int Agility => Bonus * Level;
        public override int Intelligence => Bonus * Brass;
        public override int Willpower => Bonus * Gold;
        public override int Fellowship => Bonus * Level;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Athletics, Types.Skills.Charm, Types.Skills.Drive, Types.Skills.Dodge, Types.Skills.Endurance, Types.Skills.Intuition, Types.Skills.RideHorse, Types.Skills.Row } },
            { 2, new List<Skills> { Types.Skills.ArtWriting, Types.Skills.Bribery, Types.Skills.Cool, Types.Skills.Gossip, Types.Skills.Haggle, Types.Skills.LorePolitics } },
            { 3, new List<Skills> { Types.Skills.Intimidate, Types.Skills.LanguageAny, Types.Skills.Leadership, Types.Skills.Navigation } },
            { 4, new List<Skills> { Types.Skills.LanguageAny, Types.Skills.LoreAny } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.Blather, Types.Talents.EtiquetteNobles, Types.Talents.ReadWrite, Types.Talents.Suave } },
            { 2, new List<Talents> { Types.Talents.Attractive, Types.Talents.CatTongued, Types.Talents.EtiquetteAny, Types.Talents.SeasonedTraveler } },
            { 3, new List<Talents> { Types.Talents.Carouser, Types.Talents.Dealmaker, Types.Talents.Gregarious, Types.Talents.Schemer } },
            { 4, new List<Talents> { Types.Talents.Briber, Types.Talents.CommandingPresence, Types.Talents.NobleBlood, Types.Talents.Savvy } }
        };
    }
}

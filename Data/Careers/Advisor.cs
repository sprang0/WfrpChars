using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Advisor : CareerBase
    {
        public Advisor(int level) : base(level) { }

        public override string Name => "Advisor";

        public override string Path => Level switch
        {
            1 => "Aide",
            2 => "Advisor",
            3 => "Counsellor",
            4 => "Chancellor",
            _ => throw new Exception("No such Level")
        };

        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Level;
        public override int Agility => Bonus * Level;
        public override int Intelligence => Bonus * Silver;
        public override int Willpower => Bonus * Gold;
        public override int Fellowship => Bonus * Brass;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Bribery, Types.Skills.ConsumeAlcohol, Types.Skills.Endurance, Types.Skills.Gossip, Types.Skills.Haggle, Types.Skills.LanguageClassical, Types.Skills.LorePolitics, Types.Skills.Perception } },
            { 2, new List<Skills> { Types.Skills.Charm, Types.Skills.Cool, Types.Skills.Evaluate, Types.Skills.Gamble, Types.Skills.Intuition, Types.Skills.LoreLocal } },
            { 3, new List<Skills> { Types.Skills.EntertainStorytelling, Types.Skills.Leadership, Types.Skills.LanguageAny, Types.Skills.LoreAny } },
            { 4, new List<Skills> { Types.Skills.LoreHeraldry, Types.Skills.RideHorse } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.BeneathNotice, Types.Talents.EtiquetteAny, Types.Talents.Gregarious, Types.Talents.ReadWrite } },
            { 2, new List<Talents> { Types.Talents.Blather, Types.Talents.Criminal, Types.Talents.Schemer, Types.Talents.Supportive } },
            { 3, new List<Talents> { Types.Talents.Argumentative, Types.Talents.Briber, Types.Talents.Carouser, Types.Talents.CatTongued } },
            { 4, new List<Talents> { Types.Talents.CommandingPresence, Types.Talents.Embezzle, Types.Talents.Kingpin, Types.Talents.Suave } }
        };
    }
}

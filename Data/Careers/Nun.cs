using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Nun : CareerBase
    {
        public Nun(int level) : base(level) { }

        public override string Name => "Nun";

        public override string Path => Level switch
        {
            1 => "Novitiate",
            2 => "Nun",
            3 => "Abbess",
            4 => "Prioress General",
            _ => throw new Exception("No such Level")
        };

        public override int Toughness => Bonus * Gold;
        public override int Initiative => Bonus * Silver;
        public override int Dexterity => Bonus * Level;
        public override int Intelligence => Bonus * Level;
        public override int Willpower => Bonus * Brass;
        public override int Fellowship => Bonus * Level;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.ArtCalligraphy, Types.Skills.Cool, Types.Skills.Endurance, Types.Skills.EntertainStorytelling, Types.Skills.Gossip, Types.Skills.Heal, Types.Skills.LoreTheology, Types.Skills.Pray } },
            { 2, new List<Skills> { Types.Skills.Charm, Types.Skills.MeleeAny, Types.Skills.Research, Types.Skills.TradeBrewer, Types.Skills.TradeHerbalist, Types.Skills.TradeVintner } },
            { 3, new List<Skills> { Types.Skills.Leadership, Types.Skills.LoreLocal, Types.Skills.LorePolitics, Types.Skills.Perception } },
            { 4, new List<Skills> { Types.Skills.LanguageAny, Types.Skills.LoreAny } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.BlessAny, Types.Talents.StoneSoup, Types.Talents.Panhandle, Types.Talents.ReadWrite } },
            { 2, new List<Talents> { Types.Talents.EtiquetteCultists, Types.Talents.FieldDressing, Types.Talents.HolyVisions, Types.Talents.InvokeAny } },
            { 3, new List<Talents> { Types.Talents.ResistanceAny, Types.Talents.Robust, Types.Talents.SavantTheology, Types.Talents.StoutHearted } },
            { 4, new List<Talents> { Types.Talents.CommandingPresence, Types.Talents.IronWill, Types.Talents.PureSoul, Types.Talents.StrongMinded } }
        };
    }
}

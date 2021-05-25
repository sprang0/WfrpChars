using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Scholar : CareerBase
    {
        public Scholar(int level) : base(level) { }

        public override string Name => "Scholar";

        public override string Path => Level switch
        {
            1 => "Student",
            2 => "Scholar",
            3 => "Fellow",
            4 => "Professor",
            _ => throw new Exception("No such Level")
        };

        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Brass;
        public override int Dexterity => Bonus * Gold;
        public override int Intelligence => Bonus * Level;
        public override int Willpower => Bonus * Level;
        public override int Fellowship => Bonus * Silver;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.ConsumeAlcohol, Types.Skills.EntertainStorytelling, Types.Skills.Gamble, Types.Skills.Gossip, Types.Skills.Haggle, Types.Skills.LanguageClassical, Types.Skills.LoreAny, Types.Skills.Research } },
            { 2, new List<Skills> { Types.Skills.ArtWriting, Types.Skills.Intuition, Types.Skills.LanguageAny, Types.Skills.LoreAny, Types.Skills.Perception, Types.Skills.TradeAny } },
            { 3, new List<Skills> { Types.Skills.EntertainLecture, Types.Skills.Intimidate, Types.Skills.LanguageAny, Types.Skills.LoreAny } },
            { 4, new List<Skills> { Types.Skills.EntertainRhetoric, Types.Skills.LoreAny } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.Carouser, Types.Talents.ReadWrite, Types.Talents.Savvy, Types.Talents.SuperNumerate } },
            { 2, new List<Talents> { Types.Talents.Bookish, Types.Talents.EtiquetteScholar, Types.Talents.Speedreader, Types.Talents.Suave } },
            { 3, new List<Talents> { Types.Talents.Linguistics, Types.Talents.PublicSpeaker, Types.Talents.SavantAny, Types.Talents.TowerOfMemories } },
            { 4, new List<Talents> { Types.Talents.MagnumOpus, Types.Talents.MasterOrator, Types.Talents.SavantAny, Types.Talents.Sharp } }
        };
    }
}

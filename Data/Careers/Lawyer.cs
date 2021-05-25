using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Lawyer : CareerBase
    {
        public Lawyer(int level) : base(level) { }

        public override string Name => "Lawyer";

        public override string Path => Level switch
        {
            1 => "Student Lawyer",
            2 => "Lawyer",
            3 => "Barrister",
            4 => "Judge",
            _ => throw new Exception("No such Level")
        };

        public override int Toughness => Bonus * Gold;
        public override int Initiative => Bonus * Level;
        public override int Dexterity => Bonus * Level;
        public override int Intelligence => Bonus * Level;
        public override int Willpower => Bonus * Silver;
        public override int Fellowship => Bonus * Brass;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.ConsumeAlcohol, Types.Skills.Endurance, Types.Skills.Haggle, Types.Skills.LanguageClassical, Types.Skills.LoreLaw, Types.Skills.LoreTheology, Types.Skills.Perception, Types.Skills.Research } },
            { 2, new List<Skills> { Types.Skills.Bribery, Types.Skills.Charm, Types.Skills.Gossip, Types.Skills.Intuition, Types.Skills.LanguageGuilder, Types.Skills.SecretSignsGuilder } },
            { 3, new List<Skills> { Types.Skills.ArtWriting, Types.Skills.EntertainSpeeches, Types.Skills.Intimidate, Types.Skills.LoreAny } },
            { 4, new List<Skills> { Types.Skills.Cool, Types.Skills.LoreAny } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.Blather, Types.Talents.EtiquetteScholar, Types.Talents.ReadWrite, Types.Talents.Speedreader } },
            { 2, new List<Talents> { Types.Talents.Argumentative, Types.Talents.Criminal, Types.Talents.EtiquetteGuilder, Types.Talents.Suave } },
            { 3, new List<Talents> { Types.Talents.Bookish, Types.Talents.CatTongued, Types.Talents.ImpassionedZeal, Types.Talents.Savvy } },
            { 4, new List<Talents> { Types.Talents.CommandingPresence, Types.Talents.Kingpin, Types.Talents.SavantLaw, Types.Talents.Wealthy } }
        };
    }
}

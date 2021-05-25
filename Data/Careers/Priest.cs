using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Priest : CareerBase
    {
        public Priest(int level) : base(level) { }

        public override string Name => "Priest";

        public override string Path => Level switch
        {
            1 => "Initiate",
            2 => "Priest",
            3 => "High Priest",
            4 => "Lector",
            _ => throw new Exception("No such Level")
        };

        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Gold;
        public override int Agility => Bonus * Level;
        public override int Intelligence => Bonus * Silver;
        public override int Willpower => Bonus * Level;
        public override int Fellowship => Bonus * Brass;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Athletics, Types.Skills.Cool, Types.Skills.Endurance, Types.Skills.Intuition, Types.Skills.LoreTheology, Types.Skills.Perception, Types.Skills.Pray, Types.Skills.Research } },
            { 2, new List<Skills> { Types.Skills.Charm, Types.Skills.EntertainStorytelling, Types.Skills.Gossip, Types.Skills.Heal, Types.Skills.Intimidate, Types.Skills.MeleeBasic } },
            { 3, new List<Skills> { Types.Skills.ArtWriting, Types.Skills.EntertainSpeeches, Types.Skills.Leadership, Types.Skills.LoreHeraldry } },
            { 4, new List<Skills> { Types.Skills.LanguageAny, Types.Skills.LorePolitics } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.BlessAny, Types.Talents.HolyVisions, Types.Talents.ReadWrite, Types.Talents.Suave } },
            { 2, new List<Talents> { Types.Talents.Blather, Types.Talents.Bookish, Types.Talents.EtiquetteCultists, Types.Talents.InvokeAny } },
            { 3, new List<Talents> { Types.Talents.AcuteSenseAny, Types.Talents.HatredAny, Types.Talents.ImpassionedZeal, Types.Talents.StrongMinded } },
            { 4, new List<Talents> { Types.Talents.MasterOrator, Types.Talents.PureSoul, Types.Talents.ResistanceAny, Types.Talents.SavantTheology } }
        };
    }
}

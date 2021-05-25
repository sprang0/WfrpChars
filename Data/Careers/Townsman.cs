using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Townsman : CareerBase
    {
        public Townsman(int level) : base(level) { }

        public override string Name => "Townsman";

        public override string Path => Level switch
        {
            1 => "Clerk",
            2 => "Townsman",
            3 => "Town Councillor",
            4 => "Burgomeister",
            _ => throw new Exception("No such Level")
        };

        public override int Initiative => Bonus * Brass;
        public override int Agility => Bonus * Level;
        public override int Dexterity => Bonus * Silver;
        public override int Intelligence => Bonus * Level;
        public override int Willpower => Bonus * Gold;
        public override int Fellowship => Bonus * Level;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Charm, Types.Skills.Climb, Types.Skills.ConsumeAlcohol, Types.Skills.Drive, Types.Skills.Dodge, Types.Skills.Gamble, Types.Skills.Gossip, Types.Skills.Haggle } },
            { 2, new List<Skills> { Types.Skills.Bribery, Types.Skills.Evaluate, Types.Skills.Intuition, Types.Skills.LoreLocal, Types.Skills.MeleeBrawling, Types.Skills.PlayAny } },
            { 3, new List<Skills> { Types.Skills.Cool, Types.Skills.LoreLaw, Types.Skills.Perception, Types.Skills.Research } },
            { 4, new List<Skills> { Types.Skills.LorePolitics, Types.Skills.Intimidate } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.AlleyCat, Types.Talents.BeneathNotice, Types.Talents.EtiquetteServants, Types.Talents.Sturdy } },
            { 2, new List<Talents> { Types.Talents.Dealmaker, Types.Talents.Embezzle, Types.Talents.EtiquetteAny, Types.Talents.Gregarious } },
            { 3, new List<Talents> { Types.Talents.Briber, Types.Talents.PublicSpeaker, Types.Talents.ReadWrite, Types.Talents.Supportive } },
            { 4, new List<Talents> { Types.Talents.CommandingPresence, Types.Talents.MasterOrator, Types.Talents.Schemer, Types.Talents.Suave } }
        };
    }
}

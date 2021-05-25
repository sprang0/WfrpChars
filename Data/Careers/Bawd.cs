using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Bawd : CareerBase
    {
        public Bawd(int level) : base(level) { }

        public override string Name => "Bawd";

        public override string Path => Level switch
        {
            1 => "Hustler",
            2 => "Bawd",
            3 => "Procurer",
            4 => "Ringleader",
            _ => throw new Exception("No such Level")
        };

        public override int Initiative => Bonus * Brass;
        public override int Agility => Bonus * Level;
        public override int Dexterity => Bonus * Level;
        public override int Intelligence => Bonus * Gold;
        public override int Willpower => Bonus * Silver;
        public override int Fellowship => Bonus * Level;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Bribery, Types.Skills.Charm, Types.Skills.ConsumeAlcohol, Types.Skills.EntertainAny, Types.Skills.Gamble, Types.Skills.Gossip, Types.Skills.Haggle, Types.Skills.Intimidate } },
            { 2, new List<Skills> { Types.Skills.Dodge, Types.Skills.Endurance, Types.Skills.Intuition, Types.Skills.LoreLocal, Types.Skills.MeleeBasic, Types.Skills.Perception } },
            { 3, new List<Skills> { Types.Skills.Cool, Types.Skills.Evaluate, Types.Skills.LanguageAny, Types.Skills.LoreLaw } },
            { 4, new List<Skills> { Types.Skills.Leadership, Types.Skills.LoreHeraldry } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.Attractive, Types.Talents.AlleyCat, Types.Talents.Blather, Types.Talents.Gregarious } },
            { 2, new List<Talents> { Types.Talents.Ambidextrous, Types.Talents.Carouser, Types.Talents.Criminal, Types.Talents.ResistanceDisease } },
            { 3, new List<Talents> { Types.Talents.Dealmaker, Types.Talents.Embezzle, Types.Talents.EtiquetteAny, Types.Talents.Suave } },
            { 4, new List<Talents> { Types.Talents.Briber, Types.Talents.Kingpin, Types.Talents.Numismatics, Types.Talents.Savvy } }
        };
    }
}

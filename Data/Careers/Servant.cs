using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Servant : CareerBase
    {
        public Servant(int level) : base(level) { }

        public override string Name => "Servant";

        public override string Path => Level switch
        {
            1 => "Menial",
            2 => "Servant",
            3 => "Attendant",
            4 => "Steward",
            _ => throw new Exception("No such Level")
        };

        public override int Strength => Bonus * Level;
        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Brass;
        public override int Agility => Bonus * Level;
        public override int Intelligence => Bonus * Silver;
        public override int Fellowship => Bonus * Gold;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Athletics, Types.Skills.Climb, Types.Skills.Drive, Types.Skills.Dodge, Types.Skills.Endurance, Types.Skills.Intuition, Types.Skills.Perception, Types.Skills.StealthAny } },
            { 2, new List<Skills> { Types.Skills.AnimalCare, Types.Skills.ConsumeAlcohol, Types.Skills.Evaluate, Types.Skills.Gamble, Types.Skills.Gossip, Types.Skills.Haggle } },
            { 3, new List<Skills> { Types.Skills.Charm, Types.Skills.Cool, Types.Skills.Intimidate, Types.Skills.LoreLocal } },
            { 4, new List<Skills> { Types.Skills.Leadership, Types.Skills.MeleeBasic } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.BeneathNotice, Types.Talents.StrongBack, Types.Talents.StrongMinded, Types.Talents.Sturdy } },
            { 2, new List<Talents> { Types.Talents.EtiquetteServants, Types.Talents.Shadow, Types.Talents.Tenacious, Types.Talents.WellPrepared } },
            { 3, new List<Talents> { Types.Talents.Embezzle, Types.Talents.ResistancePoison, Types.Talents.Suave, Types.Talents.Supportive } },
            { 4, new List<Talents> { Types.Talents.EtiquetteAny, Types.Talents.Numismatics, Types.Talents.ReadWrite, Types.Talents.Savvy } }
        };
    }
}

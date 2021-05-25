using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Agitator : CareerBase
    {
        public Agitator(int level) : base(level) { }

        public override string Name => "Agitator";

        public override string Path => Level switch
        {
            1 => "Pamphleteer",
            2 => "Agitator",
            3 => "Rabble Rouser",
            4 => "Demagogue",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Silver;
        public override int BallisticSkill => Bonus * Level;
        public override int Initiative => Bonus * Gold;
        public override int Agility => Bonus * Brass;
        public override int Intelligence => Bonus * Level;
        public override int Fellowship => Bonus * Level;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.ArtWriting, Types.Skills.Bribery, Types.Skills.Charm, Types.Skills.ConsumeAlcohol, Types.Skills.Gossip, Types.Skills.Haggle, Types.Skills.LorePolitics, Types.Skills.TradePrinting } },
            { 2, new List<Skills> { Types.Skills.Cool, Types.Skills.Dodge, Types.Skills.EntertainStorytelling, Types.Skills.Gamble, Types.Skills.Intuition, Types.Skills.Leadership } },
            { 3, new List<Skills> { Types.Skills.Athletics, Types.Skills.Intimidate, Types.Skills.MeleeBrawling, Types.Skills.Perception } },
            { 4, new List<Skills> { Types.Skills.LoreHeraldry, Types.Skills.RideHorse } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.Blather, Types.Talents.Gregarious, Types.Talents.Panhandle, Types.Talents.ReadWrite } },
            { 2, new List<Talents> { Types.Talents.AlleyCat, Types.Talents.Argumentative, Types.Talents.ImpassionedZeal, Types.Talents.PublicSpeaker } },
            { 3, new List<Talents> { Types.Talents.CatTongued, Types.Talents.DirtyFighting, Types.Talents.Flee, Types.Talents.StepAside } },
            { 4, new List<Talents> { Types.Talents.EtiquetteAny, Types.Talents.MasterOrator, Types.Talents.Schemer, Types.Talents.Suave } }
        };
    }
}

using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Charlatan : CareerBase
    {
        public Charlatan(int level) : base(level) { }

        public override string Name => "Charlatan";

        public override string Path => Level switch
        {
            1 => "Swindler",
            2 => "Charlatan",
            3 => "Con Artist",
            4 => "Scoundrel",
            _ => throw new Exception("No such Level")
        };

        public override int Initiative => Bonus * Level;
        public override int Agility => Bonus * Silver;
        public override int Dexterity => Bonus * Level;
        public override int Intelligence => Bonus * Gold;
        public override int Willpower => Bonus * Brass;
        public override int Fellowship => Bonus * Level;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Bribery, Types.Skills.ConsumeAlcohol, Types.Skills.Charm, Types.Skills.EntertainStorytelling, Types.Skills.Gamble, Types.Skills.Gossip, Types.Skills.Haggle, Types.Skills.SleightOfHand } },
            { 2, new List<Skills> { Types.Skills.Cool, Types.Skills.Dodge, Types.Skills.EntertainActing, Types.Skills.Evaluate, Types.Skills.Intuition, Types.Skills.Perception } },
            { 3, new List<Skills> { Types.Skills.LanguageThief, Types.Skills.LoreHeraldry, Types.Skills.PickLock, Types.Skills.SecretSignsThief } },
            { 4, new List<Skills> { Types.Skills.LoreGenealogy, Types.Skills.Research } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.Cardsharp, Types.Talents.Diceman, Types.Talents.EtiquetteAny, Types.Talents.Luck } },
            { 2, new List<Talents> { Types.Talents.Blather, Types.Talents.Criminal, Types.Talents.FastHands, Types.Talents.SecretIdentity } },
            { 3, new List<Talents> { Types.Talents.Attractive, Types.Talents.CatTongued, Types.Talents.Dealmaker, Types.Talents.ReadWrite } },
            { 4, new List<Talents> { Types.Talents.Gregarious, Types.Talents.MasterOfDisguise, Types.Talents.NoseForTrouble, Types.Talents.Suave } }
        };
    }
}

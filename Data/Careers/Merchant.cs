using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Merchant : CareerBase
    {
        public Merchant(int level) : base(level) { }

        public override string Name => "Merchant";

        public override string Path => Level switch
        {
            1 => "Trader",
            2 => "Merchant",
            3 => "Master Merchant",
            4 => "Merchant Prince",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Gold;
        public override int Initiative => Bonus * Silver;
        public override int Agility => Bonus * Level;
        public override int Intelligence => Bonus * Brass;
        public override int Willpower => Bonus * Level;
        public override int Fellowship => Bonus * Level;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.AnimalCare, Types.Skills.Bribery, Types.Skills.Charm, Types.Skills.ConsumeAlcohol, Types.Skills.Drive, Types.Skills.Gamble, Types.Skills.Gossip, Types.Skills.Haggle } },
            { 2, new List<Skills> { Types.Skills.Evaluate, Types.Skills.Intuition, Types.Skills.LanguageAny, Types.Skills.LanguageGuilder, Types.Skills.LoreLocal, Types.Skills.Perception } },
            { 3, new List<Skills> { Types.Skills.Cool, Types.Skills.LanguageClassical, Types.Skills.Navigation, Types.Skills.SecretSignsGuilder } },
            { 4, new List<Skills> { Types.Skills.LoreAny, Types.Skills.Intimidate } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.Blather, Types.Talents.Dealmaker, Types.Talents.ReadWrite, Types.Talents.Suave } },
            { 2, new List<Talents> { Types.Talents.Briber, Types.Talents.Embezzle, Types.Talents.EtiquetteGuilder, Types.Talents.Savvy } },
            { 3, new List<Talents> { Types.Talents.CatTongued, Types.Talents.EtiquetteAny, Types.Talents.Numismatics, Types.Talents.Sharp } },
            { 4, new List<Talents> { Types.Talents.IronWill, Types.Talents.Luck, Types.Talents.Schemer, Types.Talents.Wealthy } }
        };
    }
}

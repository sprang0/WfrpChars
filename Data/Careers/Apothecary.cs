using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Apothecary : CareerBase
    {
        public Apothecary(int level) : base(level) { }

        public override string Name => "Apothecary";

        public override string Path => Level switch
        {
            1 => "Apothecary's Apprentice",
            2 => "Apothecary",
            3 => "Master Apothecary",
            4 => "Apothecary-General",
            _ => throw new Exception("No such Level")
        };

        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Silver;
        public override int Dexterity => Bonus * Level;
        public override int Intelligence => Bonus * Level;
        public override int Willpower => Bonus * Gold;
        public override int Fellowship => Bonus * Brass;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.ConsumeAlcohol, Types.Skills.Heal, Types.Skills.LanguageClassical, Types.Skills.LoreChemistry, Types.Skills.LoreMedicine, Types.Skills.LorePlants, Types.Skills.TradeApothecary, Types.Skills.TradePoisons } },
            { 2, new List<Skills> { Types.Skills.Charm, Types.Skills.Haggle, Types.Skills.LoreScience, Types.Skills.Gossip, Types.Skills.LanguageGuilder, Types.Skills.Perception } },
            { 3, new List<Skills> { Types.Skills.Intuition, Types.Skills.Leadership, Types.Skills.Research, Types.Skills.SecretSignsGuilder } },
            { 4, new List<Skills> { Types.Skills.Intimidate, Types.Skills.RideHorse } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.Concoct, Types.Talents.CraftsmanApothecary, Types.Talents.EtiquetteScholar, Types.Talents.ReadWrite } },
            { 2, new List<Talents> { Types.Talents.Criminal, Types.Talents.Dealmaker, Types.Talents.EtiquetteGuilder, Types.Talents.Pharmacist } },
            { 3, new List<Talents> { Types.Talents.Bookish, Types.Talents.MasterTradesmanApothecary, Types.Talents.ResistancePoison, Types.Talents.Savvy } },
            { 4, new List<Talents> { Types.Talents.AcuteSenseTaste, Types.Talents.Coolheaded, Types.Talents.MasterTradesmanPoisoner, Types.Talents.SavantApothecary } }
        };
    }
}

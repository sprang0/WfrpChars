using System;
using System.Collections.Generic;

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

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.ConsumeAlcohol, SkillType.Heal, SkillType.LanguageClassical, SkillType.LoreChemistry, SkillType.LoreMedicine, SkillType.LorePlants, SkillType.TradeApothecary, SkillType.TradePoisons } },
            { 2, new List<SkillType> { SkillType.Charm, SkillType.Haggle, SkillType.LoreScience, SkillType.Gossip, SkillType.LanguageGuilder, SkillType.Perception } },
            { 3, new List<SkillType> { SkillType.Intuition, SkillType.Leadership, SkillType.Research, SkillType.SecretSignsGuilder } },
            { 4, new List<SkillType> { SkillType.Intimidate, SkillType.RideHorse } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.Concoct, TalentType.CraftsmanApothecary, TalentType.EtiquetteScholar, TalentType.ReadWrite } },
            { 2, new List<TalentType> { TalentType.Criminal, TalentType.Dealmaker, TalentType.EtiquetteGuilder, TalentType.Pharmacist } },
            { 3, new List<TalentType> { TalentType.Bookish, TalentType.MasterTradesmanApothecary, TalentType.ResistancePoison, TalentType.Savvy } },
            { 4, new List<TalentType> { TalentType.AcuteSenseTaste, TalentType.Coolheaded, TalentType.MasterTradesmanPoisoner, TalentType.SavantApothecary } }
        };
    }
}

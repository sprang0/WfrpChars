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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.ConsumeAlcohol, SkillTypes.Heal, SkillTypes.LanguageClassical, SkillTypes.LoreChemistry, SkillTypes.LoreMedicine, SkillTypes.LorePlants, SkillTypes.TradeApothecary, SkillTypes.TradePoisons } },
            { 2, new List<SkillTypes> { SkillTypes.Charm, SkillTypes.Haggle, SkillTypes.LoreScience, SkillTypes.Gossip, SkillTypes.LanguageGuilder, SkillTypes.Perception } },
            { 3, new List<SkillTypes> { SkillTypes.Intuition, SkillTypes.Leadership, SkillTypes.Research, SkillTypes.SecretSignsGuilder } },
            { 4, new List<SkillTypes> { SkillTypes.Intimidate, SkillTypes.RideHorse } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.Concoct, TalentTypes.CraftsmanApothecary, TalentTypes.EtiquetteScholar, TalentTypes.ReadWrite } },
            { 2, new List<TalentTypes> { TalentTypes.Criminal, TalentTypes.Dealmaker, TalentTypes.EtiquetteGuilder, TalentTypes.Pharmacist } },
            { 3, new List<TalentTypes> { TalentTypes.Bookish, TalentTypes.MasterTradesmanApothecary, TalentTypes.ResistancePoison, TalentTypes.Savvy } },
            { 4, new List<TalentTypes> { TalentTypes.AcuteSenseTaste, TalentTypes.Coolheaded, TalentTypes.MasterTradesmanPoisoner, TalentTypes.SavantApothecary } }
        };
    }
}

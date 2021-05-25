using System;
using System.Collections.Generic;

namespace WfrpChars.Data.Careers
{
    class Physician : CareerBase
    {
        public Physician(int level) : base(level) { }

        public override string Name => "Physician";

        public override string Path => Level switch
        {
            1 => "Physician's Apprentice",
            2 => "Physician",
            3 => "Doktor",
            4 => "Court Physician",
            _ => throw new Exception("No such Level")
        };

        public override int Initiative => Bonus * Silver;
        public override int Agility => Bonus * Gold;
        public override int Dexterity => Bonus * Level;
        public override int Intelligence => Bonus * Level;
        public override int Willpower => Bonus * Level;
        public override int Fellowship => Bonus * Brass;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Bribery, SkillType.Cool, SkillType.Drive, SkillType.Endurance, SkillType.Gossip, SkillType.Heal, SkillType.Perception, SkillType.SleightOfHand } },
            { 2, new List<SkillType> { SkillType.Charm, SkillType.Haggle, SkillType.LanguageGuilder, SkillType.LoreAnatomy, SkillType.LoreMedicine, SkillType.TradeBarber } },
            { 3, new List<SkillType> { SkillType.ConsumeAlcohol, SkillType.Intimidate, SkillType.Leadership, SkillType.Research } },
            { 4, new List<SkillType> { SkillType.LoreNoble, SkillType.PerformDancing } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.Bookish, TalentType.FieldDressing, TalentType.ReadWrite, TalentType.StrikeToStun } },
            { 2, new List<TalentType> { TalentType.Coolheaded, TalentType.Criminal, TalentType.EtiquetteGuilder, TalentType.Surgery } },
            { 3, new List<TalentType> { TalentType.EtiquetteScholar, TalentType.ResistanceDisease, TalentType.Savvy, TalentType.StrikeToInjure } },
            { 4, new List<TalentType> { TalentType.EtiquetteNobles, TalentType.NimbleFingered, TalentType.SavantMedicine, TalentType.StrongMinded } }
        };
    }
}

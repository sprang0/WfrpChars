using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Bribery, SkillTypes.Cool, SkillTypes.Drive, SkillTypes.Endurance, SkillTypes.Gossip, SkillTypes.Heal, SkillTypes.Perception, SkillTypes.SleightOfHand } },
            { 2, new List<SkillTypes> { SkillTypes.Charm, SkillTypes.Haggle, SkillTypes.LanguageGuilder, SkillTypes.LoreAnatomy, SkillTypes.LoreMedicine, SkillTypes.TradeBarber } },
            { 3, new List<SkillTypes> { SkillTypes.ConsumeAlcohol, SkillTypes.Intimidate, SkillTypes.Leadership, SkillTypes.Research } },
            { 4, new List<SkillTypes> { SkillTypes.LoreNoble, SkillTypes.PerformDancing } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.Bookish, TalentTypes.FieldDressing, TalentTypes.ReadWrite, TalentTypes.StrikeToStun } },
            { 2, new List<TalentTypes> { TalentTypes.Coolheaded, TalentTypes.Criminal, TalentTypes.EtiquetteGuilder, TalentTypes.Surgery } },
            { 3, new List<TalentTypes> { TalentTypes.EtiquetteScholar, TalentTypes.ResistanceDisease, TalentTypes.Savvy, TalentTypes.StrikeToInjure } },
            { 4, new List<TalentTypes> { TalentTypes.EtiquetteNobles, TalentTypes.NimbleFingered, TalentTypes.SavantMedicine, TalentTypes.StrongMinded } }
        };
    }
}

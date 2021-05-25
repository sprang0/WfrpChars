using System;
using System.Collections.Generic;

namespace WfrpChars.Data.Careers
{
    class Lawyer : CareerBase
    {
        public Lawyer(int level) : base(level) { }

        public override string Name => "Lawyer";

        public override string Path => Level switch
        {
            1 => "Student Lawyer",
            2 => "Lawyer",
            3 => "Barrister",
            4 => "Judge",
            _ => throw new Exception("No such Level")
        };

        public override int Toughness => Bonus * Gold;
        public override int Initiative => Bonus * Level;
        public override int Dexterity => Bonus * Level;
        public override int Intelligence => Bonus * Level;
        public override int Willpower => Bonus * Silver;
        public override int Fellowship => Bonus * Brass;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.ConsumeAlcohol, SkillType.Endurance, SkillType.Haggle, SkillType.LanguageClassical, SkillType.LoreLaw, SkillType.LoreTheology, SkillType.Perception, SkillType.Research } },
            { 2, new List<SkillType> { SkillType.Bribery, SkillType.Charm, SkillType.Gossip, SkillType.Intuition, SkillType.LanguageGuilder, SkillType.SecretSignsGuilder } },
            { 3, new List<SkillType> { SkillType.ArtWriting, SkillType.EntertainSpeeches, SkillType.Intimidate, SkillType.LoreAny } },
            { 4, new List<SkillType> { SkillType.Cool, SkillType.LoreAny } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.Blather, TalentType.EtiquetteScholar, TalentType.ReadWrite, TalentType.Speedreader } },
            { 2, new List<TalentType> { TalentType.Argumentative, TalentType.Criminal, TalentType.EtiquetteGuilder, TalentType.Suave } },
            { 3, new List<TalentType> { TalentType.Bookish, TalentType.CatTongued, TalentType.ImpassionedZeal, TalentType.Savvy } },
            { 4, new List<TalentType> { TalentType.CommandingPresence, TalentType.Kingpin, TalentType.SavantLaw, TalentType.Wealthy } }
        };
    }
}

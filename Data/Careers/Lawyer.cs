using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.ConsumeAlcohol, SkillTypes.Endurance, SkillTypes.Haggle, SkillTypes.LanguageClassical, SkillTypes.LoreLaw, SkillTypes.LoreTheology, SkillTypes.Perception, SkillTypes.Research } },
            { 2, new List<SkillTypes> { SkillTypes.Bribery, SkillTypes.Charm, SkillTypes.Gossip, SkillTypes.Intuition, SkillTypes.LanguageGuilder, SkillTypes.SecretSignsGuilder } },
            { 3, new List<SkillTypes> { SkillTypes.ArtWriting, SkillTypes.EntertainSpeeches, SkillTypes.Intimidate, SkillTypes.LoreAny } },
            { 4, new List<SkillTypes> { SkillTypes.Cool, SkillTypes.LoreAny } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.Blather, TalentTypes.EtiquetteScholar, TalentTypes.ReadWrite, TalentTypes.Speedreader } },
            { 2, new List<TalentTypes> { TalentTypes.Argumentative, TalentTypes.Criminal, TalentTypes.EtiquetteGuilder, TalentTypes.Suave } },
            { 3, new List<TalentTypes> { TalentTypes.Bookish, TalentTypes.CatTongued, TalentTypes.ImpassionedZeal, TalentTypes.Savvy } },
            { 4, new List<TalentTypes> { TalentTypes.CommandingPresence, TalentTypes.Kingpin, TalentTypes.SavantLaw, TalentTypes.Wealthy } }
        };
    }
}

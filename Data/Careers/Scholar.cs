using System;
using System.Collections.Generic;

namespace WfrpChars.Data.Careers
{
    class Scholar : CareerBase
    {
        public Scholar(int level) : base(level) { }

        public override string Name => "Scholar";

        public override string Path => Level switch
        {
            1 => "Student",
            2 => "Scholar",
            3 => "Fellow",
            4 => "Professor",
            _ => throw new Exception("No such Level")
        };

        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Brass;
        public override int Dexterity => Bonus * Gold;
        public override int Intelligence => Bonus * Level;
        public override int Willpower => Bonus * Level;
        public override int Fellowship => Bonus * Silver;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.ConsumeAlcohol, SkillType.EntertainStorytelling, SkillType.Gamble, SkillType.Gossip, SkillType.Haggle, SkillType.LanguageClassical, SkillType.LoreAny, SkillType.Research } },
            { 2, new List<SkillType> { SkillType.ArtWriting, SkillType.Intuition, SkillType.LanguageAny, SkillType.LoreAny, SkillType.Perception, SkillType.TradeAny } },
            { 3, new List<SkillType> { SkillType.EntertainLecture, SkillType.Intimidate, SkillType.LanguageAny, SkillType.LoreAny } },
            { 4, new List<SkillType> { SkillType.EntertainRhetoric, SkillType.LoreAny } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.Carouser, TalentType.ReadWrite, TalentType.Savvy, TalentType.SuperNumerate } },
            { 2, new List<TalentType> { TalentType.Bookish, TalentType.EtiquetteScholar, TalentType.Speedreader, TalentType.Suave } },
            { 3, new List<TalentType> { TalentType.Linguistics, TalentType.PublicSpeaker, TalentType.SavantAny, TalentType.TowerOfMemories } },
            { 4, new List<TalentType> { TalentType.MagnumOpus, TalentType.MasterOrator, TalentType.SavantAny, TalentType.Sharp } }
        };
    }
}

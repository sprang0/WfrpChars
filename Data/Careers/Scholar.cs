using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.ConsumeAlcohol, SkillTypes.EntertainStorytelling, SkillTypes.Gamble, SkillTypes.Gossip, SkillTypes.Haggle, SkillTypes.LanguageClassical, SkillTypes.LoreAny, SkillTypes.Research } },
            { 2, new List<SkillTypes> { SkillTypes.ArtWriting, SkillTypes.Intuition, SkillTypes.LanguageAny, SkillTypes.LoreAny, SkillTypes.Perception, SkillTypes.TradeAny } },
            { 3, new List<SkillTypes> { SkillTypes.EntertainLecture, SkillTypes.Intimidate, SkillTypes.LanguageAny, SkillTypes.LoreAny } },
            { 4, new List<SkillTypes> { SkillTypes.EntertainRhetoric, SkillTypes.LoreAny } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.Carouser, TalentTypes.ReadWrite, TalentTypes.Savvy, TalentTypes.SuperNumerate } },
            { 2, new List<TalentTypes> { TalentTypes.Bookish, TalentTypes.EtiquetteScholar, TalentTypes.Speedreader, TalentTypes.Suave } },
            { 3, new List<TalentTypes> { TalentTypes.Linguistics, TalentTypes.PublicSpeaker, TalentTypes.SavantAny, TalentTypes.TowerOfMemories } },
            { 4, new List<TalentTypes> { TalentTypes.MagnumOpus, TalentTypes.MasterOrator, TalentTypes.SavantAny, TalentTypes.Sharp } }
        };
    }
}

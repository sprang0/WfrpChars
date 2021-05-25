using System;
using System.Collections.Generic;

namespace WfrpChars.Data.Careers
{
    class Engineer : CareerBase
    {
        public Engineer(int level) : base(level) { }

        public override string Name => "Engineer";

        public override string Path => Level switch
        {
            1 => "Student Engineer",
            2 => "Engineer",
            3 => "Master Engineer",
            4 => "Chartered Engineer",
            _ => throw new Exception("No such Level")
        };

        public override int BallisticSkill => Bonus * Level;
        public override int Toughness => Bonus * Silver;
        public override int Initiative => Bonus * Brass;
        public override int Dexterity => Bonus * Level;
        public override int Intelligence => Bonus * Level;
        public override int Willpower => Bonus * Gold;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.ConsumeAlcohol, SkillType.Cool, SkillType.Endurance, SkillType.LanguageClassical, SkillType.LoreEngineer, SkillType.Perception, SkillType.RangedBlackpowder, SkillType.TradeEngineer } },
            { 2, new List<SkillType> { SkillType.Drive, SkillType.Dodge, SkillType.Navigation, SkillType.RangedEngineering, SkillType.Research, SkillType.LanguageGuilder } },
            { 3, new List<SkillType> { SkillType.LanguageKhazalid, SkillType.Leadership, SkillType.RideHorse, SkillType.SecretSignsGuilder } },
            { 4, new List<SkillType> { SkillType.LanguageAny, SkillType.LoreAny } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.Artistic, TalentType.Gunner, TalentType.ReadWrite, TalentType.Tinker } },
            { 2, new List<TalentType> { TalentType.CraftsmanEngineer, TalentType.EtiquetteGuilder, TalentType.Marksman, TalentType.Orientation } },
            { 3, new List<TalentType> { TalentType.EtiquetteScholar, TalentType.MasterTradesmanEngineering, TalentType.Sniper, TalentType.SuperNumerate } },
            { 4, new List<TalentType> { TalentType.MagnumOpus, TalentType.RapidReload, TalentType.SavantEngineering, TalentType.Unshakeable } }
        };
    }
}

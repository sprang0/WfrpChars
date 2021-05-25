using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.ConsumeAlcohol, SkillTypes.Cool, SkillTypes.Endurance, SkillTypes.LanguageClassical, SkillTypes.LoreEngineer, SkillTypes.Perception, SkillTypes.RangedBlackpowder, SkillTypes.TradeEngineer } },
            { 2, new List<SkillTypes> { SkillTypes.Drive, SkillTypes.Dodge, SkillTypes.Navigation, SkillTypes.RangedEngineering, SkillTypes.Research, SkillTypes.LanguageGuilder } },
            { 3, new List<SkillTypes> { SkillTypes.LanguageKhazalid, SkillTypes.Leadership, SkillTypes.RideHorse, SkillTypes.SecretSignsGuilder } },
            { 4, new List<SkillTypes> { SkillTypes.LanguageAny, SkillTypes.LoreAny } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.Artistic, TalentTypes.Gunner, TalentTypes.ReadWrite, TalentTypes.Tinker } },
            { 2, new List<TalentTypes> { TalentTypes.CraftsmanEngineer, TalentTypes.EtiquetteGuilder, TalentTypes.Marksman, TalentTypes.Orientation } },
            { 3, new List<TalentTypes> { TalentTypes.EtiquetteScholar, TalentTypes.MasterTradesmanEngineering, TalentTypes.Sniper, TalentTypes.SuperNumerate } },
            { 4, new List<TalentTypes> { TalentTypes.MagnumOpus, TalentTypes.RapidReload, TalentTypes.SavantEngineering, TalentTypes.Unshakeable } }
        };
    }
}

using System;
using System.Collections.Generic;

namespace WfrpChars.Data.Careers
{
    class HedgeWitch : CareerBase
    {
        public HedgeWitch(int level) : base(level) { }

        public override string Name => "Hedge Witch";

        public override string Path => Level switch
        {
            1 => "Hedge Apprentice",
            2 => "Hedge Witch",
            3 => "Hedge Master",
            4 => "Hedgewise",
            _ => throw new Exception("No such Level")
        };

        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Level;
        public override int Dexterity => Bonus * Level;
        public override int Intelligence => Bonus * Brass;
        public override int Willpower => Bonus * Gold;
        public override int Fellowship => Bonus * Silver;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Channelling, SkillType.Endurance, SkillType.Intuition, SkillType.LanguageMagick, SkillType.LoreFolklore, SkillType.LoreHerbs, SkillType.OutdoorSurvival, SkillType.Perception } },
            { 2, new List<SkillType> { SkillType.Cool, SkillType.Gossip, SkillType.Heal, SkillType.LoreLocal, SkillType.TradeCharms, SkillType.TradeHerbalist } },
            { 3, new List<SkillType> { SkillType.Haggle, SkillType.LoreGenealogy, SkillType.LoreMagic, SkillType.LoreSpirits } },
            { 4, new List<SkillType> { SkillType.Intimidate, SkillType.Pray } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.FastHands, TalentType.PettyMagic, TalentType.Rover, TalentType.StriderWoodlands } },
            { 2, new List<TalentType> { TalentType.AethyricAttunement, TalentType.AnimalAffinity, TalentType.MagicHedgecraft, TalentType.SixthSense } },
            { 3, new List<TalentType> { TalentType.CraftsmanHerbalist, TalentType.MagicalSense, TalentType.PureSoul, TalentType.ResistanceDisease } },
            { 4, new List<TalentType> { TalentType.AcuteSenseAny, TalentType.MasterCraftsmanHerbalist, TalentType.NightVision, TalentType.StrongMinded } }
        };
    }
}

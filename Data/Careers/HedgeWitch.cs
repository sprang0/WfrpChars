using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Channelling, SkillTypes.Endurance, SkillTypes.Intuition, SkillTypes.LanguageMagick, SkillTypes.LoreFolklore, SkillTypes.LoreHerbs, SkillTypes.OutdoorSurvival, SkillTypes.Perception } },
            { 2, new List<SkillTypes> { SkillTypes.Cool, SkillTypes.Gossip, SkillTypes.Heal, SkillTypes.LoreLocal, SkillTypes.TradeCharms, SkillTypes.TradeHerbalist } },
            { 3, new List<SkillTypes> { SkillTypes.Haggle, SkillTypes.LoreGenealogy, SkillTypes.LoreMagic, SkillTypes.LoreSpirits } },
            { 4, new List<SkillTypes> { SkillTypes.Intimidate, SkillTypes.Pray } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.FastHands, TalentTypes.PettyMagic, TalentTypes.Rover, TalentTypes.StriderWoodlands } },
            { 2, new List<TalentTypes> { TalentTypes.AethyricAttunement, TalentTypes.AnimalAffinity, TalentTypes.MagicHedgecraft, TalentTypes.SixthSense } },
            { 3, new List<TalentTypes> { TalentTypes.CraftsmanHerbalist, TalentTypes.MagicalSense, TalentTypes.PureSoul, TalentTypes.ResistanceDisease } },
            { 4, new List<TalentTypes> { TalentTypes.AcuteSenseAny, TalentTypes.MasterCraftsmanHerbalist, TalentTypes.NightVision, TalentTypes.StrongMinded } }
        };
    }
}

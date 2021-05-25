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

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Channelling, Types.Skills.Endurance, Types.Skills.Intuition, Types.Skills.LanguageMagick, Types.Skills.LoreFolklore, Types.Skills.LoreHerbs, Types.Skills.OutdoorSurvival, Types.Skills.Perception } },
            { 2, new List<Skills> { Types.Skills.Cool, Types.Skills.Gossip, Types.Skills.Heal, Types.Skills.LoreLocal, Types.Skills.TradeCharms, Types.Skills.TradeHerbalist } },
            { 3, new List<Skills> { Types.Skills.Haggle, Types.Skills.LoreGenealogy, Types.Skills.LoreMagic, Types.Skills.LoreSpirits } },
            { 4, new List<Skills> { Types.Skills.Intimidate, Types.Skills.Pray } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.FastHands, Types.Talents.PettyMagic, Types.Talents.Rover, Types.Talents.StriderWoodlands } },
            { 2, new List<Talents> { Types.Talents.AethyricAttunement, Types.Talents.AnimalAffinity, Types.Talents.MagicHedgecraft, Types.Talents.SixthSense } },
            { 3, new List<Talents> { Types.Talents.CraftsmanHerbalist, Types.Talents.MagicalSense, Types.Talents.PureSoul, Types.Talents.ResistanceDisease } },
            { 4, new List<Talents> { Types.Talents.AcuteSenseAny, Types.Talents.MasterCraftsmanHerbalist, Types.Talents.NightVision, Types.Talents.StrongMinded } }
        };
    }
}

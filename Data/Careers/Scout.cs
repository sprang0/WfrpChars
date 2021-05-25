using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Scout : CareerBase
    {
        public Scout(int level) : base(level) { }

        public override string Name => "Scout";

        public override string Path => Level switch
        {
            1 => "Guide",
            2 => "Scout",
            3 => "Pathfinder",
            4 => "Explorer",
            _ => throw new Exception("No such Level")
        };

        public override int BallisticSkill => Bonus * Brass;
        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Level;
        public override int Agility => Bonus * Level;
        public override int Dexterity => Bonus * Gold;
        public override int Intelligence => Bonus * Silver;

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.CharmAnimal, SkillTypes.Climb, SkillTypes.Endurance, SkillTypes.Gossip, SkillTypes.LoreLocal, SkillTypes.MeleeBasic, SkillTypes.OutdoorSurvival, SkillTypes.Perception } },
            { 2, new List<SkillTypes> { SkillTypes.Athletics, SkillTypes.Navigation, SkillTypes.RangedBow, SkillTypes.RideHorse, SkillTypes.StealthRural, SkillTypes.Track } },
            { 3, new List<SkillTypes> { SkillTypes.AnimalCare, SkillTypes.Haggle, SkillTypes.SecretSignsHunter, SkillTypes.Swim } },
            { 4, new List<SkillTypes> { SkillTypes.LanguageAny, SkillTypes.TradeCartographer } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.Orientation, TalentTypes.Rover, TalentTypes.Sharp, TalentTypes.StriderAny } },
            { 2, new List<TalentTypes> { TalentTypes.CombatAware, TalentTypes.NightVision, TalentTypes.NoseForTrouble, TalentTypes.SeasonedTraveler } },
            { 3, new List<TalentTypes> { TalentTypes.AcuteSenseSight, TalentTypes.SixthSense, TalentTypes.StrongLegs, TalentTypes.VeryResilient } },
            { 4, new List<TalentTypes> { TalentTypes.Hardy, TalentTypes.Linguistics, TalentTypes.SavantLocal, TalentTypes.Tenacious } }
        };
    }
}

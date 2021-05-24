using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.CharmAnimal, SkillType.Climb, SkillType.Endurance, SkillType.Gossip, SkillType.LoreLocal, SkillType.MeleeBasic, SkillType.OutdoorSurvival, SkillType.Perception } },
            { 2, new List<SkillType> { SkillType.Athletics, SkillType.Navigation, SkillType.RangedBow, SkillType.RideHorse, SkillType.StealthRural, SkillType.Track } },
            { 3, new List<SkillType> { SkillType.AnimalCare, SkillType.Haggle, SkillType.SecretSignsHunter, SkillType.Swim } },
            { 4, new List<SkillType> { SkillType.LanguageAny, SkillType.TradeCartographer } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.Orientation, TalentType.Rover, TalentType.Sharp, TalentType.StriderAny } },
            { 2, new List<TalentType> { TalentType.CombatAware, TalentType.NightVision, TalentType.NoseForTrouble, TalentType.SeasonedTraveler } },
            { 3, new List<TalentType> { TalentType.AcuteSenseSight, TalentType.SixthSense, TalentType.StrongLegs, TalentType.VeryResilient } },
            { 4, new List<TalentType> { TalentType.Hardy, TalentType.Linguistics, TalentType.SavantLocal, TalentType.Tenacious } }
        };
    }
}

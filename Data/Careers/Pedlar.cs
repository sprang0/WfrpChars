using System;
using System.Collections.Generic;

namespace WfrpChars.Data.Careers
{
    class Pedlar : CareerBase
    {
        public Pedlar(int level) : base(level) { }

        public override string Name => "Pedlar";

        public override string Path => Level switch
        {
            1 => "Vagabond",
            2 => "Pedlar",
            3 => "Master Pedlar",
            4 => "Wandering Trader",
            _ => throw new Exception("No such Level")
        };

        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Silver;
        public override int Dexterity => Bonus * Level;
        public override int Intelligence => Bonus * Gold;
        public override int Willpower => Bonus * Level;
        public override int Fellowship => Bonus * Brass;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Charm, SkillType.Endurance, SkillType.EntertainStorytelling, SkillType.Gossip, SkillType.Haggle, SkillType.Intuition, SkillType.OutdoorSurvival, SkillType.StealthRuralOrUrban } },
            { 2, new List<SkillType> { SkillType.AnimalCare, SkillType.CharmAnimal, SkillType.ConsumeAlcohol, SkillType.Evaluate, SkillType.RideHorse, SkillType.TradeTinker } },
            { 3, new List<SkillType> { SkillType.Drive, SkillType.Intimidate, SkillType.LanguageAny, SkillType.Perception } },
            { 4, new List<SkillType> { SkillType.LoreLocal, SkillType.LoreGeography } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.Fisherman, TalentType.Flee, TalentType.Rover, TalentType.Tinker } },
            { 2, new List<TalentType> { TalentType.Dealmaker, TalentType.Orientation, TalentType.SeasonedTraveler, TalentType.StrongBack } },
            { 3, new List<TalentType> { TalentType.Numismatics, TalentType.Sturdy, TalentType.WellPrepared, TalentType.VeryResilient } },
            { 4, new List<TalentType> { TalentType.CatTongued, TalentType.StrongMinded, TalentType.Suave, TalentType.Tenacious } }
        };
    }
}

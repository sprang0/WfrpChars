using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Charm, SkillTypes.Endurance, SkillTypes.EntertainStorytelling, SkillTypes.Gossip, SkillTypes.Haggle, SkillTypes.Intuition, SkillTypes.OutdoorSurvival, SkillTypes.StealthRuralOrUrban } },
            { 2, new List<SkillTypes> { SkillTypes.AnimalCare, SkillTypes.CharmAnimal, SkillTypes.ConsumeAlcohol, SkillTypes.Evaluate, SkillTypes.RideHorse, SkillTypes.TradeTinker } },
            { 3, new List<SkillTypes> { SkillTypes.Drive, SkillTypes.Intimidate, SkillTypes.LanguageAny, SkillTypes.Perception } },
            { 4, new List<SkillTypes> { SkillTypes.LoreLocal, SkillTypes.LoreGeography } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.Fisherman, TalentTypes.Flee, TalentTypes.Rover, TalentTypes.Tinker } },
            { 2, new List<TalentTypes> { TalentTypes.Dealmaker, TalentTypes.Orientation, TalentTypes.SeasonedTraveler, TalentTypes.StrongBack } },
            { 3, new List<TalentTypes> { TalentTypes.Numismatics, TalentTypes.Sturdy, TalentTypes.WellPrepared, TalentTypes.VeryResilient } },
            { 4, new List<TalentTypes> { TalentTypes.CatTongued, TalentTypes.StrongMinded, TalentTypes.Suave, TalentTypes.Tenacious } }
        };
    }
}

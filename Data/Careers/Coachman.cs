using System;
using System.Collections.Generic;

namespace WfrpChars.Data.Careers
{
    class Coachman : CareerBase
    {
        public Coachman(int level) : base(level) { }

        public override string Name => "Coachman";

        public override string Path => Level switch
        {
            1 => "Postilion",
            2 => "Coachman",
            3 => "Coach Master",
            4 => "Route Master",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Silver;
        public override int BallisticSkill => Bonus * Level;
        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Gold;
        public override int Agility => Bonus * Brass;
        public override int Willpower => Bonus * Level;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.AnimalCare, SkillType.Charm, SkillType.Climb, SkillType.Drive, SkillType.Endurance, SkillType.Perception, SkillType.RangedEntangling, SkillType.RideHorse } },
            { 2, new List<SkillType> { SkillType.ConsumeAlcohol, SkillType.Gossip, SkillType.Intuition, SkillType.LoreLocal, SkillType.Navigation, SkillType.RangedBlackpowder } },
            { 3, new List<SkillType> { SkillType.AnimalTrainingHorse, SkillType.Intimidate, SkillType.LanguageAny, SkillType.LoreRoutes } },
            { 4, new List<SkillType> { SkillType.Charm, SkillType.Leadership } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.AnimalAffinity, TalentType.SeasonedTraveler, TalentType.TrickRiding, TalentType.Tenacious } },
            { 2, new List<TalentType> { TalentType.Coolheaded, TalentType.CrackTheWhip, TalentType.Gunner, TalentType.StrongMinded } },
            { 3, new List<TalentType> { TalentType.AccurateShot, TalentType.Dealmaker, TalentType.FearlessOutlaws, TalentType.NoseForTrouble } },
            { 4, new List<TalentType> { TalentType.FearlessBeastmen, TalentType.Marksman, TalentType.Orientation, TalentType.RapidReload } }
        };
    }
}

using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.AnimalCare, SkillTypes.Charm, SkillTypes.Climb, SkillTypes.Drive, SkillTypes.Endurance, SkillTypes.Perception, SkillTypes.RangedEntangling, SkillTypes.RideHorse } },
            { 2, new List<SkillTypes> { SkillTypes.ConsumeAlcohol, SkillTypes.Gossip, SkillTypes.Intuition, SkillTypes.LoreLocal, SkillTypes.Navigation, SkillTypes.RangedBlackpowder } },
            { 3, new List<SkillTypes> { SkillTypes.AnimalTrainingHorse, SkillTypes.Intimidate, SkillTypes.LanguageAny, SkillTypes.LoreRoutes } },
            { 4, new List<SkillTypes> { SkillTypes.Charm, SkillTypes.Leadership } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.AnimalAffinity, TalentTypes.SeasonedTraveler, TalentTypes.TrickRiding, TalentTypes.Tenacious } },
            { 2, new List<TalentTypes> { TalentTypes.Coolheaded, TalentTypes.CrackTheWhip, TalentTypes.Gunner, TalentTypes.StrongMinded } },
            { 3, new List<TalentTypes> { TalentTypes.AccurateShot, TalentTypes.Dealmaker, TalentTypes.FearlessOutlaws, TalentTypes.NoseForTrouble } },
            { 4, new List<TalentTypes> { TalentTypes.FearlessBeastmen, TalentTypes.Marksman, TalentTypes.Orientation, TalentTypes.RapidReload } }
        };
    }
}

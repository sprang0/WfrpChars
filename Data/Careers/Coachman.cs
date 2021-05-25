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

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.AnimalCare, Types.Skills.Charm, Types.Skills.Climb, Types.Skills.Drive, Types.Skills.Endurance, Types.Skills.Perception, Types.Skills.RangedEntangling, Types.Skills.RideHorse } },
            { 2, new List<Skills> { Types.Skills.ConsumeAlcohol, Types.Skills.Gossip, Types.Skills.Intuition, Types.Skills.LoreLocal, Types.Skills.Navigation, Types.Skills.RangedBlackpowder } },
            { 3, new List<Skills> { Types.Skills.AnimalTrainingHorse, Types.Skills.Intimidate, Types.Skills.LanguageAny, Types.Skills.LoreRoutes } },
            { 4, new List<Skills> { Types.Skills.Charm, Types.Skills.Leadership } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.AnimalAffinity, Types.Talents.SeasonedTraveler, Types.Talents.TrickRiding, Types.Talents.Tenacious } },
            { 2, new List<Talents> { Types.Talents.Coolheaded, Types.Talents.CrackTheWhip, Types.Talents.Gunner, Types.Talents.StrongMinded } },
            { 3, new List<Talents> { Types.Talents.AccurateShot, Types.Talents.Dealmaker, Types.Talents.FearlessOutlaws, Types.Talents.NoseForTrouble } },
            { 4, new List<Talents> { Types.Talents.FearlessBeastmen, Types.Talents.Marksman, Types.Talents.Orientation, Types.Talents.RapidReload } }
        };
    }
}

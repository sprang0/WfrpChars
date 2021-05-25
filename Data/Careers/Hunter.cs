using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Hunter : CareerBase
    {
        public Hunter(int level) : base(level) { }

        public override string Name => "Hunter";

        public override string Path => Level switch
        {
            1 => "Trapper",
            2 => "Hunter",
            3 => "Tracker",
            4 => "Huntsmaster",
            _ => throw new Exception("No such Level")
        };

        public override int BallisticSkill => Bonus * Brass;
        public override int Strength => Bonus * Level;
        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Silver;
        public override int Dexterity => Bonus * Level;
        public override int Intelligence => Bonus * Gold;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.CharmAnimal, Types.Skills.Climb, Types.Skills.Endurance, Types.Skills.LoreBeasts, Types.Skills.OutdoorSurvival, Types.Skills.Perception, Types.Skills.RangedSling, Types.Skills.SetTrap } },
            { 2, new List<Skills> { Types.Skills.Cool, Types.Skills.Intuition, Types.Skills.MeleeBasic, Types.Skills.RangedBow, Types.Skills.SecretSignsHunter, Types.Skills.StealthRural } },
            { 3, new List<Skills> { Types.Skills.Navigation, Types.Skills.RideHorse, Types.Skills.Swim, Types.Skills.Track } },
            { 4, new List<Skills> { Types.Skills.AnimalCare, Types.Skills.AnimalTrainingAny } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.Hardy, Types.Talents.Rover, Types.Talents.StriderAny, Types.Talents.Trapper } },
            { 2, new List<Talents> { Types.Talents.AccurateShot, Types.Talents.FastShot, Types.Talents.HuntersEye, Types.Talents.Marksman } },
            { 3, new List<Talents> { Types.Talents.AcuteSenseAny, Types.Talents.DeadeyeShot, Types.Talents.FearlessAnimals, Types.Talents.Sharpshooter } },
            { 4, new List<Talents> { Types.Talents.FearlessMonsters, Types.Talents.Robust, Types.Talents.Sniper, Types.Talents.SureShot } }
        };
    }
}

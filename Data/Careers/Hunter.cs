using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WfrpChars.Data.Careers
{
    class Hunter : CareerBase
    {
        public Hunter(int level) : base(level)        {        }

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

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.CharmAnimal, SkillType.Climb, SkillType.Endurance, SkillType.LoreBeasts, SkillType.OutdoorSurvival, SkillType.Perception, SkillType.RangedSling, SkillType.SetTrap } },
            { 2, new List<SkillType> { SkillType.Cool, SkillType.Intuition, SkillType.MeleeBasic, SkillType.RangedBow, SkillType.SecretSignsHunter, SkillType.StealthRural } },
            { 3, new List<SkillType> { SkillType.Navigation, SkillType.RideHorse, SkillType.Swim, SkillType.Track } },
            { 4, new List<SkillType> { SkillType.AnimalCare, SkillType.AnimalTrainingAny } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.Hardy, TalentType.Rover, TalentType.StriderAny, TalentType.Trapper } },
            { 2, new List<TalentType> { TalentType.AccurateShot, TalentType.FastShot, TalentType.HuntersEye, TalentType.Marksman } },
            { 3, new List<TalentType> { TalentType.AcuteSenseAny, TalentType.DeadeyeShot, TalentType.FearlessAnimals, TalentType.Sharpshooter } },
            { 4, new List<TalentType> { TalentType.FearlessMonsters, TalentType.Robust, TalentType.Sniper, TalentType.SureShot } }
        };
    }
}

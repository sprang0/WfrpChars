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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.CharmAnimal, SkillTypes.Climb, SkillTypes.Endurance, SkillTypes.LoreBeasts, SkillTypes.OutdoorSurvival, SkillTypes.Perception, SkillTypes.RangedSling, SkillTypes.SetTrap } },
            { 2, new List<SkillTypes> { SkillTypes.Cool, SkillTypes.Intuition, SkillTypes.MeleeBasic, SkillTypes.RangedBow, SkillTypes.SecretSignsHunter, SkillTypes.StealthRural } },
            { 3, new List<SkillTypes> { SkillTypes.Navigation, SkillTypes.RideHorse, SkillTypes.Swim, SkillTypes.Track } },
            { 4, new List<SkillTypes> { SkillTypes.AnimalCare, SkillTypes.AnimalTrainingAny } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.Hardy, TalentTypes.Rover, TalentTypes.StriderAny, TalentTypes.Trapper } },
            { 2, new List<TalentTypes> { TalentTypes.AccurateShot, TalentTypes.FastShot, TalentTypes.HuntersEye, TalentTypes.Marksman } },
            { 3, new List<TalentTypes> { TalentTypes.AcuteSenseAny, TalentTypes.DeadeyeShot, TalentTypes.FearlessAnimals, TalentTypes.Sharpshooter } },
            { 4, new List<TalentTypes> { TalentTypes.FearlessMonsters, TalentTypes.Robust, TalentTypes.Sniper, TalentTypes.SureShot } }
        };
    }
}

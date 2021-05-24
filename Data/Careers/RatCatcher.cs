using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WfrpChars.Data.Careers
{
    class RatCatcher : CareerBase
    {
        public RatCatcher(int level) : base(level) { }

        public override string Name => "Rat Catcher";

        public override string Path => Level switch
        {
            1 => "Rat Hunter",
            2 => "Rat Catcher",
            3 => "Sewer Jack",
            4 => "Exterminator",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Level;
        public override int BallisticSkill => Bonus * Level;
        public override int Strength => Bonus * Gold;
        public override int Toughness => Bonus * Brass;
        public override int Initiative => Bonus * Silver;
        public override int Willpower => Bonus * Level;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Athletics, SkillType.AnimalTrainingDog, SkillType.CharmAnimal, SkillType.ConsumeAlcohol, SkillType.Endurance, SkillType.MeleeBasic, SkillType.RangedSling } },
            { 2, new List<SkillType> { SkillType.AnimalCare, SkillType.Gossip, SkillType.Haggle, SkillType.LorePoison, SkillType.Perception, SkillType.SetTrap } },
            { 3, new List<SkillType> { SkillType.Climb, SkillType.Cool, SkillType.Dodge, SkillType.RangedCrossbowPistol } },
            { 4, new List<SkillType> { SkillType.Leadership, SkillType.Track } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.NightVision, TalentType.ResistanceDisease, TalentType.StrikeMightyBlow, TalentType.StrikeToStun } },
            { 2, new List<TalentType> { TalentType.EnclosedFighter, TalentType.EtiquetteGuilder, TalentType.FearlessRats, TalentType.VeryResilient } },
            { 3, new List<TalentType> { TalentType.Hardy, TalentType.StoutHearted, TalentType.StrongLegs, TalentType.TunnelRat } },
            { 4, new List<TalentType> { TalentType.FearlessSkaven, TalentType.Menacing, TalentType.Robust, TalentType.StrongMinded } }
        };
    }
}

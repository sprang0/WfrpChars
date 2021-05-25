using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Athletics, SkillTypes.AnimalTrainingDog, SkillTypes.CharmAnimal, SkillTypes.ConsumeAlcohol, SkillTypes.Endurance, SkillTypes.MeleeBasic, SkillTypes.RangedSling } },
            { 2, new List<SkillTypes> { SkillTypes.AnimalCare, SkillTypes.Gossip, SkillTypes.Haggle, SkillTypes.LorePoison, SkillTypes.Perception, SkillTypes.SetTrap } },
            { 3, new List<SkillTypes> { SkillTypes.Climb, SkillTypes.Cool, SkillTypes.Dodge, SkillTypes.RangedCrossbowPistol } },
            { 4, new List<SkillTypes> { SkillTypes.Leadership, SkillTypes.Track } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.NightVision, TalentTypes.ResistanceDisease, TalentTypes.StrikeMightyBlow, TalentTypes.StrikeToStun } },
            { 2, new List<TalentTypes> { TalentTypes.EnclosedFighter, TalentTypes.EtiquetteGuilder, TalentTypes.FearlessRats, TalentTypes.VeryResilient } },
            { 3, new List<TalentTypes> { TalentTypes.Hardy, TalentTypes.StoutHearted, TalentTypes.StrongLegs, TalentTypes.TunnelRat } },
            { 4, new List<TalentTypes> { TalentTypes.FearlessSkaven, TalentTypes.Menacing, TalentTypes.Robust, TalentTypes.StrongMinded } }
        };
    }
}

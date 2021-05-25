using System;
using System.Collections.Generic;

namespace WfrpChars.Data.Careers
{
    class Warden : CareerBase
    {
        public Warden(int level) : base(level) { }

        public override string Name => "Warden";

        public override string Path => Level switch
        {
            1 => "Custodian",
            2 => "Warden",
            3 => "Seneschal",
            4 => "Governor",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Brass;
        public override int Strength => Bonus * Level;
        public override int Toughness => Bonus * Level;
        public override int Intelligence => Bonus * Gold;
        public override int Willpower => Bonus * Level;
        public override int Fellowship => Bonus * Silver;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Athletics, SkillType.CharmAnimal, SkillType.ConsumeAlcohol, SkillType.Cool, SkillType.Endurance, SkillType.Intuition, SkillType.LoreLocal, SkillType.Perception } },
            { 2, new List<SkillType> { SkillType.AnimalCare, SkillType.MeleeBasic, SkillType.OutdoorSurvival, SkillType.RangedBow, SkillType.RideHorse, SkillType.Swim } },
            { 3, new List<SkillType> { SkillType.Bribery, SkillType.Charm, SkillType.Gossip, SkillType.Leadership } },
            { 4, new List<SkillType> { SkillType.Evaluate, SkillType.LanguageAny } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.Menacing, TalentType.NightVision, TalentType.Sharp, TalentType.StrikeToStun } },
            { 2, new List<TalentType> { TalentType.AnimalAffinity, TalentType.EtiquetteServants, TalentType.StriderAny, TalentType.Rover } },
            { 3, new List<TalentType> { TalentType.Embezzle, TalentType.Numismatics, TalentType.ReadWrite, TalentType.Supportive } },
            { 4, new List<TalentType> { TalentType.CommandingPresence, TalentType.EtiquetteAny, TalentType.SavantLocal, TalentType.Suave } }
        };
    }
}

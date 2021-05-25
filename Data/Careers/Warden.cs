using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Athletics, SkillTypes.CharmAnimal, SkillTypes.ConsumeAlcohol, SkillTypes.Cool, SkillTypes.Endurance, SkillTypes.Intuition, SkillTypes.LoreLocal, SkillTypes.Perception } },
            { 2, new List<SkillTypes> { SkillTypes.AnimalCare, SkillTypes.MeleeBasic, SkillTypes.OutdoorSurvival, SkillTypes.RangedBow, SkillTypes.RideHorse, SkillTypes.Swim } },
            { 3, new List<SkillTypes> { SkillTypes.Bribery, SkillTypes.Charm, SkillTypes.Gossip, SkillTypes.Leadership } },
            { 4, new List<SkillTypes> { SkillTypes.Evaluate, SkillTypes.LanguageAny } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.Menacing, TalentTypes.NightVision, TalentTypes.Sharp, TalentTypes.StrikeToStun } },
            { 2, new List<TalentTypes> { TalentTypes.AnimalAffinity, TalentTypes.EtiquetteServants, TalentTypes.StriderAny, TalentTypes.Rover } },
            { 3, new List<TalentTypes> { TalentTypes.Embezzle, TalentTypes.Numismatics, TalentTypes.ReadWrite, TalentTypes.Supportive } },
            { 4, new List<TalentTypes> { TalentTypes.CommandingPresence, TalentTypes.EtiquetteAny, TalentTypes.SavantLocal, TalentTypes.Suave } }
        };
    }
}

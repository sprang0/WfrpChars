using System;
using System.Collections.Generic;

namespace WfrpChars.Data.Careers
{
    class WarriorPriest : CareerBase
    {
        public WarriorPriest(int level) : base(level) { }

        public override string Name => "Warrior Priest";

        public override string Path => Level switch
        {
            1 => "Novitiate",
            2 => "Warrior Priest",
            3 => "Priest Sergeant",
            4 => "Priest Captain",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Level;
        public override int Strength => Bonus * Brass;
        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Silver;
        public override int Willpower => Bonus * Level;
        public override int Fellowship => Bonus * Gold;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Cool, SkillType.Dodge, SkillType.Endurance, SkillType.Heal, SkillType.Leadership, SkillType.LoreTheology, SkillType.MeleeAny, SkillType.Pray } },
            { 2, new List<SkillType> { SkillType.Charm, SkillType.EntertainSpeeches, SkillType.Intimidate, SkillType.LanguageBattle, SkillType.MeleeAny, SkillType.RangedAny } },
            { 3, new List<SkillType> { SkillType.AnimalCare, SkillType.Intuition, SkillType.Perception, SkillType.RideHorse } },
            { 4, new List<SkillType> { SkillType.ConsumeAlcohol, SkillType.LoreWarfare } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.BlessAny, TalentType.EtiquetteCultists, TalentType.ReadWrite, TalentType.StrongMinded } },
            { 2, new List<TalentType> { TalentType.DualWielder, TalentType.Inspiring, TalentType.InvokeAny, TalentType.SeasonedTraveler } },
            { 3, new List<TalentType> { TalentType.CombatAware, TalentType.HolyVisions, TalentType.PureSoul, TalentType.StoutHearted } },
            { 4, new List<TalentType> { TalentType.FearlessAny, TalentType.FuriousAssault, TalentType.HolyHatred, TalentType.Warleader } }
        };
    }
}

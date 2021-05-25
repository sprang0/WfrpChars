using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Cool, SkillTypes.Dodge, SkillTypes.Endurance, SkillTypes.Heal, SkillTypes.Leadership, SkillTypes.LoreTheology, SkillTypes.MeleeAny, SkillTypes.Pray } },
            { 2, new List<SkillTypes> { SkillTypes.Charm, SkillTypes.EntertainSpeeches, SkillTypes.Intimidate, SkillTypes.LanguageBattle, SkillTypes.MeleeAny, SkillTypes.RangedAny } },
            { 3, new List<SkillTypes> { SkillTypes.AnimalCare, SkillTypes.Intuition, SkillTypes.Perception, SkillTypes.RideHorse } },
            { 4, new List<SkillTypes> { SkillTypes.ConsumeAlcohol, SkillTypes.LoreWarfare } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.BlessAny, TalentTypes.EtiquetteCultists, TalentTypes.ReadWrite, TalentTypes.StrongMinded } },
            { 2, new List<TalentTypes> { TalentTypes.DualWielder, TalentTypes.Inspiring, TalentTypes.InvokeAny, TalentTypes.SeasonedTraveler } },
            { 3, new List<TalentTypes> { TalentTypes.CombatAware, TalentTypes.HolyVisions, TalentTypes.PureSoul, TalentTypes.StoutHearted } },
            { 4, new List<TalentTypes> { TalentTypes.FearlessAny, TalentTypes.FuriousAssault, TalentTypes.HolyHatred, TalentTypes.Warleader } }
        };
    }
}

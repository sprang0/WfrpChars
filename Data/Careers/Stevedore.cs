using System;
using System.Collections.Generic;

namespace WfrpChars.Data.Careers
{
    class Stevedore : CareerBase
    {
        public Stevedore(int level) : base(level) { }

        public override string Name => "Stevedore";

        public override string Path => Level switch
        {
            1 => "Dockhand",
            2 => "Stevedore",
            3 => "Foreman",
            4 => "Dock Master",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Level;
        public override int Strength => Bonus * Brass;
        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Level;
        public override int Intelligence => Bonus * Gold;
        public override int Willpower => Bonus * Silver;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Athletics, SkillType.Climb, SkillType.ConsumeAlcohol, SkillType.Dodge, SkillType.Endurance, SkillType.Gossip, SkillType.MeleeBasic, SkillType.Swim } },
            { 2, new List<SkillType> { SkillType.Bribery, SkillType.EntertainStorytelling, SkillType.Gamble, SkillType.Intimidate, SkillType.Perception, SkillType.StealthUrban } },
            { 3, new List<SkillType> { SkillType.Cool, SkillType.Evaluate, SkillType.Intuition, SkillType.Leadership } },
            { 4, new List<SkillType> { SkillType.Charm, SkillType.LoreTaxes } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.DirtyFighting, TalentType.StrongBack, TalentType.Sturdy, TalentType.VeryStrong } },
            { 2, new List<TalentType> { TalentType.Criminal, TalentType.EtiquetteGuilder, TalentType.StrongLegs, TalentType.Tenacious } },
            { 3, new List<TalentType> { TalentType.Dealmaker, TalentType.Embezzle, TalentType.EtiquetteCriminals, TalentType.PublicSpeaker } },
            { 4, new List<TalentType> { TalentType.Kingpin, TalentType.Menacing, TalentType.Numismatics, TalentType.ReadWrite } }
        };
    }
}

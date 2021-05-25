using System;
using System.Collections.Generic;

namespace WfrpChars.Data.Careers
{
    class Outlaw : CareerBase
    {
        public Outlaw(int level) : base(level) { }

        public override string Name => "Outlaw";

        public override string Path => Level switch
        {
            1 => "Brigand",
            2 => "Outlaw",
            3 => "Outlaw Chief",
            4 => "Bandit King",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Level;
        public override int BallisticSkill => Bonus * Brass;
        public override int Strength => Bonus * Level;
        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Silver;
        public override int Fellowship => Bonus * Gold;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Athletics, SkillType.ConsumeAlcohol, SkillType.Cool, SkillType.Endurance, SkillType.Gamble, SkillType.Intimidate, SkillType.MeleeBasic, SkillType.OutdoorSurvival } },
            { 2, new List<SkillType> { SkillType.Dodge, SkillType.Heal, SkillType.LoreLocal, SkillType.Perception, SkillType.RangedBow, SkillType.StealthRural } },
            { 3, new List<SkillType> { SkillType.Gossip, SkillType.Intuition, SkillType.Leadership, SkillType.RideHorse } },
            { 4, new List<SkillType> { SkillType.Charm, SkillType.LoreEmpire } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.CombatAware, TalentType.Criminal, TalentType.Rover, TalentType.Flee } },
            { 2, new List<TalentType> { TalentType.DirtyFighting, TalentType.Marksman, TalentType.StrikeToStun, TalentType.Trapper } },
            { 3, new List<TalentType> { TalentType.RapidReload, TalentType.Roughrider, TalentType.Menacing, TalentType.VeryResilient } },
            { 4, new List<TalentType> { TalentType.DeadeyeShot, TalentType.FearlessRoadWardens, TalentType.IronWill, TalentType.Robust } }
        };
    }
}

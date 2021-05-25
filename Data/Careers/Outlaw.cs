using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Athletics, SkillTypes.ConsumeAlcohol, SkillTypes.Cool, SkillTypes.Endurance, SkillTypes.Gamble, SkillTypes.Intimidate, SkillTypes.MeleeBasic, SkillTypes.OutdoorSurvival } },
            { 2, new List<SkillTypes> { SkillTypes.Dodge, SkillTypes.Heal, SkillTypes.LoreLocal, SkillTypes.Perception, SkillTypes.RangedBow, SkillTypes.StealthRural } },
            { 3, new List<SkillTypes> { SkillTypes.Gossip, SkillTypes.Intuition, SkillTypes.Leadership, SkillTypes.RideHorse } },
            { 4, new List<SkillTypes> { SkillTypes.Charm, SkillTypes.LoreEmpire } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.CombatAware, TalentTypes.Criminal, TalentTypes.Rover, TalentTypes.Flee } },
            { 2, new List<TalentTypes> { TalentTypes.DirtyFighting, TalentTypes.Marksman, TalentTypes.StrikeToStun, TalentTypes.Trapper } },
            { 3, new List<TalentTypes> { TalentTypes.RapidReload, TalentTypes.Roughrider, TalentTypes.Menacing, TalentTypes.VeryResilient } },
            { 4, new List<TalentTypes> { TalentTypes.DeadeyeShot, TalentTypes.FearlessRoadWardens, TalentTypes.IronWill, TalentTypes.Robust } }
        };
    }
}

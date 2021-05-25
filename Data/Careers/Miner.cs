using System;
using System.Collections.Generic;

namespace WfrpChars.Data.Careers
{
    class Miner : CareerBase
    {
        public Miner(int level) : base(level) { }

        public override string Name => "Miner";

        public override string Path => Level switch
        {
            1 => "Prospector",
            2 => "Miner",
            3 => "Master Miner",
            4 => "Mine Foreman",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Brass;
        public override int Strength => Bonus * Level;
        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Silver;
        public override int Willpower => Bonus * Level;
        public override int Fellowship => Bonus * Gold;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Cool, SkillType.Endurance, SkillType.Intuition, SkillType.LoreLocal, SkillType.MeleeTwoHanded, SkillType.OutdoorSurvival, SkillType.Perception, SkillType.Swim } },
            { 2, new List<SkillType> { SkillType.Climb, SkillType.ConsumeAlcohol, SkillType.Evaluate, SkillType.MeleeBasic, SkillType.SecretSignsMiner, SkillType.TradeExplosives } },
            { 3, new List<SkillType> { SkillType.Gossip, SkillType.LoreGeology, SkillType.StealthUnderground, SkillType.TradeEngineer } },
            { 4, new List<SkillType> { SkillType.Charm, SkillType.Leadership } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.Rover, TalentType.StriderRocky, TalentType.Sturdy, TalentType.Tenacious } },
            { 2, new List<TalentType> { TalentType.NightVision, TalentType.StrikeMightyBlow, TalentType.StrongBack, TalentType.VeryStrong } },
            { 3, new List<TalentType> { TalentType.CarefulStrike, TalentType.CraftsmanExplosives, TalentType.Tinker, TalentType.TunnelRat } },
            { 4, new List<TalentType> { TalentType.Argumentative, TalentType.StrongMinded, TalentType.Embezzle, TalentType.ReadWrite } }
        };
    }
}

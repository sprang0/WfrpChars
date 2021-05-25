using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Cool, SkillTypes.Endurance, SkillTypes.Intuition, SkillTypes.LoreLocal, SkillTypes.MeleeTwoHanded, SkillTypes.OutdoorSurvival, SkillTypes.Perception, SkillTypes.Swim } },
            { 2, new List<SkillTypes> { SkillTypes.Climb, SkillTypes.ConsumeAlcohol, SkillTypes.Evaluate, SkillTypes.MeleeBasic, SkillTypes.SecretSignsMiner, SkillTypes.TradeExplosives } },
            { 3, new List<SkillTypes> { SkillTypes.Gossip, SkillTypes.LoreGeology, SkillTypes.StealthUnderground, SkillTypes.TradeEngineer } },
            { 4, new List<SkillTypes> { SkillTypes.Charm, SkillTypes.Leadership } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.Rover, TalentTypes.StriderRocky, TalentTypes.Sturdy, TalentTypes.Tenacious } },
            { 2, new List<TalentTypes> { TalentTypes.NightVision, TalentTypes.StrikeMightyBlow, TalentTypes.StrongBack, TalentTypes.VeryStrong } },
            { 3, new List<TalentTypes> { TalentTypes.CarefulStrike, TalentTypes.CraftsmanExplosives, TalentTypes.Tinker, TalentTypes.TunnelRat } },
            { 4, new List<TalentTypes> { TalentTypes.Argumentative, TalentTypes.StrongMinded, TalentTypes.Embezzle, TalentTypes.ReadWrite } }
        };
    }
}

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

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Cool, Types.Skills.Endurance, Types.Skills.Intuition, Types.Skills.LoreLocal, Types.Skills.MeleeTwoHanded, Types.Skills.OutdoorSurvival, Types.Skills.Perception, Types.Skills.Swim } },
            { 2, new List<Skills> { Types.Skills.Climb, Types.Skills.ConsumeAlcohol, Types.Skills.Evaluate, Types.Skills.MeleeBasic, Types.Skills.SecretSignsMiner, Types.Skills.TradeExplosives } },
            { 3, new List<Skills> { Types.Skills.Gossip, Types.Skills.LoreGeology, Types.Skills.StealthUnderground, Types.Skills.TradeEngineer } },
            { 4, new List<Skills> { Types.Skills.Charm, Types.Skills.Leadership } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.Rover, Types.Talents.StriderRocky, Types.Talents.Sturdy, Types.Talents.Tenacious } },
            { 2, new List<Talents> { Types.Talents.NightVision, Types.Talents.StrikeMightyBlow, Types.Talents.StrongBack, Types.Talents.VeryStrong } },
            { 3, new List<Talents> { Types.Talents.CarefulStrike, Types.Talents.CraftsmanExplosives, Types.Talents.Tinker, Types.Talents.TunnelRat } },
            { 4, new List<Talents> { Types.Talents.Argumentative, Types.Talents.StrongMinded, Types.Talents.Embezzle, Types.Talents.ReadWrite } }
        };
    }
}

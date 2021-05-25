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

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Athletics, Types.Skills.ConsumeAlcohol, Types.Skills.Cool, Types.Skills.Endurance, Types.Skills.Gamble, Types.Skills.Intimidate, Types.Skills.MeleeBasic, Types.Skills.OutdoorSurvival } },
            { 2, new List<Skills> { Types.Skills.Dodge, Types.Skills.Heal, Types.Skills.LoreLocal, Types.Skills.Perception, Types.Skills.RangedBow, Types.Skills.StealthRural } },
            { 3, new List<Skills> { Types.Skills.Gossip, Types.Skills.Intuition, Types.Skills.Leadership, Types.Skills.RideHorse } },
            { 4, new List<Skills> { Types.Skills.Charm, Types.Skills.LoreEmpire } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.CombatAware, Types.Talents.Criminal, Types.Talents.Rover, Types.Talents.Flee } },
            { 2, new List<Talents> { Types.Talents.DirtyFighting, Types.Talents.Marksman, Types.Talents.StrikeToStun, Types.Talents.Trapper } },
            { 3, new List<Talents> { Types.Talents.RapidReload, Types.Talents.Roughrider, Types.Talents.Menacing, Types.Talents.VeryResilient } },
            { 4, new List<Talents> { Types.Talents.DeadeyeShot, Types.Talents.FearlessRoadWardens, Types.Talents.IronWill, Types.Talents.Robust } }
        };
    }
}

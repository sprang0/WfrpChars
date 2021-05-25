using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Protagonist : CareerBase
    {
        public Protagonist(int level) : base(level) { }

        public override string Name => "Protagonist";

        public override string Path => Level switch
        {
            1 => "Braggart",
            2 => "Protagonist",
            3 => "Hitman",
            4 => "Assassin",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Level;
        public override int BallisticSkill => Bonus * Silver;
        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Brass;
        public override int Agility => Bonus * Level;
        public override int Fellowship => Bonus * Gold;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Athletics, Types.Skills.Dodge, Types.Skills.Endurance, Types.Skills.EntertainTaunt, Types.Skills.Gossip, Types.Skills.Haggle, Types.Skills.Intimidate, Types.Skills.MeleeAny } },
            { 2, new List<Skills> { Types.Skills.Bribery, Types.Skills.Charm, Types.Skills.Intuition, Types.Skills.MeleeBasic, Types.Skills.Perception, Types.Skills.RideHorse } },
            { 3, new List<Skills> { Types.Skills.Climb, Types.Skills.Cool, Types.Skills.Navigation, Types.Skills.RangedThrowing } },
            { 4, new List<Skills> { Types.Skills.EntertainActing, Types.Skills.RangedCrossbow } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.InFighter, Types.Talents.DirtyFighting, Types.Talents.Menacing, Types.Talents.WarriorBorn } },
            { 2, new List<Talents> { Types.Talents.CombatReflexes, Types.Talents.Criminal, Types.Talents.Reversal, Types.Talents.StrikeToStun } },
            { 3, new List<Talents> { Types.Talents.CarefulStrike, Types.Talents.Disarm, Types.Talents.Marksman, Types.Talents.Relentless } },
            { 4, new List<Talents> { Types.Talents.AccurateShot, Types.Talents.Ambidextrous, Types.Talents.FuriousAssault, Types.Talents.StrikeToInjure } }
        };
    }
}

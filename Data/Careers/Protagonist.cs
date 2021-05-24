using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Athletics, SkillType.Dodge, SkillType.Endurance, SkillType.EntertainTaunt, SkillType.Gossip, SkillType.Haggle, SkillType.Intimidate, SkillType.MeleeAny } },
            { 2, new List<SkillType> { SkillType.Bribery, SkillType.Charm, SkillType.Intuition, SkillType.MeleeBasic, SkillType.Perception, SkillType.RideHorse } },
            { 3, new List<SkillType> { SkillType.Climb, SkillType.Cool, SkillType.Navigation, SkillType.RangedThrowing } },
            { 4, new List<SkillType> { SkillType.EntertainActing, SkillType.RangedCrossbow } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.InFighter, TalentType.DirtyFighting, TalentType.Menacing, TalentType.WarriorBorn } },
            { 2, new List<TalentType> { TalentType.CombatReflexes, TalentType.Criminal, TalentType.Reversal, TalentType.StrikeToStun } },
            { 3, new List<TalentType> { TalentType.CarefulStrike, TalentType.Disarm, TalentType.Marksman, TalentType.Relentless } },
            { 4, new List<TalentType> { TalentType.AccurateShot, TalentType.Ambidextrous, TalentType.FuriousAssault, TalentType.StrikeToInjure } }
        };
    }
}

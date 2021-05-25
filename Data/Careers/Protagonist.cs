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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Athletics, SkillTypes.Dodge, SkillTypes.Endurance, SkillTypes.EntertainTaunt, SkillTypes.Gossip, SkillTypes.Haggle, SkillTypes.Intimidate, SkillTypes.MeleeAny } },
            { 2, new List<SkillTypes> { SkillTypes.Bribery, SkillTypes.Charm, SkillTypes.Intuition, SkillTypes.MeleeBasic, SkillTypes.Perception, SkillTypes.RideHorse } },
            { 3, new List<SkillTypes> { SkillTypes.Climb, SkillTypes.Cool, SkillTypes.Navigation, SkillTypes.RangedThrowing } },
            { 4, new List<SkillTypes> { SkillTypes.EntertainActing, SkillTypes.RangedCrossbow } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.InFighter, TalentTypes.DirtyFighting, TalentTypes.Menacing, TalentTypes.WarriorBorn } },
            { 2, new List<TalentTypes> { TalentTypes.CombatReflexes, TalentTypes.Criminal, TalentTypes.Reversal, TalentTypes.StrikeToStun } },
            { 3, new List<TalentTypes> { TalentTypes.CarefulStrike, TalentTypes.Disarm, TalentTypes.Marksman, TalentTypes.Relentless } },
            { 4, new List<TalentTypes> { TalentTypes.AccurateShot, TalentTypes.Ambidextrous, TalentTypes.FuriousAssault, TalentTypes.StrikeToInjure } }
        };
    }
}

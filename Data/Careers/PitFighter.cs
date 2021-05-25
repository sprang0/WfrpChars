using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class PitFighter : CareerBase
    {
        public PitFighter(int level) : base(level)        {        }

        public override string Name => "Pit Fighter";

        public override string Path => Level switch
        {
            1 => "Pugilist",
            2 => "Pit Fighter",
            3 => "Pit Champion",
            4 => "Pit Legend",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Level;
        public override int Strength => Bonus * Level;
        public override int Toughness => Bonus * Level;
        public override int Intelligence => Bonus * Brass;
        public override int Agility => Bonus * Silver;
        public override int Fellowship => Bonus * Gold;

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Athletics, SkillTypes.Cool, SkillTypes.Dodge, SkillTypes.Endurance, SkillTypes.Gamble, SkillTypes.Intimidate, SkillTypes.MeleeAny, SkillTypes.MeleeBrawling } },
            { 2, new List<SkillTypes> { SkillTypes.Haggle, SkillTypes.Intuition, SkillTypes.MeleeBasic, SkillTypes.MeleeFlailOrTwoHanded, SkillTypes.Perception, SkillTypes.RangedEntangling } },
            { 3, new List<SkillTypes> { SkillTypes.ConsumeAlcohol, SkillTypes.Gossip, SkillTypes.LoreAnatomy, SkillTypes.PerformFight } },
            { 4, new List<SkillTypes> { SkillTypes.Charm, SkillTypes.RangedAny } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.DirtyFighting, TalentTypes.InFighter, TalentTypes.IronJaw, TalentTypes.Reversal } },
            { 2, new List<TalentTypes> { TalentTypes.Ambidextrous, TalentTypes.CombatReflexes, TalentTypes.DualWielder, TalentTypes.Shieldsman } },
            { 3, new List<TalentTypes> { TalentTypes.CombatMaster, TalentTypes.Disarm, TalentTypes.Menacing, TalentTypes.Robust } },
            { 4, new List<TalentTypes> { TalentTypes.Frightening, TalentTypes.FuriousAssault, TalentTypes.Implacable, TalentTypes.ReactionStrike } }
        };
    }
}

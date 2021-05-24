using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Athletics, SkillType.Cool, SkillType.Dodge, SkillType.Endurance, SkillType.Gamble, SkillType.Intimidate, SkillType.MeleeAny, SkillType.MeleeBrawling } },
            { 2, new List<SkillType> { SkillType.Haggle, SkillType.Intuition, SkillType.MeleeBasic, SkillType.MeleeFlailOrTwoHanded, SkillType.Perception, SkillType.RangedEntangling } },
            { 3, new List<SkillType> { SkillType.ConsumeAlcohol, SkillType.Gossip, SkillType.LoreAnatomy, SkillType.PerformFight } },
            { 4, new List<SkillType> { SkillType.Charm, SkillType.RangedAny } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.DirtyFighting, TalentType.InFighter, TalentType.IronJaw, TalentType.Reversal } },
            { 2, new List<TalentType> { TalentType.Ambidextrous, TalentType.CombatReflexes, TalentType.DualWielder, TalentType.Shieldsman } },
            { 3, new List<TalentType> { TalentType.CombatMaster, TalentType.Disarm, TalentType.Menacing, TalentType.Robust } },
            { 4, new List<TalentType> { TalentType.Frightening, TalentType.FuriousAssault, TalentType.Implacable, TalentType.ReactionStrike } }
        };
    }
}

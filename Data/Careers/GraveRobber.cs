using System;
using System.Collections.Generic;

namespace WfrpChars.Data.Careers
{
    class GraveRobber : CareerBase
    {
        public GraveRobber(int level) : base(level) { }

        public override string Name => "Grave Robber";

        public override string Path => Level switch
        {
            1 => "Body Snatcher",
            2 => "Grave Robber",
            3 => "Tomb Robber",
            4 => "Treasure Hunter",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Brass;
        public override int Strength => Bonus * Level;
        public override int Initiative => Bonus * Level;
        public override int Dexterity => Bonus * Silver;
        public override int Intelligence => Bonus * Gold;
        public override int Willpower => Bonus * Level;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Climb, SkillType.Cool, SkillType.Dodge, SkillType.Endurance, SkillType.Gossip, SkillType.Intuition, SkillType.Perception, SkillType.StealthAny } },
            { 2, new List<SkillType> { SkillType.Bribery, SkillType.Drive, SkillType.Evaluate, SkillType.Haggle, SkillType.LoreMedicine, SkillType.MeleeBasic } },
            { 3, new List<SkillType> { SkillType.LoreHistory, SkillType.PickLock, SkillType.Research, SkillType.SetTrap } },
            { 4, new List<SkillType> { SkillType.Navigation, SkillType.TradeEngineer } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.AlleyCat, TalentType.Criminal, TalentType.Flee, TalentType.StrongBack } },
            { 2, new List<TalentType> { TalentType.BreakAndEnter, TalentType.NightVision, TalentType.ResistanceDisease, TalentType.VeryStrong } },
            { 3, new List<TalentType> { TalentType.ReadWrite, TalentType.StrikeMightyBlow, TalentType.Tenacious, TalentType.TunnelRat } },
            { 4, new List<TalentType> { TalentType.FearlessUndead, TalentType.SixthSense, TalentType.StrongMinded, TalentType.Trapper } }
        };
    }
}

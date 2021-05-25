using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Climb, SkillTypes.Cool, SkillTypes.Dodge, SkillTypes.Endurance, SkillTypes.Gossip, SkillTypes.Intuition, SkillTypes.Perception, SkillTypes.StealthAny } },
            { 2, new List<SkillTypes> { SkillTypes.Bribery, SkillTypes.Drive, SkillTypes.Evaluate, SkillTypes.Haggle, SkillTypes.LoreMedicine, SkillTypes.MeleeBasic } },
            { 3, new List<SkillTypes> { SkillTypes.LoreHistory, SkillTypes.PickLock, SkillTypes.Research, SkillTypes.SetTrap } },
            { 4, new List<SkillTypes> { SkillTypes.Navigation, SkillTypes.TradeEngineer } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.AlleyCat, TalentTypes.Criminal, TalentTypes.Flee, TalentTypes.StrongBack } },
            { 2, new List<TalentTypes> { TalentTypes.BreakAndEnter, TalentTypes.NightVision, TalentTypes.ResistanceDisease, TalentTypes.VeryStrong } },
            { 3, new List<TalentTypes> { TalentTypes.ReadWrite, TalentTypes.StrikeMightyBlow, TalentTypes.Tenacious, TalentTypes.TunnelRat } },
            { 4, new List<TalentTypes> { TalentTypes.FearlessUndead, TalentTypes.SixthSense, TalentTypes.StrongMinded, TalentTypes.Trapper } }
        };
    }
}

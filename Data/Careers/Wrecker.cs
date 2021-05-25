using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Wrecker : CareerBase
    {
        public Wrecker(int level) : base(level) { }

        public override string Name => "Wrecker";

        public override string Path => Level switch
        {
            1 => "Cargo Scavenger",
            2 => "Wrecker",
            3 => "River Pirate",
            4 => "Wrecker Captain",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Level;
        public override int BallisticSkill => Bonus * Silver;
        public override int Strength => Bonus * Level;
        public override int Initiative => Bonus * Level;
        public override int Willpower => Bonus * Brass;
        public override int Fellowship => Bonus * Gold;

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Climb, SkillTypes.ConsumeAlcohol, SkillTypes.Dodge, SkillTypes.Endurance, SkillTypes.Row, SkillTypes.MeleeBasic, SkillTypes.OutdoorSurvival, SkillTypes.Swim } },
            { 2, new List<SkillTypes> { SkillTypes.Bribery, SkillTypes.Cool, SkillTypes.Intuition, SkillTypes.Navigation, SkillTypes.Perception, SkillTypes.SetTrap } },
            { 3, new List<SkillTypes> { SkillTypes.Gossip, SkillTypes.Intimidate, SkillTypes.RangedCrossbow, SkillTypes.StealthRural } },
            { 4, new List<SkillTypes> { SkillTypes.Leadership, SkillTypes.LoreRiverways } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.BreakAndEnter, TalentTypes.Criminal, TalentTypes.Fisherman, TalentTypes.StrongBack } },
            { 2, new List<TalentTypes> { TalentTypes.Flee, TalentTypes.Rover, TalentTypes.StrongSwimmer, TalentTypes.Trapper } },
            { 3, new List<TalentTypes> { TalentTypes.DirtyFighting, TalentTypes.EtiquetteCriminals, TalentTypes.Menacing, TalentTypes.Waterman } },
            { 4, new List<TalentTypes> { TalentTypes.FuriousAssault, TalentTypes.InFighter, TalentTypes.Pilot, TalentTypes.WarriorBorn } }
        };
    }
}

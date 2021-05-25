using System;
using System.Collections.Generic;

namespace WfrpChars.Data.Careers
{
    class Thief : CareerBase
    {
        public Thief(int level) : base(level) { }

        public override string Name => "Thief";

        public override string Path => Level switch
        {
            1 => "Prowler",
            2 => "Thief",
            3 => "Master Thief",
            4 => "Cat Burglar",
            _ => throw new Exception("No such Level")
        };

        public override int Strength => Bonus * Silver;
        public override int Initiative => Bonus * Level;
        public override int Agility => Bonus * Level;
        public override int Dexterity => Bonus * Brass;
        public override int Willpower => Bonus * Level;
        public override int Fellowship => Bonus * Gold;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Athletics, SkillType.Climb, SkillType.Cool, SkillType.Dodge, SkillType.Endurance, SkillType.Intuition, SkillType.Perception, SkillType.StealthUrban } },
            { 2, new List<SkillType> { SkillType.Evaluate, SkillType.Gossip, SkillType.LoreLocal, SkillType.PickLock, SkillType.SecretSignsThief, SkillType.SleightOfHand } },
            { 3, new List<SkillType> { SkillType.Bribery, SkillType.Gamble, SkillType.Intimidate, SkillType.RangedCrossbow } },
            { 4, new List<SkillType> { SkillType.Charm, SkillType.SetTrap } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.AlleyCat, TalentType.Criminal, TalentType.Flee, TalentType.StrikeToStun } },
            { 2, new List<TalentType> { TalentType.BreakAndEnter, TalentType.EtiquetteCriminals, TalentType.FastHands, TalentType.Shadow } },
            { 3, new List<TalentType> { TalentType.NightVision, TalentType.NimbleFingered, TalentType.StepAside, TalentType.Trapper } },
            { 4, new List<TalentType> { TalentType.Catfall, TalentType.ScaleSheerSurface, TalentType.StrongLegs, TalentType.Wealthy } }
        };
    }
}

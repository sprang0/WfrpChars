using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Athletics, SkillTypes.Climb, SkillTypes.Cool, SkillTypes.Dodge, SkillTypes.Endurance, SkillTypes.Intuition, SkillTypes.Perception, SkillTypes.StealthUrban } },
            { 2, new List<SkillTypes> { SkillTypes.Evaluate, SkillTypes.Gossip, SkillTypes.LoreLocal, SkillTypes.PickLock, SkillTypes.SecretSignsThief, SkillTypes.SleightOfHand } },
            { 3, new List<SkillTypes> { SkillTypes.Bribery, SkillTypes.Gamble, SkillTypes.Intimidate, SkillTypes.RangedCrossbow } },
            { 4, new List<SkillTypes> { SkillTypes.Charm, SkillTypes.SetTrap } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.AlleyCat, TalentTypes.Criminal, TalentTypes.Flee, TalentTypes.StrikeToStun } },
            { 2, new List<TalentTypes> { TalentTypes.BreakAndEnter, TalentTypes.EtiquetteCriminals, TalentTypes.FastHands, TalentTypes.Shadow } },
            { 3, new List<TalentTypes> { TalentTypes.NightVision, TalentTypes.NimbleFingered, TalentTypes.StepAside, TalentTypes.Trapper } },
            { 4, new List<TalentTypes> { TalentTypes.Catfall, TalentTypes.ScaleSheerSurface, TalentTypes.StrongLegs, TalentTypes.Wealthy } }
        };
    }
}

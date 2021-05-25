using System;
using System.Collections.Generic;

namespace WfrpChars.Data.Careers
{
    class Riverwarden : CareerBase
    {
        public Riverwarden(int level) : base(level) { }

        public override string Name => "Riverwarden";

        public override string Path => Level switch
        {
            1 => "River Recruit",
            2 => "Riverwarden",
            3 => "Shipsword",
            4 => "Shipsword Master",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Brass;
        public override int BallisticSkill => Bonus * Level;
        public override int Strength => Bonus * Level;
        public override int Initiative => Bonus * Silver;
        public override int Intelligence => Bonus * Gold;
        public override int Fellowship => Bonus * Level;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Athletics, SkillType.Dodge, SkillType.Endurance, SkillType.MeleeBasic, SkillType.Perception, SkillType.Row, SkillType.Sail, SkillType.Swim } },
            { 2, new List<SkillType> { SkillType.Bribery, SkillType.Charm, SkillType.Intimidate, SkillType.Gossip, SkillType.LoreRiverways, SkillType.RangedBlackpowder } },
            { 3, new List<SkillType> { SkillType.Climb, SkillType.Cool, SkillType.Intuition, SkillType.Leadership } },
            { 4, new List<SkillType> { SkillType.LoreLaw, SkillType.Navigation } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.StrongSwimmer, TalentType.StrongBack, TalentType.VeryStrong, TalentType.Waterman } },
            { 2, new List<TalentType> { TalentType.Criminal, TalentType.Gunner, TalentType.Fisherman, TalentType.SeasonedTraveler } },
            { 3, new List<TalentType> { TalentType.FearlessWreckers, TalentType.HatredAny, TalentType.Pilot, TalentType.SeaLegs } },
            { 4, new List<TalentType> { TalentType.CommandingPresence, TalentType.Kingpin, TalentType.Menacing, TalentType.Orientation } }
        };
    }
}

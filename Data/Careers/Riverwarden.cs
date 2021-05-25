using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Athletics, SkillTypes.Dodge, SkillTypes.Endurance, SkillTypes.MeleeBasic, SkillTypes.Perception, SkillTypes.Row, SkillTypes.Sail, SkillTypes.Swim } },
            { 2, new List<SkillTypes> { SkillTypes.Bribery, SkillTypes.Charm, SkillTypes.Intimidate, SkillTypes.Gossip, SkillTypes.LoreRiverways, SkillTypes.RangedBlackpowder } },
            { 3, new List<SkillTypes> { SkillTypes.Climb, SkillTypes.Cool, SkillTypes.Intuition, SkillTypes.Leadership } },
            { 4, new List<SkillTypes> { SkillTypes.LoreLaw, SkillTypes.Navigation } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.StrongSwimmer, TalentTypes.StrongBack, TalentTypes.VeryStrong, TalentTypes.Waterman } },
            { 2, new List<TalentTypes> { TalentTypes.Criminal, TalentTypes.Gunner, TalentTypes.Fisherman, TalentTypes.SeasonedTraveler } },
            { 3, new List<TalentTypes> { TalentTypes.FearlessWreckers, TalentTypes.HatredAny, TalentTypes.Pilot, TalentTypes.SeaLegs } },
            { 4, new List<TalentTypes> { TalentTypes.CommandingPresence, TalentTypes.Kingpin, TalentTypes.Menacing, TalentTypes.Orientation } }
        };
    }
}

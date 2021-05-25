using System;
using System.Collections.Generic;

namespace WfrpChars.Data.Careers
{
    class Riverwoman : CareerBase
    {
        public Riverwoman(int level) : base(level) { }

        public override string Name => "Riverwoman";

        public override string Path => Level switch
        {
            1 => "Greenfish",
            2 => "Riverwoman",
            3 => "Riverwise",
            4 => "River Elder",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Brass;
        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Silver;
        public override int Agility => Bonus * Level;
        public override int Dexterity => Bonus * Level;
        public override int Fellowship => Bonus * Gold;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Athletics, SkillType.ConsumeAlcohol, SkillType.Dodge, SkillType.Endurance, SkillType.Gossip, SkillType.OutdoorSurvival, SkillType.Row, SkillType.Swim } },
            { 2, new List<SkillType> { SkillType.Gamble, SkillType.LoreLocal, SkillType.LoreRiverways, SkillType.RangedEntangling, SkillType.RangedThrowing, SkillType.SetTrap } },
            { 3, new List<SkillType> { SkillType.Charm, SkillType.Intuition, SkillType.MeleePolearm, SkillType.Perception } },
            { 4, new List<SkillType> { SkillType.EntertainStorytelling, SkillType.LoreFolklore } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.Fisherman, TalentType.Gregarious, TalentType.StriderMarshes, TalentType.StrongSwimmer } },
            { 2, new List<TalentType> { TalentType.CraftsmanBoatbuilder, TalentType.Rover, TalentType.StrongBack, TalentType.Waterman } },
            { 3, new List<TalentType> { TalentType.SavantRiverways, TalentType.StoutHearted, TalentType.Tenacious, TalentType.VeryStrong } },
            { 4, new List<TalentType> { TalentType.MasterCraftsmanBoatbuilder, TalentType.PublicSpeaker, TalentType.Sharp, TalentType.StrongMinded } }
        };
    }
}

using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Athletics, SkillTypes.ConsumeAlcohol, SkillTypes.Dodge, SkillTypes.Endurance, SkillTypes.Gossip, SkillTypes.OutdoorSurvival, SkillTypes.Row, SkillTypes.Swim } },
            { 2, new List<SkillTypes> { SkillTypes.Gamble, SkillTypes.LoreLocal, SkillTypes.LoreRiverways, SkillTypes.RangedEntangling, SkillTypes.RangedThrowing, SkillTypes.SetTrap } },
            { 3, new List<SkillTypes> { SkillTypes.Charm, SkillTypes.Intuition, SkillTypes.MeleePolearm, SkillTypes.Perception } },
            { 4, new List<SkillTypes> { SkillTypes.EntertainStorytelling, SkillTypes.LoreFolklore } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.Fisherman, TalentTypes.Gregarious, TalentTypes.StriderMarshes, TalentTypes.StrongSwimmer } },
            { 2, new List<TalentTypes> { TalentTypes.CraftsmanBoatbuilder, TalentTypes.Rover, TalentTypes.StrongBack, TalentTypes.Waterman } },
            { 3, new List<TalentTypes> { TalentTypes.SavantRiverways, TalentTypes.StoutHearted, TalentTypes.Tenacious, TalentTypes.VeryStrong } },
            { 4, new List<TalentTypes> { TalentTypes.MasterCraftsmanBoatbuilder, TalentTypes.PublicSpeaker, TalentTypes.Sharp, TalentTypes.StrongMinded } }
        };
    }
}

using System;
using System.Collections.Generic;

namespace WfrpChars.Data.Careers
{
    class Seaman : CareerBase
    {
        public Seaman(int level) : base(level) { }

        public override string Name => "Seaman";

        public override string Path => Level switch
        {
            1 => "Landsman",
            2 => "Seaman",
            3 => "Boatswain",
            4 => "Ship's Master",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Brass;
        public override int Initiative => Bonus * Silver;
        public override int Agility => Bonus * Level;
        public override int Dexterity => Bonus * Level;
        public override int Intelligence => Bonus * Gold;
        public override int Fellowship => Bonus * Level;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Climb, SkillType.ConsumeAlcohol, SkillType.Gamble, SkillType.Gossip, SkillType.Row, SkillType.MeleeBrawling, SkillType.Sail, SkillType.Swim } },
            { 2, new List<SkillType> { SkillType.Athletics, SkillType.Dodge, SkillType.Endurance, SkillType.EntertainSinging, SkillType.LanguageAny, SkillType.MeleeBasic } },
            { 3, new List<SkillType> { SkillType.Cool, SkillType.Leadership, SkillType.Perception, SkillType.TradeCarpenter } },
            { 4, new List<SkillType> { SkillType.Charm, SkillType.Navigation } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.Fisherman, TalentType.StriderCoastal, TalentType.StrongBack, TalentType.StrongSwimmer } },
            { 2, new List<TalentType> { TalentType.Catfall, TalentType.SeaLegs, TalentType.SeasonedTraveler, TalentType.StrongLegs } },
            { 3, new List<TalentType> { TalentType.OldSalt, TalentType.StrikeMightyBlow, TalentType.Tenacious, TalentType.VeryStrong } },
            { 4, new List<TalentType> { TalentType.Orientation, TalentType.Pilot, TalentType.PublicSpeaker, TalentType.Savvy } }
        };
    }
}

using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Climb, SkillTypes.ConsumeAlcohol, SkillTypes.Gamble, SkillTypes.Gossip, SkillTypes.Row, SkillTypes.MeleeBrawling, SkillTypes.Sail, SkillTypes.Swim } },
            { 2, new List<SkillTypes> { SkillTypes.Athletics, SkillTypes.Dodge, SkillTypes.Endurance, SkillTypes.EntertainSinging, SkillTypes.LanguageAny, SkillTypes.MeleeBasic } },
            { 3, new List<SkillTypes> { SkillTypes.Cool, SkillTypes.Leadership, SkillTypes.Perception, SkillTypes.TradeCarpenter } },
            { 4, new List<SkillTypes> { SkillTypes.Charm, SkillTypes.Navigation } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.Fisherman, TalentTypes.StriderCoastal, TalentTypes.StrongBack, TalentTypes.StrongSwimmer } },
            { 2, new List<TalentTypes> { TalentTypes.Catfall, TalentTypes.SeaLegs, TalentTypes.SeasonedTraveler, TalentTypes.StrongLegs } },
            { 3, new List<TalentTypes> { TalentTypes.OldSalt, TalentTypes.StrikeMightyBlow, TalentTypes.Tenacious, TalentTypes.VeryStrong } },
            { 4, new List<TalentTypes> { TalentTypes.Orientation, TalentTypes.Pilot, TalentTypes.PublicSpeaker, TalentTypes.Savvy } }
        };
    }
}

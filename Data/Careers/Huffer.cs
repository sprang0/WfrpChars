using System;
using System.Collections.Generic;

namespace WfrpChars.Data.Careers
{
    class Huffer : CareerBase
    {
        public Huffer(int level) : base(level) { }

        public override string Name => "Huffer";

        public override string Path => Level switch
        {
            1 => "Riverguide",
            2 => "Huffer",
            3 => "Pilot",
            4 => "Master Pilot",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Level;
        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Level;
        public override int Intelligence => Bonus * Silver;
        public override int Willpower => Bonus * Brass;
        public override int Fellowship => Bonus * Gold;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.ConsumeAlcohol, SkillType.Gossip, SkillType.Intuition, SkillType.LoreLocal, SkillType.LoreRiverways, SkillType.Perception, SkillType.Row, SkillType.Swim } },
            { 2, new List<SkillType> { SkillType.Charm, SkillType.Cool, SkillType.EntertainStorytelling, SkillType.LanguageAny, SkillType.MeleeBasic, SkillType.Navigation } },
            { 3, new List<SkillType> { SkillType.Haggle, SkillType.Intimidate, SkillType.LoreLocal, SkillType.LoreWrecks } },
            { 4, new List<SkillType> { SkillType.Leadership, SkillType.Sail } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.Fisherman, TalentType.NightVision, TalentType.Orientation, TalentType.Waterman } },
            { 2, new List<TalentType> { TalentType.Dealmaker, TalentType.EtiquetteGuilder, TalentType.NoseForTrouble, TalentType.RiverGuide } },
            { 3, new List<TalentType> { TalentType.AcuteSenseSight, TalentType.Pilot, TalentType.SeaLegs, TalentType.VeryStrong } },
            { 4, new List<TalentType> { TalentType.SixthSense, TalentType.Sharp, TalentType.StrongSwimmer, TalentType.Tenacious } }
        };
    }
}

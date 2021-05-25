using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.ConsumeAlcohol, SkillTypes.Gossip, SkillTypes.Intuition, SkillTypes.LoreLocal, SkillTypes.LoreRiverways, SkillTypes.Perception, SkillTypes.Row, SkillTypes.Swim } },
            { 2, new List<SkillTypes> { SkillTypes.Charm, SkillTypes.Cool, SkillTypes.EntertainStorytelling, SkillTypes.LanguageAny, SkillTypes.MeleeBasic, SkillTypes.Navigation } },
            { 3, new List<SkillTypes> { SkillTypes.Haggle, SkillTypes.Intimidate, SkillTypes.LoreLocal, SkillTypes.LoreWrecks } },
            { 4, new List<SkillTypes> { SkillTypes.Leadership, SkillTypes.Sail } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.Fisherman, TalentTypes.NightVision, TalentTypes.Orientation, TalentTypes.Waterman } },
            { 2, new List<TalentTypes> { TalentTypes.Dealmaker, TalentTypes.EtiquetteGuilder, TalentTypes.NoseForTrouble, TalentTypes.RiverGuide } },
            { 3, new List<TalentTypes> { TalentTypes.AcuteSenseSight, TalentTypes.Pilot, TalentTypes.SeaLegs, TalentTypes.VeryStrong } },
            { 4, new List<TalentTypes> { TalentTypes.SixthSense, TalentTypes.Sharp, TalentTypes.StrongSwimmer, TalentTypes.Tenacious } }
        };
    }
}

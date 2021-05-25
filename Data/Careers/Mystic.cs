using System;
using System.Collections.Generic;

namespace WfrpChars.Data.Careers
{
    class Mystic : CareerBase
    {
        public Mystic(int level) : base(level) { }

        public override string Name => "Mystic";

        public override string Path => Level switch
        {
            1 => "Fortune Teller",
            2 => "Mystic",
            3 => "Sage",
            4 => "Seer",
            _ => throw new Exception("No such Level")
        };

        public override int Initiative => Bonus * Level;
        public override int Agility => Bonus * Silver;
        public override int Dexterity => Bonus * Level;
        public override int Intelligence => Bonus * Gold;
        public override int Willpower => Bonus * Brass;
        public override int Fellowship => Bonus * Level;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Charm, SkillType.EntertainFortuneTelling, SkillType.Dodge, SkillType.Gossip, SkillType.Haggle, SkillType.Intuition, SkillType.Perception, SkillType.SleightOfHand } },
            { 2, new List<SkillType> { SkillType.Bribery, SkillType.Cool, SkillType.EntertainProphecy, SkillType.Evaluate, SkillType.Intimidate, SkillType.LoreAstrology } },
            { 3, new List<SkillType> { SkillType.ArtWriting, SkillType.CharmAnimal, SkillType.EntertainStorytelling, SkillType.LanguageAny } },
            { 4, new List<SkillType> { SkillType.LoreProphecy, SkillType.ChannellingAzyr } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.Attractive, TalentType.Luck, TalentType.SecondSight, TalentType.Suave } },
            { 2, new List<TalentType> { TalentType.DetectArtefact, TalentType.HolyVisions, TalentType.SixthSense, TalentType.WellPrepared } },
            { 3, new List<TalentType> { TalentType.NoseForTrouble, TalentType.PettyMagic, TalentType.ReadWrite, TalentType.Witch } },
            { 4, new List<TalentType> { TalentType.ArcaneMagicCelestial, TalentType.MagicalSense, TalentType.Menacing, TalentType.StrongMinded } }
        };
    }
}

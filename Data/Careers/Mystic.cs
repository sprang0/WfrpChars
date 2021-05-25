using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Charm, SkillTypes.EntertainFortuneTelling, SkillTypes.Dodge, SkillTypes.Gossip, SkillTypes.Haggle, SkillTypes.Intuition, SkillTypes.Perception, SkillTypes.SleightOfHand } },
            { 2, new List<SkillTypes> { SkillTypes.Bribery, SkillTypes.Cool, SkillTypes.EntertainProphecy, SkillTypes.Evaluate, SkillTypes.Intimidate, SkillTypes.LoreAstrology } },
            { 3, new List<SkillTypes> { SkillTypes.ArtWriting, SkillTypes.CharmAnimal, SkillTypes.EntertainStorytelling, SkillTypes.LanguageAny } },
            { 4, new List<SkillTypes> { SkillTypes.LoreProphecy, SkillTypes.ChannellingAzyr } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.Attractive, TalentTypes.Luck, TalentTypes.SecondSight, TalentTypes.Suave } },
            { 2, new List<TalentTypes> { TalentTypes.DetectArtefact, TalentTypes.HolyVisions, TalentTypes.SixthSense, TalentTypes.WellPrepared } },
            { 3, new List<TalentTypes> { TalentTypes.NoseForTrouble, TalentTypes.PettyMagic, TalentTypes.ReadWrite, TalentTypes.Witch } },
            { 4, new List<TalentTypes> { TalentTypes.ArcaneMagicCelestial, TalentTypes.MagicalSense, TalentTypes.Menacing, TalentTypes.StrongMinded } }
        };
    }
}

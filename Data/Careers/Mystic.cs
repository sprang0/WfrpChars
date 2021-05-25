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

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Charm, Types.Skills.EntertainFortuneTelling, Types.Skills.Dodge, Types.Skills.Gossip, Types.Skills.Haggle, Types.Skills.Intuition, Types.Skills.Perception, Types.Skills.SleightOfHand } },
            { 2, new List<Skills> { Types.Skills.Bribery, Types.Skills.Cool, Types.Skills.EntertainProphecy, Types.Skills.Evaluate, Types.Skills.Intimidate, Types.Skills.LoreAstrology } },
            { 3, new List<Skills> { Types.Skills.ArtWriting, Types.Skills.CharmAnimal, Types.Skills.EntertainStorytelling, Types.Skills.LanguageAny } },
            { 4, new List<Skills> { Types.Skills.LoreProphecy, Types.Skills.ChannellingAzyr } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.Attractive, Types.Talents.Luck, Types.Talents.SecondSight, Types.Talents.Suave } },
            { 2, new List<Talents> { Types.Talents.DetectArtefact, Types.Talents.HolyVisions, Types.Talents.SixthSense, Types.Talents.WellPrepared } },
            { 3, new List<Talents> { Types.Talents.NoseForTrouble, Types.Talents.PettyMagic, Types.Talents.ReadWrite, Types.Talents.Witch } },
            { 4, new List<Talents> { Types.Talents.ArcaneMagicCelestial, Types.Talents.MagicalSense, Types.Talents.Menacing, Types.Talents.StrongMinded } }
        };
    }
}

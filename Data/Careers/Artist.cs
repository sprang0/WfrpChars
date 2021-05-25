using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Artist : CareerBase
    {
        public Artist(int level) : base(level) { }

        public override string Name => "Artist";

        public override string Path => Level switch
        {
            1 => "Apprentice Artist",
            2 => "Artist",
            3 => "Master Artist",
            4 => "Maestro",
            _ => throw new Exception("No such Level")
        };

        public override int Strength => Bonus * Level;
        public override int Initiative => Bonus * Level;
        public override int Dexterity => Bonus * Level;
        public override int Intelligence => Bonus * Gold;
        public override int Willpower => Bonus * Silver;
        public override int Fellowship => Bonus * Brass;

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.ArtAny, SkillTypes.Cool, SkillTypes.ConsumeAlcohol, SkillTypes.Evaluate, SkillTypes.Endurance, SkillTypes.Gossip, SkillTypes.Perception, SkillTypes.StealthUrban } },
            { 2, new List<SkillTypes> { SkillTypes.Climb, SkillTypes.Gamble, SkillTypes.Haggle, SkillTypes.Intuition, SkillTypes.LanguageClassical, SkillTypes.TradeArtSupplies } },
            { 3, new List<SkillTypes> { SkillTypes.Charm, SkillTypes.Leadership, SkillTypes.LoreArt, SkillTypes.LoreHeraldry } },
            { 4, new List<SkillTypes> { SkillTypes.Research, SkillTypes.RideHorse } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.Artistic, TalentTypes.Sharp, TalentTypes.StrongBack, TalentTypes.Tenacious } },
            { 2, new List<TalentTypes> { TalentTypes.Carouser, TalentTypes.Criminal, TalentTypes.Gregarious, TalentTypes.NimbleFingered } },
            { 3, new List<TalentTypes> { TalentTypes.AcuteSenseAny, TalentTypes.Dealmaker, TalentTypes.EtiquetteAny, TalentTypes.NoseForTrouble } },
            { 4, new List<TalentTypes> { TalentTypes.Ambidextrous, TalentTypes.Kingpin, TalentTypes.MagnumOpus, TalentTypes.ReadWrite } }
        };
    }
}

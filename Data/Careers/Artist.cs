using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.ArtAny, SkillType.Cool, SkillType.ConsumeAlcohol, SkillType.Evaluate, SkillType.Endurance, SkillType.Gossip, SkillType.Perception, SkillType.StealthUrban } },
            { 2, new List<SkillType> { SkillType.Climb, SkillType.Gamble, SkillType.Haggle, SkillType.Intuition, SkillType.LanguageClassical, SkillType.TradeArtSupplies } },
            { 3, new List<SkillType> { SkillType.Charm, SkillType.Leadership, SkillType.LoreArt, SkillType.LoreHeraldry } },
            { 4, new List<SkillType> { SkillType.Research, SkillType.RideHorse } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.Artistic, TalentType.Sharp, TalentType.StrongBack, TalentType.Tenacious } },
            { 2, new List<TalentType> { TalentType.Carouser, TalentType.Criminal, TalentType.Gregarious, TalentType.NimbleFingered } },
            { 3, new List<TalentType> { TalentType.AccuteSenseAny, TalentType.Dealmaker, TalentType.EtiquetteAny, TalentType.NoseForTrouble } },
            { 4, new List<TalentType> { TalentType.Ambidextrous, TalentType.Kingpin, TalentType.MagnumOpus, TalentType.ReadWrite } }
        };
    }
}

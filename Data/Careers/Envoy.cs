using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WfrpChars.Data.Careers
{
    class Envoy : CareerBase
    {
        public Envoy(int level) : base(level) { }

        public override string Name => "Envoy";

        public override string Path => Level switch
        {
            1 => "Herald",
            2 => "Envoy",
            3 => "Diplomat",
            4 => "Ambassador",
            _ => throw new Exception("No such Level")
        };

        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Silver;
        public override int Agility => Bonus * Level;
        public override int Intelligence => Bonus * Brass;
        public override int Willpower => Bonus * Gold;
        public override int Fellowship => Bonus * Level;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Athletics, SkillType.Charm, SkillType.Drive, SkillType.Dodge, SkillType.Endurance, SkillType.Intuition, SkillType.RideHorse, SkillType.Row } },
            { 2, new List<SkillType> { SkillType.ArtWriting, SkillType.Bribery, SkillType.Cool, SkillType.Gossip, SkillType.Haggle, SkillType.LorePolitics } },
            { 3, new List<SkillType> { SkillType.Intimidate, SkillType.LanguageAny, SkillType.Leadership, SkillType.Navigation } },
            { 4, new List<SkillType> { SkillType.LanguageAny, SkillType.LoreAny } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.Blather, TalentType.EtiquetteNobles, TalentType.ReadWrite, TalentType.Suave } },
            { 2, new List<TalentType> { TalentType.Attractive, TalentType.CatTongued, TalentType.EtiquetteAny, TalentType.SeasonedTraveler } },
            { 3, new List<TalentType> { TalentType.Carouser, TalentType.Dealmaker, TalentType.Gregarious, TalentType.Schemer } },
            { 4, new List<TalentType> { TalentType.Briber, TalentType.CommandingPresence, TalentType.NobleBlood, TalentType.Savvy } }
        };
    }
}

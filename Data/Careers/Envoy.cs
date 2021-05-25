using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Athletics, SkillTypes.Charm, SkillTypes.Drive, SkillTypes.Dodge, SkillTypes.Endurance, SkillTypes.Intuition, SkillTypes.RideHorse, SkillTypes.Row } },
            { 2, new List<SkillTypes> { SkillTypes.ArtWriting, SkillTypes.Bribery, SkillTypes.Cool, SkillTypes.Gossip, SkillTypes.Haggle, SkillTypes.LorePolitics } },
            { 3, new List<SkillTypes> { SkillTypes.Intimidate, SkillTypes.LanguageAny, SkillTypes.Leadership, SkillTypes.Navigation } },
            { 4, new List<SkillTypes> { SkillTypes.LanguageAny, SkillTypes.LoreAny } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.Blather, TalentTypes.EtiquetteNobles, TalentTypes.ReadWrite, TalentTypes.Suave } },
            { 2, new List<TalentTypes> { TalentTypes.Attractive, TalentTypes.CatTongued, TalentTypes.EtiquetteAny, TalentTypes.SeasonedTraveler } },
            { 3, new List<TalentTypes> { TalentTypes.Carouser, TalentTypes.Dealmaker, TalentTypes.Gregarious, TalentTypes.Schemer } },
            { 4, new List<TalentTypes> { TalentTypes.Briber, TalentTypes.CommandingPresence, TalentTypes.NobleBlood, TalentTypes.Savvy } }
        };
    }
}

using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Advisor : CareerBase
    {
        public Advisor(int level) : base(level) { }

        public override string Name => "Advisor";

        public override string Path => Level switch
        {
            1 => "Aide",
            2 => "Advisor",
            3 => "Counsellor",
            4 => "Chancellor",
            _ => throw new Exception("No such Level")
        };

        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Level;
        public override int Agility => Bonus * Level;
        public override int Intelligence => Bonus * Silver;
        public override int Willpower => Bonus * Gold;
        public override int Fellowship => Bonus * Brass;

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Bribery, SkillTypes.ConsumeAlcohol, SkillTypes.Endurance, SkillTypes.Gossip, SkillTypes.Haggle, SkillTypes.LanguageClassical, SkillTypes.LorePolitics, SkillTypes.Perception } },
            { 2, new List<SkillTypes> { SkillTypes.Charm, SkillTypes.Cool, SkillTypes.Evaluate, SkillTypes.Gamble, SkillTypes.Intuition, SkillTypes.LoreLocal } },
            { 3, new List<SkillTypes> { SkillTypes.EntertainStorytelling, SkillTypes.Leadership, SkillTypes.LanguageAny, SkillTypes.LoreAny } },
            { 4, new List<SkillTypes> { SkillTypes.LoreHeraldry, SkillTypes.RideHorse } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.BeneathNotice, TalentTypes.EtiquetteAny, TalentTypes.Gregarious, TalentTypes.ReadWrite } },
            { 2, new List<TalentTypes> { TalentTypes.Blather, TalentTypes.Criminal, TalentTypes.Schemer, TalentTypes.Supportive } },
            { 3, new List<TalentTypes> { TalentTypes.Argumentative, TalentTypes.Briber, TalentTypes.Carouser, TalentTypes.CatTongued } },
            { 4, new List<TalentTypes> { TalentTypes.CommandingPresence, TalentTypes.Embezzle, TalentTypes.Kingpin, TalentTypes.Suave } }
        };
    }
}

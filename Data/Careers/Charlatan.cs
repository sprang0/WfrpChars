using System;
using System.Collections.Generic;

namespace WfrpChars.Data.Careers
{
    class Charlatan : CareerBase
    {
        public Charlatan(int level) : base(level) { }

        public override string Name => "Charlatan";

        public override string Path => Level switch
        {
            1 => "Swindler",
            2 => "Charlatan",
            3 => "Con Artist",
            4 => "Scoundrel",
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
            { 1, new List<SkillType> { SkillType.Bribery, SkillType.ConsumeAlcohol, SkillType.Charm, SkillType.EntertainStorytelling, SkillType.Gamble, SkillType.Gossip, SkillType.Haggle, SkillType.SleightOfHand } },
            { 2, new List<SkillType> { SkillType.Cool, SkillType.Dodge, SkillType.EntertainActing, SkillType.Evaluate, SkillType.Intuition, SkillType.Perception } },
            { 3, new List<SkillType> { SkillType.LanguageThief, SkillType.LoreHeraldry, SkillType.PickLock, SkillType.SecretSignsThief } },
            { 4, new List<SkillType> { SkillType.LoreGenealogy, SkillType.Research } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.Cardsharp, TalentType.Diceman, TalentType.EtiquetteAny, TalentType.Luck } },
            { 2, new List<TalentType> { TalentType.Blather, TalentType.Criminal, TalentType.FastHands, TalentType.SecretIdentity } },
            { 3, new List<TalentType> { TalentType.Attractive, TalentType.CatTongued, TalentType.Dealmaker, TalentType.ReadWrite } },
            { 4, new List<TalentType> { TalentType.Gregarious, TalentType.MasterOfDisguise, TalentType.NoseForTrouble, TalentType.Suave } }
        };
    }
}

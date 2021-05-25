using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Bribery, SkillTypes.ConsumeAlcohol, SkillTypes.Charm, SkillTypes.EntertainStorytelling, SkillTypes.Gamble, SkillTypes.Gossip, SkillTypes.Haggle, SkillTypes.SleightOfHand } },
            { 2, new List<SkillTypes> { SkillTypes.Cool, SkillTypes.Dodge, SkillTypes.EntertainActing, SkillTypes.Evaluate, SkillTypes.Intuition, SkillTypes.Perception } },
            { 3, new List<SkillTypes> { SkillTypes.LanguageThief, SkillTypes.LoreHeraldry, SkillTypes.PickLock, SkillTypes.SecretSignsThief } },
            { 4, new List<SkillTypes> { SkillTypes.LoreGenealogy, SkillTypes.Research } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.Cardsharp, TalentTypes.Diceman, TalentTypes.EtiquetteAny, TalentTypes.Luck } },
            { 2, new List<TalentTypes> { TalentTypes.Blather, TalentTypes.Criminal, TalentTypes.FastHands, TalentTypes.SecretIdentity } },
            { 3, new List<TalentTypes> { TalentTypes.Attractive, TalentTypes.CatTongued, TalentTypes.Dealmaker, TalentTypes.ReadWrite } },
            { 4, new List<TalentTypes> { TalentTypes.Gregarious, TalentTypes.MasterOfDisguise, TalentTypes.NoseForTrouble, TalentTypes.Suave } }
        };
    }
}

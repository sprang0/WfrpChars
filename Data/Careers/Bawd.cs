using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Bawd : CareerBase
    {
        public Bawd(int level) : base(level) { }

        public override string Name => "Bawd";

        public override string Path => Level switch
        {
            1 => "Hustler",
            2 => "Bawd",
            3 => "Procurer",
            4 => "Ringleader",
            _ => throw new Exception("No such Level")
        };

        public override int Initiative => Bonus * Brass;
        public override int Agility => Bonus * Level;
        public override int Dexterity => Bonus * Level;
        public override int Intelligence => Bonus * Gold;
        public override int Willpower => Bonus * Silver;
        public override int Fellowship => Bonus * Level;

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Bribery, SkillTypes.Charm, SkillTypes.ConsumeAlcohol, SkillTypes.EntertainAny, SkillTypes.Gamble, SkillTypes.Gossip, SkillTypes.Haggle, SkillTypes.Intimidate } },
            { 2, new List<SkillTypes> { SkillTypes.Dodge, SkillTypes.Endurance, SkillTypes.Intuition, SkillTypes.LoreLocal, SkillTypes.MeleeBasic, SkillTypes.Perception } },
            { 3, new List<SkillTypes> { SkillTypes.Cool, SkillTypes.Evaluate, SkillTypes.LanguageAny, SkillTypes.LoreLaw } },
            { 4, new List<SkillTypes> { SkillTypes.Leadership, SkillTypes.LoreHeraldry } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.Attractive, TalentTypes.AlleyCat, TalentTypes.Blather, TalentTypes.Gregarious } },
            { 2, new List<TalentTypes> { TalentTypes.Ambidextrous, TalentTypes.Carouser, TalentTypes.Criminal, TalentTypes.ResistanceDisease } },
            { 3, new List<TalentTypes> { TalentTypes.Dealmaker, TalentTypes.Embezzle, TalentTypes.EtiquetteAny, TalentTypes.Suave } },
            { 4, new List<TalentTypes> { TalentTypes.Briber, TalentTypes.Kingpin, TalentTypes.Numismatics, TalentTypes.Savvy } }
        };
    }
}

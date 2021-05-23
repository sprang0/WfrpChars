using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Bribery, SkillType.Charm, SkillType.ConsumeAlcohol, SkillType.EntertainAny, SkillType.Gamble, SkillType.Gossip, SkillType.Haggle, SkillType.Intimidate } },
            { 2, new List<SkillType> { SkillType.Dodge, SkillType.Endurance, SkillType.Intuition, SkillType.LoreLocal, SkillType.MeleeBasic, SkillType.Perception } },
            { 3, new List<SkillType> { SkillType.Cool, SkillType.Evaluate, SkillType.LanguageAny, SkillType.LoreLaw } },
            { 4, new List<SkillType> { SkillType.Leadership, SkillType.LoreHeraldry } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.Attractive, TalentType.AlleyCat, TalentType.Blather, TalentType.Gregarious } },
            { 2, new List<TalentType> { TalentType.Ambidextrous, TalentType.Carouser, TalentType.Criminal, TalentType.ResistanceDisease } },
            { 3, new List<TalentType> { TalentType.Dealmaker, TalentType.Embezzle, TalentType.EtiquetteAny, TalentType.Suave } },
            { 4, new List<TalentType> { TalentType.Briber, TalentType.Kingpin, TalentType.Numismatics, TalentType.Savvy } }
        };
    }
}

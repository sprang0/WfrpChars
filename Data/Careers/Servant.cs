using System;
using System.Collections.Generic;

namespace WfrpChars.Data.Careers
{
    class Servant : CareerBase
    {
        public Servant(int level) : base(level) { }

        public override string Name => "Servant";

        public override string Path => Level switch
        {
            1 => "Menial",
            2 => "Servant",
            3 => "Attendant",
            4 => "Steward",
            _ => throw new Exception("No such Level")
        };

        public override int Strength => Bonus * Level;
        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Brass;
        public override int Agility => Bonus * Level;
        public override int Intelligence => Bonus * Silver;
        public override int Fellowship => Bonus * Gold;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Athletics, SkillType.Climb, SkillType.Drive, SkillType.Dodge, SkillType.Endurance, SkillType.Intuition, SkillType.Perception, SkillType.StealthAny } },
            { 2, new List<SkillType> { SkillType.AnimalCare, SkillType.ConsumeAlcohol, SkillType.Evaluate, SkillType.Gamble, SkillType.Gossip, SkillType.Haggle } },
            { 3, new List<SkillType> { SkillType.Charm, SkillType.Cool, SkillType.Intimidate, SkillType.LoreLocal } },
            { 4, new List<SkillType> { SkillType.Leadership, SkillType.MeleeBasic } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.BeneathNotice, TalentType.StrongBack, TalentType.StrongMinded, TalentType.Sturdy } },
            { 2, new List<TalentType> { TalentType.EtiquetteServants, TalentType.Shadow, TalentType.Tenacious, TalentType.WellPrepared } },
            { 3, new List<TalentType> { TalentType.Embezzle, TalentType.ResistancePoison, TalentType.Suave, TalentType.Supportive } },
            { 4, new List<TalentType> { TalentType.EtiquetteAny, TalentType.Numismatics, TalentType.ReadWrite, TalentType.Savvy } }
        };
    }
}

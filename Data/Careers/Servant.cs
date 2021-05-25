using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Athletics, SkillTypes.Climb, SkillTypes.Drive, SkillTypes.Dodge, SkillTypes.Endurance, SkillTypes.Intuition, SkillTypes.Perception, SkillTypes.StealthAny } },
            { 2, new List<SkillTypes> { SkillTypes.AnimalCare, SkillTypes.ConsumeAlcohol, SkillTypes.Evaluate, SkillTypes.Gamble, SkillTypes.Gossip, SkillTypes.Haggle } },
            { 3, new List<SkillTypes> { SkillTypes.Charm, SkillTypes.Cool, SkillTypes.Intimidate, SkillTypes.LoreLocal } },
            { 4, new List<SkillTypes> { SkillTypes.Leadership, SkillTypes.MeleeBasic } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.BeneathNotice, TalentTypes.StrongBack, TalentTypes.StrongMinded, TalentTypes.Sturdy } },
            { 2, new List<TalentTypes> { TalentTypes.EtiquetteServants, TalentTypes.Shadow, TalentTypes.Tenacious, TalentTypes.WellPrepared } },
            { 3, new List<TalentTypes> { TalentTypes.Embezzle, TalentTypes.ResistancePoison, TalentTypes.Suave, TalentTypes.Supportive } },
            { 4, new List<TalentTypes> { TalentTypes.EtiquetteAny, TalentTypes.Numismatics, TalentTypes.ReadWrite, TalentTypes.Savvy } }
        };
    }
}

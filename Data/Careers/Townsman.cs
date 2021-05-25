using System;
using System.Collections.Generic;

namespace WfrpChars.Data.Careers
{
    class Townsman : CareerBase
    {
        public Townsman(int level) : base(level) { }

        public override string Name => "Townsman";

        public override string Path => Level switch
        {
            1 => "Clerk",
            2 => "Townsman",
            3 => "Town Councillor",
            4 => "Burgomeister",
            _ => throw new Exception("No such Level")
        };

        public override int Initiative => Bonus * Brass;
        public override int Agility => Bonus * Level;
        public override int Dexterity => Bonus * Silver;
        public override int Intelligence => Bonus * Level;
        public override int Willpower => Bonus * Gold;
        public override int Fellowship => Bonus * Level;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Charm, SkillType.Climb, SkillType.ConsumeAlcohol, SkillType.Drive, SkillType.Dodge, SkillType.Gamble, SkillType.Gossip, SkillType.Haggle } },
            { 2, new List<SkillType> { SkillType.Bribery, SkillType.Evaluate, SkillType.Intuition, SkillType.LoreLocal, SkillType.MeleeBrawling, SkillType.PlayAny } },
            { 3, new List<SkillType> { SkillType.Cool, SkillType.LoreLaw, SkillType.Perception, SkillType.Research } },
            { 4, new List<SkillType> { SkillType.LorePolitics, SkillType.Intimidate } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.AlleyCat, TalentType.BeneathNotice, TalentType.EtiquetteServants, TalentType.Sturdy } },
            { 2, new List<TalentType> { TalentType.Dealmaker, TalentType.Embezzle, TalentType.EtiquetteAny, TalentType.Gregarious } },
            { 3, new List<TalentType> { TalentType.Briber, TalentType.PublicSpeaker, TalentType.ReadWrite, TalentType.Supportive } },
            { 4, new List<TalentType> { TalentType.CommandingPresence, TalentType.MasterOrator, TalentType.Schemer, TalentType.Suave } }
        };
    }
}

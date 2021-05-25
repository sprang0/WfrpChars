using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Charm, SkillTypes.Climb, SkillTypes.ConsumeAlcohol, SkillTypes.Drive, SkillTypes.Dodge, SkillTypes.Gamble, SkillTypes.Gossip, SkillTypes.Haggle } },
            { 2, new List<SkillTypes> { SkillTypes.Bribery, SkillTypes.Evaluate, SkillTypes.Intuition, SkillTypes.LoreLocal, SkillTypes.MeleeBrawling, SkillTypes.PlayAny } },
            { 3, new List<SkillTypes> { SkillTypes.Cool, SkillTypes.LoreLaw, SkillTypes.Perception, SkillTypes.Research } },
            { 4, new List<SkillTypes> { SkillTypes.LorePolitics, SkillTypes.Intimidate } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.AlleyCat, TalentTypes.BeneathNotice, TalentTypes.EtiquetteServants, TalentTypes.Sturdy } },
            { 2, new List<TalentTypes> { TalentTypes.Dealmaker, TalentTypes.Embezzle, TalentTypes.EtiquetteAny, TalentTypes.Gregarious } },
            { 3, new List<TalentTypes> { TalentTypes.Briber, TalentTypes.PublicSpeaker, TalentTypes.ReadWrite, TalentTypes.Supportive } },
            { 4, new List<TalentTypes> { TalentTypes.CommandingPresence, TalentTypes.MasterOrator, TalentTypes.Schemer, TalentTypes.Suave } }
        };
    }
}

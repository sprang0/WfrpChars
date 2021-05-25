using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Investigator : CareerBase
    {
        public Investigator(int level) : base(level) { }

        public override string Name => "Investigator";

        public override string Path => Level switch
        {
            1 => "Sleuth",
            2 => "Investigator",
            3 => "Master Investigator",
            4 => "Detective",
            _ => throw new Exception("No such Level")
        };

        public override int Initiative => Bonus * Level;
        public override int Agility => Bonus * Level;
        public override int Dexterity => Bonus * Silver;
        public override int Intelligence => Bonus * Level;
        public override int Willpower => Bonus * Gold;
        public override int Fellowship => Bonus * Brass;

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Charm, SkillTypes.Climb, SkillTypes.Cool, SkillTypes.Gossip, SkillTypes.Intuition, SkillTypes.Perception, SkillTypes.StealthUrban, SkillTypes.Track } },
            { 2, new List<SkillTypes> { SkillTypes.ConsumeAlcohol, SkillTypes.Dodge, SkillTypes.LoreLaw, SkillTypes.MeleeBrawling, SkillTypes.PickLock, SkillTypes.SleightOfHand } },
            { 3, new List<SkillTypes> { SkillTypes.Bribery, SkillTypes.Evaluate, SkillTypes.Leadership, SkillTypes.LoreAny } },
            { 4, new List<SkillTypes> { SkillTypes.Intimidate, SkillTypes.LoreAny } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.AlleyCat, TalentTypes.BeneathNotice, TalentTypes.ReadWrite, TalentTypes.Sharp } },
            { 2, new List<TalentTypes> { TalentTypes.EtiquetteAny, TalentTypes.Savvy, TalentTypes.Shadow, TalentTypes.Tenacious } },
            { 3, new List<TalentTypes> { TalentTypes.Bookish, TalentTypes.BreakAndEnter, TalentTypes.SixthSense, TalentTypes.Suave } },
            { 4, new List<TalentTypes> { TalentTypes.AcuteSenseAny, TalentTypes.SavantAny, TalentTypes.Speedreader, TalentTypes.TowerOfMemories } }
        };
    }
}

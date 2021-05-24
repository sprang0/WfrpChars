using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Charm, SkillType.Climb, SkillType.Cool, SkillType.Gossip, SkillType.Intuition, SkillType.Perception, SkillType.StealthUrban, SkillType.Track } },
            { 2, new List<SkillType> { SkillType.ConsumeAlcohol, SkillType.Dodge, SkillType.LoreLaw, SkillType.MeleeBrawling, SkillType.PickLock, SkillType.SlightOfHand } },
            { 3, new List<SkillType> { SkillType.Bribery, SkillType.Evaluate, SkillType.Leadership, SkillType.LoreAny } },
            { 4, new List<SkillType> { SkillType.Intimidate, SkillType.LoreAny } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.AlleyCat, TalentType.BeneathNotice, TalentType.ReadWrite, TalentType.Sharp } },
            { 2, new List<TalentType> { TalentType.EtiquetteAny, TalentType.Savvy, TalentType.Shadow, TalentType.Tenacious } },
            { 3, new List<TalentType> { TalentType.Bookish, TalentType.BreakAndEnter, TalentType.SixthSense, TalentType.Suave } },
            { 4, new List<TalentType> { TalentType.AcuteSenseAny, TalentType.SavantAny, TalentType.Speedreader, TalentType.TowerOfMemories } }
        };
    }
}

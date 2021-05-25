using System;
using System.Collections.Generic;

namespace WfrpChars.Data.Careers
{
    class Smuggler : CareerBase
    {
        public Smuggler(int level) : base(level) { }

        public override string Name => "Smuggler";

        public override string Path => Level switch
        {
            1 => "River Runner",
            2 => "Smuggler",
            3 => "Master Smuggler",
            4 => "Smuggler King",
            _ => throw new Exception("No such Level")
        };

        public override int Initiative => Bonus * Brass;
        public override int Agility => Bonus * Level;
        public override int Dexterity => Bonus * Level;
        public override int Intelligence => Bonus * Silver;
        public override int Willpower => Bonus * Level;
        public override int Fellowship => Bonus * Gold;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Athletics, SkillType.Bribery, SkillType.Cool, SkillType.ConsumeAlcohol, SkillType.Row, SkillType.Sail, SkillType.StealthRuralOrUrban, SkillType.Swim } },
            { 2, new List<SkillType> { SkillType.Haggle, SkillType.Gossip, SkillType.LoreLocal, SkillType.MeleeBasic, SkillType.Perception, SkillType.SecretSignsSmuggler } },
            { 3, new List<SkillType> { SkillType.Evaluate, SkillType.Intimidate, SkillType.Intuition, SkillType.LoreRiverways } },
            { 4, new List<SkillType> { SkillType.LanguageAny, SkillType.Leadership } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.Criminal, TalentType.Fisherman, TalentType.StriderMarshes, TalentType.StrongBack } },
            { 2, new List<TalentType> { TalentType.Dealmaker, TalentType.EtiquetteCriminals, TalentType.Waterman, TalentType.VeryStrong } },
            { 3, new List<TalentType> { TalentType.Briber, TalentType.FearlessRiverwardens, TalentType.Pilot, TalentType.StrongSwimmer } },
            { 4, new List<TalentType> { TalentType.Kingpin, TalentType.Savvy, TalentType.StriderCoastal, TalentType.SeaLegs } }
        };
    }
}

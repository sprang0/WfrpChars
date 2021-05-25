using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Athletics, SkillTypes.Bribery, SkillTypes.Cool, SkillTypes.ConsumeAlcohol, SkillTypes.Row, SkillTypes.Sail, SkillTypes.StealthRuralOrUrban, SkillTypes.Swim } },
            { 2, new List<SkillTypes> { SkillTypes.Haggle, SkillTypes.Gossip, SkillTypes.LoreLocal, SkillTypes.MeleeBasic, SkillTypes.Perception, SkillTypes.SecretSignsSmuggler } },
            { 3, new List<SkillTypes> { SkillTypes.Evaluate, SkillTypes.Intimidate, SkillTypes.Intuition, SkillTypes.LoreRiverways } },
            { 4, new List<SkillTypes> { SkillTypes.LanguageAny, SkillTypes.Leadership } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.Criminal, TalentTypes.Fisherman, TalentTypes.StriderMarshes, TalentTypes.StrongBack } },
            { 2, new List<TalentTypes> { TalentTypes.Dealmaker, TalentTypes.EtiquetteCriminals, TalentTypes.Waterman, TalentTypes.VeryStrong } },
            { 3, new List<TalentTypes> { TalentTypes.Briber, TalentTypes.FearlessRiverwardens, TalentTypes.Pilot, TalentTypes.StrongSwimmer } },
            { 4, new List<TalentTypes> { TalentTypes.Kingpin, TalentTypes.Savvy, TalentTypes.StriderCoastal, TalentTypes.SeaLegs } }
        };
    }
}

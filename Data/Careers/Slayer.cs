using System;
using System.Collections.Generic;

namespace WfrpChars.Data.Careers
{
    class Slayer : CareerBase
    {
        public Slayer(int level) : base(level) { }

        public override string Name => "Slayer";

        public override string Path => Level switch
        {
            1 => "Troll Slayer",
            2 => "Giant Slayer",
            3 => "Dragon Slayer",
            4 => "Daemon Slayer",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Level;
        public override int Strength => Bonus * Level;
        public override int Toughness => Bonus * Brass;
        public override int Initiative => Bonus * Gold;
        public override int Agility => Bonus * Silver;
        public override int Willpower => Bonus * Level;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.ConsumeAlcohol, SkillType.Cool, SkillType.Dodge, SkillType.Endurance, SkillType.Gamble, SkillType.Heal, SkillType.LoreTrolls, SkillType.MeleeBasic } },
            { 2, new List<SkillType> { SkillType.Evaluate, SkillType.Intimidate, SkillType.LanguageBattle, SkillType.LoreGiants, SkillType.MeleeTwoHanded, SkillType.OutdoorSurvival } },
            { 3, new List<SkillType> { SkillType.EntertainStorytelling, SkillType.LoreDragons, SkillType.Perception, SkillType.RangedThrowing } },
            { 4, new List<SkillType> { SkillType.Intuition, SkillType.LoreChaos } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.DualWielder, TalentType.FearlessEverything, TalentType.Frenzy, TalentType.Slayer } },
            { 2, new List<TalentType> { TalentType.Hardy, TalentType.Implacable, TalentType.Menacing, TalentType.Reversal } },
            { 3, new List<TalentType> { TalentType.Ambidextrous, TalentType.FuriousAssault, TalentType.Relentless, TalentType.Robust } },
            { 4, new List<TalentType> { TalentType.CombatMaster, TalentType.Frightening, TalentType.StrikeMightyBlow, TalentType.VeryStrong } }
        };
    }
}

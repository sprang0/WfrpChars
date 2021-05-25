using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.ConsumeAlcohol, SkillTypes.Cool, SkillTypes.Dodge, SkillTypes.Endurance, SkillTypes.Gamble, SkillTypes.Heal, SkillTypes.LoreTrolls, SkillTypes.MeleeBasic } },
            { 2, new List<SkillTypes> { SkillTypes.Evaluate, SkillTypes.Intimidate, SkillTypes.LanguageBattle, SkillTypes.LoreGiants, SkillTypes.MeleeTwoHanded, SkillTypes.OutdoorSurvival } },
            { 3, new List<SkillTypes> { SkillTypes.EntertainStorytelling, SkillTypes.LoreDragons, SkillTypes.Perception, SkillTypes.RangedThrowing } },
            { 4, new List<SkillTypes> { SkillTypes.Intuition, SkillTypes.LoreChaos } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.DualWielder, TalentTypes.FearlessEverything, TalentTypes.Frenzy, TalentTypes.Slayer } },
            { 2, new List<TalentTypes> { TalentTypes.Hardy, TalentTypes.Implacable, TalentTypes.Menacing, TalentTypes.Reversal } },
            { 3, new List<TalentTypes> { TalentTypes.Ambidextrous, TalentTypes.FuriousAssault, TalentTypes.Relentless, TalentTypes.Robust } },
            { 4, new List<TalentTypes> { TalentTypes.CombatMaster, TalentTypes.Frightening, TalentTypes.StrikeMightyBlow, TalentTypes.VeryStrong } }
        };
    }
}

using System;
using System.Collections.Generic;

namespace WfrpChars.Data.Careers
{
    class Bailiff : CareerBase
    {
        public Bailiff(int level) : base(level) { }

        public override string Name => "Baliff";

        public override string Path => Level switch
        {
            1 => "Tax Collector",
            2 => "Bailiff",
            3 => "Reeve",
            4 => "Magistrate",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Level;
        public override int Initiative => Bonus * Level;
        public override int Agility => Bonus * Silver;
        public override int Intelligence => Bonus * Gold;
        public override int Willpower => Bonus * Level;
        public override int Fellowship => Bonus * Brass;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Cool, SkillType.Dodge, SkillType.Endurance, SkillType.Gossip, SkillType.Haggle, SkillType.Intimidate, SkillType.MeleeBasic, SkillType.Perception } },
            { 2, new List<SkillType> { SkillType.Bribery, SkillType.Charm, SkillType.Evaluate, SkillType.Intuition, SkillType.Leadership, SkillType.LoreLocal } },
            { 3, new List<SkillType> { SkillType.AnimalCare, SkillType.LoreHeraldry, SkillType.Navigation, SkillType.RideHorse } },
            { 4, new List<SkillType> { SkillType.LanguageClassical, SkillType.LoreLaw } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.Embezzle, TalentType.Numismatics, TalentType.StrongBack, TalentType.Tenacious } },
            { 2, new List<TalentType> { TalentType.BreakAndEnter, TalentType.Criminal, TalentType.PublicSpeaker, TalentType.StrikeToStun } },
            { 3, new List<TalentType> { TalentType.Kingpin, TalentType.Menacing, TalentType.NoseForTrouble, TalentType.ReadWrite } },
            { 4, new List<TalentType> { TalentType.CommandingPresence, TalentType.IronWill, TalentType.Savvy, TalentType.Schemer } }
        };
    }
}

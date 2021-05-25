using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Cool, SkillTypes.Dodge, SkillTypes.Endurance, SkillTypes.Gossip, SkillTypes.Haggle, SkillTypes.Intimidate, SkillTypes.MeleeBasic, SkillTypes.Perception } },
            { 2, new List<SkillTypes> { SkillTypes.Bribery, SkillTypes.Charm, SkillTypes.Evaluate, SkillTypes.Intuition, SkillTypes.Leadership, SkillTypes.LoreLocal } },
            { 3, new List<SkillTypes> { SkillTypes.AnimalCare, SkillTypes.LoreHeraldry, SkillTypes.Navigation, SkillTypes.RideHorse } },
            { 4, new List<SkillTypes> { SkillTypes.LanguageClassical, SkillTypes.LoreLaw } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.Embezzle, TalentTypes.Numismatics, TalentTypes.StrongBack, TalentTypes.Tenacious } },
            { 2, new List<TalentTypes> { TalentTypes.BreakAndEnter, TalentTypes.Criminal, TalentTypes.PublicSpeaker, TalentTypes.StrikeToStun } },
            { 3, new List<TalentTypes> { TalentTypes.Kingpin, TalentTypes.Menacing, TalentTypes.NoseForTrouble, TalentTypes.ReadWrite } },
            { 4, new List<TalentTypes> { TalentTypes.CommandingPresence, TalentTypes.IronWill, TalentTypes.Savvy, TalentTypes.Schemer } }
        };
    }
}

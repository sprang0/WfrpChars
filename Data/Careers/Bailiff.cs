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

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Cool, Types.Skills.Dodge, Types.Skills.Endurance, Types.Skills.Gossip, Types.Skills.Haggle, Types.Skills.Intimidate, Types.Skills.MeleeBasic, Types.Skills.Perception } },
            { 2, new List<Skills> { Types.Skills.Bribery, Types.Skills.Charm, Types.Skills.Evaluate, Types.Skills.Intuition, Types.Skills.Leadership, Types.Skills.LoreLocal } },
            { 3, new List<Skills> { Types.Skills.AnimalCare, Types.Skills.LoreHeraldry, Types.Skills.Navigation, Types.Skills.RideHorse } },
            { 4, new List<Skills> { Types.Skills.LanguageClassical, Types.Skills.LoreLaw } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.Embezzle, Types.Talents.Numismatics, Types.Talents.StrongBack, Types.Talents.Tenacious } },
            { 2, new List<Talents> { Types.Talents.BreakAndEnter, Types.Talents.Criminal, Types.Talents.PublicSpeaker, Types.Talents.StrikeToStun } },
            { 3, new List<Talents> { Types.Talents.Kingpin, Types.Talents.Menacing, Types.Talents.NoseForTrouble, Types.Talents.ReadWrite } },
            { 4, new List<Talents> { Types.Talents.CommandingPresence, Types.Talents.IronWill, Types.Talents.Savvy, Types.Talents.Schemer } }
        };
    }
}

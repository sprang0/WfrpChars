using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Witch : CareerBase
    {
        public Witch(int level) : base(level) { }

        public override string Name => "Witch";

        public override string Path => Level switch
        {
            1 => "Hexer",
            2 => "Witch",
            3 => "Wyrd",
            4 => "Warlock",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Level;
        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Brass;
        public override int Intelligence => Bonus * Gold;
        public override int Willpower => Bonus * Level;
        public override int Fellowship => Bonus * Silver;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Channelling, Types.Skills.Cool, Types.Skills.Endurance, Types.Skills.Gossip, Types.Skills.Intimidate, Types.Skills.LanguageMagick, Types.Skills.SleightOfHand, Types.Skills.StealthRural } },
            { 2, new List<Skills> { Types.Skills.CharmAnimal, Types.Skills.Dodge, Types.Skills.Intuition, Types.Skills.MeleePolearm, Types.Skills.Perception, Types.Skills.TradeHerbalist } },
            { 3, new List<Skills> { Types.Skills.Bribery, Types.Skills.Charm, Types.Skills.Haggle, Types.Skills.LoreDarkMagic } },
            { 4, new List<Skills> { Types.Skills.LoreDaemonology, Types.Skills.LoreMagic } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.Criminal, Types.Talents.InstinctiveDiction, Types.Talents.Menacing, Types.Talents.PettyMagic } },
            { 2, new List<Talents> { Types.Talents.ArcaneMagicWitchery, Types.Talents.Attractive, Types.Talents.SecondSight, Types.Talents.Witch } },
            { 3, new List<Talents> { Types.Talents.AnimalAffinity, Types.Talents.FastHands, Types.Talents.Frightening, Types.Talents.MagicalSense } },
            { 4, new List<Talents> { Types.Talents.AethyricAttunement, Types.Talents.Luck, Types.Talents.StrongMinded, Types.Talents.VeryResilient } }
        };
    }
}

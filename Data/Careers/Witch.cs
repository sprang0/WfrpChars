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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Channelling, SkillTypes.Cool, SkillTypes.Endurance, SkillTypes.Gossip, SkillTypes.Intimidate, SkillTypes.LanguageMagick, SkillTypes.SleightOfHand, SkillTypes.StealthRural } },
            { 2, new List<SkillTypes> { SkillTypes.CharmAnimal, SkillTypes.Dodge, SkillTypes.Intuition, SkillTypes.MeleePolearm, SkillTypes.Perception, SkillTypes.TradeHerbalist } },
            { 3, new List<SkillTypes> { SkillTypes.Bribery, SkillTypes.Charm, SkillTypes.Haggle, SkillTypes.LoreDarkMagic } },
            { 4, new List<SkillTypes> { SkillTypes.LoreDaemonology, SkillTypes.LoreMagic } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.Criminal, TalentTypes.InstinctiveDiction, TalentTypes.Menacing, TalentTypes.PettyMagic } },
            { 2, new List<TalentTypes> { TalentTypes.ArcaneMagicWitchery, TalentTypes.Attractive, TalentTypes.SecondSight, TalentTypes.Witch } },
            { 3, new List<TalentTypes> { TalentTypes.AnimalAffinity, TalentTypes.FastHands, TalentTypes.Frightening, TalentTypes.MagicalSense } },
            { 4, new List<TalentTypes> { TalentTypes.AethyricAttunement, TalentTypes.Luck, TalentTypes.StrongMinded, TalentTypes.VeryResilient } }
        };
    }
}

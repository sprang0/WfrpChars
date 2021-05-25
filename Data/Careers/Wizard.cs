using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Wizard : CareerBase
    {
        public Wizard(int level) : base(level) { }

        public override string Name => "Wizard";

        public override string Path => Level switch
        {
            1 => "Wizard's Apprentice",
            2 => "Wizard",
            3 => "Master Wizard",
            4 => "Wizard Lord",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Level;
        public override int Initiative => Bonus * Silver;
        public override int Agility => Bonus * Brass;
        public override int Intelligence => Bonus * Level;
        public override int Willpower => Bonus * Level;
        public override int Fellowship => Bonus * Gold;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.ChannellingAnyColour, Types.Skills.Dodge, Types.Skills.Intuition, Types.Skills.LanguageMagick, Types.Skills.LoreMagic, Types.Skills.MeleeBasic, Types.Skills.MeleePolearm, Types.Skills.Perception } },
            { 2, new List<Skills> { Types.Skills.Charm, Types.Skills.Cool, Types.Skills.Gossip, Types.Skills.Intimidate, Types.Skills.LanguageBattle, Types.Skills.LanguageAny } },
            { 3, new List<Skills> { Types.Skills.AnimalCare, Types.Skills.Evaluate, Types.Skills.LoreWarfare, Types.Skills.RideHorse } },
            { 4, new List<Skills> { Types.Skills.LanguageAny, Types.Skills.LoreAny } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.AethyricAttunement, Types.Talents.PettyMagic, Types.Talents.ReadWrite, Types.Talents.SecondSight } },
            { 2, new List<Talents> { Types.Talents.ArcaneMagicAnyArcaneLore, Types.Talents.DetectArtefact, Types.Talents.FastHands, Types.Talents.SixthSense } },
            { 3, new List<Talents> { Types.Talents.DualWielder, Types.Talents.InstinctiveDiction, Types.Talents.MagicalSense, Types.Talents.Menacing } },
            { 4, new List<Talents> { Types.Talents.CombatAware, Types.Talents.Frightening, Types.Talents.IronWill, Types.Talents.WarWizard } }
        };
    }
}

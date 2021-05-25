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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.ChannellingAnyColour, SkillTypes.Dodge, SkillTypes.Intuition, SkillTypes.LanguageMagick, SkillTypes.LoreMagic, SkillTypes.MeleeBasic, SkillTypes.MeleePolearm, SkillTypes.Perception } },
            { 2, new List<SkillTypes> { SkillTypes.Charm, SkillTypes.Cool, SkillTypes.Gossip, SkillTypes.Intimidate, SkillTypes.LanguageBattle, SkillTypes.LanguageAny } },
            { 3, new List<SkillTypes> { SkillTypes.AnimalCare, SkillTypes.Evaluate, SkillTypes.LoreWarfare, SkillTypes.RideHorse } },
            { 4, new List<SkillTypes> { SkillTypes.LanguageAny, SkillTypes.LoreAny } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.AethyricAttunement, TalentTypes.PettyMagic, TalentTypes.ReadWrite, TalentTypes.SecondSight } },
            { 2, new List<TalentTypes> { TalentTypes.ArcaneMagicAnyArcaneLore, TalentTypes.DetectArtefact, TalentTypes.FastHands, TalentTypes.SixthSense } },
            { 3, new List<TalentTypes> { TalentTypes.DualWielder, TalentTypes.InstinctiveDiction, TalentTypes.MagicalSense, TalentTypes.Menacing } },
            { 4, new List<TalentTypes> { TalentTypes.CombatAware, TalentTypes.Frightening, TalentTypes.IronWill, TalentTypes.WarWizard } }
        };
    }
}

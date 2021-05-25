using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class WitchHunter : CareerBase
    {
        public WitchHunter(int level) : base(level) { }

        public override string Name => "Witch Hunter";

        public override string Path => Level switch
        {
            1 => "Interrogator",
            2 => "Witch Hunter",
            3 => "Inquisitor",
            4 => "Witchfinder General",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Level;
        public override int BallisticSkill => Bonus * Brass;
        public override int Toughness => Bonus * Level;
        public override int Intelligence => Bonus * Gold;
        public override int Willpower => Bonus * Level;
        public override int Fellowship => Bonus * Silver;

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Charm, SkillTypes.ConsumeAlcohol, SkillTypes.Heal, SkillTypes.Intimidate, SkillTypes.Intuition, SkillTypes.LoreTorture, SkillTypes.MeleeBrawling, SkillTypes.Perception } },
            { 2, new List<SkillTypes> { SkillTypes.Cool, SkillTypes.Gossip, SkillTypes.MeleeBasic, SkillTypes.LoreWitches, SkillTypes.RangedAny, SkillTypes.RideHorse } },
            { 3, new List<SkillTypes> { SkillTypes.Endurance, SkillTypes.Leadership, SkillTypes.LoreLaw, SkillTypes.LoreLocal } },
            { 4, new List<SkillTypes> { SkillTypes.LoreChaos, SkillTypes.LorePolitics } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.Coolheaded, TalentTypes.Menacing, TalentTypes.ReadWrite, TalentTypes.Resolute } },
            { 2, new List<TalentTypes> { TalentTypes.DualWielder, TalentTypes.Marksman, TalentTypes.SeasonedTraveler, TalentTypes.Shadow } },
            { 3, new List<TalentTypes> { TalentTypes.FearlessWitches, TalentTypes.NoseForTrouble, TalentTypes.Relentless, TalentTypes.StrongMinded } },
            { 4, new List<TalentTypes> { TalentTypes.Frightening, TalentTypes.IronWill, TalentTypes.MagicalSense, TalentTypes.PureSoul } }
        };
    }
}

using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Soldier : CareerBase
    {
        public Soldier(int level) : base(level) { }

        public override string Name => "Soldier";

        public override string Path => Level switch
        {
            1 => "Recruit",
            2 => "Soldier",
            3 => "Sergeant",
            4 => "Officer",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Level;
        public override int BallisticSkill => Bonus * Brass;
        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Silver;
        public override int Willpower => Bonus * Level;
        public override int Fellowship => Bonus * Gold;

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Athletics, SkillTypes.Climb, SkillTypes.Cool, SkillTypes.Dodge, SkillTypes.Endurance, SkillTypes.LanguageBattle, SkillTypes.MeleeBasic, SkillTypes.PlayDrumOrFife } },
            { 2, new List<SkillTypes> { SkillTypes.ConsumeAlcohol, SkillTypes.Gamble, SkillTypes.Gossip, SkillTypes.MeleeAny, SkillTypes.RangedAny, SkillTypes.OutdoorSurvival } },
            { 3, new List<SkillTypes> { SkillTypes.Heal, SkillTypes.Intuition, SkillTypes.Leadership, SkillTypes.Perception } },
            { 4, new List<SkillTypes> { SkillTypes.LoreWarfare, SkillTypes.Navigation } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.Diceman, TalentTypes.Marksman, TalentTypes.StrongBack, TalentTypes.WarriorBorn } },
            { 2, new List<TalentTypes> { TalentTypes.Drilled, TalentTypes.EtiquetteSoldiers, TalentTypes.RapidReload, TalentTypes.Shieldsman } },
            { 3, new List<TalentTypes> { TalentTypes.CombatAware, TalentTypes.EnclosedFighter, TalentTypes.Unshakeable, TalentTypes.Warleader } },
            { 4, new List<TalentTypes> { TalentTypes.Inspiring, TalentTypes.PublicSpeaker, TalentTypes.SeasonedTraveler, TalentTypes.StoutHearted } }
        };
    }
}

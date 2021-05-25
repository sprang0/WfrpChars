using System;
using System.Collections.Generic;

namespace WfrpChars.Data.Careers
{
    class Racketeer : CareerBase
    {
        public Racketeer(int level) : base(level) { }

        public override string Name => "Racketeer";

        public override string Path => Level switch
        {
            1 => "Thug",
            2 => "Racketeer",
            3 => "Gang Boss",
            4 => "Crime Lord",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Level;
        public override int Strength => Bonus * Level;
        public override int Toughness => Bonus * Level;
        public override int Intelligence => Bonus * Gold;
        public override int Willpower => Bonus * Silver;
        public override int Fellowship => Bonus * Brass;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.ConsumeAlcohol, SkillType.Cool, SkillType.Dodge, SkillType.Endurance, SkillType.Intimidate, SkillType.LoreLocal, SkillType.MeleeBrawling, SkillType.StealthUrban } },
            { 2, new List<SkillType> { SkillType.Bribery, SkillType.Charm, SkillType.Evaluate, SkillType.Gossip, SkillType.LanguageEstalianOrTilean, SkillType.MeleeBasic } },
            { 3, new List<SkillType> { SkillType.Intuition, SkillType.Leadership, SkillType.Perception, SkillType.RangedCrossbow } },
            { 4, new List<SkillType> { SkillType.LoreLaw, SkillType.LorePolitics } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.Criminal, TalentType.EtiquetteCriminals, TalentType.Menacing, TalentType.StrikeMightyBlow } },
            { 2, new List<TalentType> { TalentType.DirtyFighting, TalentType.Embezzle, TalentType.StrikeToStun, TalentType.WarriorBorn } },
            { 3, new List<TalentType> { TalentType.FearlessWatchmen, TalentType.IronWill, TalentType.ResistancePoison, TalentType.Robust } },
            { 4, new List<TalentType> { TalentType.CommandingPresence, TalentType.Kingpin, TalentType.Frightening, TalentType.Wealthy } }
        };
    }
}

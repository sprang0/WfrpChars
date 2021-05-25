using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.ConsumeAlcohol, SkillTypes.Cool, SkillTypes.Dodge, SkillTypes.Endurance, SkillTypes.Intimidate, SkillTypes.LoreLocal, SkillTypes.MeleeBrawling, SkillTypes.StealthUrban } },
            { 2, new List<SkillTypes> { SkillTypes.Bribery, SkillTypes.Charm, SkillTypes.Evaluate, SkillTypes.Gossip, SkillTypes.LanguageEstalianOrTilean, SkillTypes.MeleeBasic } },
            { 3, new List<SkillTypes> { SkillTypes.Intuition, SkillTypes.Leadership, SkillTypes.Perception, SkillTypes.RangedCrossbow } },
            { 4, new List<SkillTypes> { SkillTypes.LoreLaw, SkillTypes.LorePolitics } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.Criminal, TalentTypes.EtiquetteCriminals, TalentTypes.Menacing, TalentTypes.StrikeMightyBlow } },
            { 2, new List<TalentTypes> { TalentTypes.DirtyFighting, TalentTypes.Embezzle, TalentTypes.StrikeToStun, TalentTypes.WarriorBorn } },
            { 3, new List<TalentTypes> { TalentTypes.FearlessWatchmen, TalentTypes.IronWill, TalentTypes.ResistancePoison, TalentTypes.Robust } },
            { 4, new List<TalentTypes> { TalentTypes.CommandingPresence, TalentTypes.Kingpin, TalentTypes.Frightening, TalentTypes.Wealthy } }
        };
    }
}

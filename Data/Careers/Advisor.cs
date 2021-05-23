﻿using System.Collections.Generic;
using WfrpChars.Data.Skills;

namespace WfrpChars.Data.Careers
{
    class Advisor : CareerBase
    {
        public Advisor(int level) : base(level) { }

        public override string Name => "Advisor";

        public override string Path => Level switch
        {
            1 => "Aide",
            2 => "Advisor",
            3 => "Counsellor",
            4 => "Chancellor",
            _ => "def"
        };

        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Level;
        public override int Agility => Bonus * Level;
        public override int Intelligence => Bonus * Silver;
        public override int Willpower => Bonus * Gold;
        public override int Fellowship => Bonus * Brass;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Bribery, SkillType.ConsumeAlcohol, SkillType.Endurance, SkillType.Gossip, SkillType.Haggle, SkillType.LanguageClassical, SkillType.LorePolitics, SkillType.Perception } },
            { 2, new List<SkillType> { SkillType.Charm, SkillType.Cool, SkillType.Evaluate, SkillType.Gamble, SkillType.Intuition, SkillType.LoreLocal } },
            { 3, new List<SkillType> { SkillType.EntertainStorytelling, SkillType.Leadership, SkillType.LanguageAny, SkillType.LoreAny } },
            { 4, new List<SkillType> { SkillType.LoreHeraldry, SkillType.RideHorse } }
        };
    }
}
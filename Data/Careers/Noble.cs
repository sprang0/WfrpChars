using System;
using System.Collections.Generic;

namespace WfrpChars.Data.Careers
{
    class Noble : CareerBase
    {
        public Noble(int level) : base(level) { }

        public override string Name => "Noble";

        public override string Path => Level switch
        {
            1 => "Scion",
            2 => "Noble",
            3 => "Magnate",
            4 => "Noble Lord",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Level;
        public override int Initiative => Bonus * Level;
        public override int Dexterity => Bonus * Level;
        public override int Intelligence => Bonus * Silver;
        public override int Willpower => Bonus * Gold;
        public override int Fellowship => Bonus * Brass;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Bribery, SkillType.ConsumeAlcohol, SkillType.Gamble, SkillType.Intimidate, SkillType.Leadership, SkillType.LoreHeraldry, SkillType.MeleeFencing, SkillType.PlayAny } },
            { 2, new List<SkillType> { SkillType.Charm, SkillType.Gossip, SkillType.LanguageClassical, SkillType.LoreLocal, SkillType.RideHorse, SkillType.MeleeParry } },
            { 3, new List<SkillType> { SkillType.LanguageAny, SkillType.Intuition, SkillType.LorePolitics, SkillType.Perception } },
            { 4, new List<SkillType> { SkillType.LoreAny, SkillType.Track } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.EtiquetteNobles, TalentType.Luck, TalentType.NobleBlood, TalentType.ReadWrite } },
            { 2, new List<TalentType> { TalentType.Attractive, TalentType.Briber, TalentType.Carouser, TalentType.Suave } },
            { 3, new List<TalentType> { TalentType.Coolheaded, TalentType.Dealmaker, TalentType.PublicSpeaker, TalentType.Schemer } },
            { 4, new List<TalentType> { TalentType.CommandingPresence, TalentType.IronWill, TalentType.Warleader, TalentType.Wealthy } }
        };
    }
}

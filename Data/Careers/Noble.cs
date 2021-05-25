using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Bribery, SkillTypes.ConsumeAlcohol, SkillTypes.Gamble, SkillTypes.Intimidate, SkillTypes.Leadership, SkillTypes.LoreHeraldry, SkillTypes.MeleeFencing, SkillTypes.PlayAny } },
            { 2, new List<SkillTypes> { SkillTypes.Charm, SkillTypes.Gossip, SkillTypes.LanguageClassical, SkillTypes.LoreLocal, SkillTypes.RideHorse, SkillTypes.MeleeParry } },
            { 3, new List<SkillTypes> { SkillTypes.LanguageAny, SkillTypes.Intuition, SkillTypes.LorePolitics, SkillTypes.Perception } },
            { 4, new List<SkillTypes> { SkillTypes.LoreAny, SkillTypes.Track } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.EtiquetteNobles, TalentTypes.Luck, TalentTypes.NobleBlood, TalentTypes.ReadWrite } },
            { 2, new List<TalentTypes> { TalentTypes.Attractive, TalentTypes.Briber, TalentTypes.Carouser, TalentTypes.Suave } },
            { 3, new List<TalentTypes> { TalentTypes.Coolheaded, TalentTypes.Dealmaker, TalentTypes.PublicSpeaker, TalentTypes.Schemer } },
            { 4, new List<TalentTypes> { TalentTypes.CommandingPresence, TalentTypes.IronWill, TalentTypes.Warleader, TalentTypes.Wealthy } }
        };
    }
}

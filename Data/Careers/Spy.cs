using System;
using System.Collections.Generic;

namespace WfrpChars.Data.Careers
{
    class Spy : CareerBase
    {
        public Spy(int level) : base(level) { }

        public override string Name => "Spy";

        public override string Path => Level switch
        {
            1 => "Informer",
            2 => "Spy",
            3 => "Agent",
            4 => "Spymaster",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Brass;
        public override int Initiative => Bonus * Silver;
        public override int Agility => Bonus * Level;
        public override int Intelligence => Bonus * Gold;
        public override int Willpower => Bonus * Level;
        public override int Fellowship => Bonus * Level;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Bribery, SkillType.Charm, SkillType.Cool, SkillType.Gamble, SkillType.Gossip, SkillType.Haggle, SkillType.Perception, SkillType.StealthAny } },
            { 2, new List<SkillType> { SkillType.Climb, SkillType.EntertainActing, SkillType.Intuition, SkillType.MeleeBasic, SkillType.SecretSignsAny, SkillType.SleightOfHand } },
            { 3, new List<SkillType> { SkillType.AnimalCare, SkillType.AnimalTrainingPigeon, SkillType.LanguageAny, SkillType.Leadership } },
            { 4, new List<SkillType> { SkillType.LoreAny, SkillType.Research } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.Blather, TalentType.Carouser, TalentType.Gregarious, TalentType.Shadow } },
            { 2, new List<TalentType> { TalentType.EtiquetteAny, TalentType.LipReading, TalentType.ReadWrite, TalentType.SecretIdentity } },
            { 3, new List<TalentType> { TalentType.Attractive, TalentType.CatTongued, TalentType.MasterOfDisguise, TalentType.Mimic } },
            { 4, new List<TalentType> { TalentType.Briber, TalentType.Schemer, TalentType.Suave, TalentType.TowerOfMemories } }
        };
    }
}

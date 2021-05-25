using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Bribery, SkillTypes.Charm, SkillTypes.Cool, SkillTypes.Gamble, SkillTypes.Gossip, SkillTypes.Haggle, SkillTypes.Perception, SkillTypes.StealthAny } },
            { 2, new List<SkillTypes> { SkillTypes.Climb, SkillTypes.EntertainActing, SkillTypes.Intuition, SkillTypes.MeleeBasic, SkillTypes.SecretSignsAny, SkillTypes.SleightOfHand } },
            { 3, new List<SkillTypes> { SkillTypes.AnimalCare, SkillTypes.AnimalTrainingPigeon, SkillTypes.LanguageAny, SkillTypes.Leadership } },
            { 4, new List<SkillTypes> { SkillTypes.LoreAny, SkillTypes.Research } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.Blather, TalentTypes.Carouser, TalentTypes.Gregarious, TalentTypes.Shadow } },
            { 2, new List<TalentTypes> { TalentTypes.EtiquetteAny, TalentTypes.LipReading, TalentTypes.ReadWrite, TalentTypes.SecretIdentity } },
            { 3, new List<TalentTypes> { TalentTypes.Attractive, TalentTypes.CatTongued, TalentTypes.MasterOfDisguise, TalentTypes.Mimic } },
            { 4, new List<TalentTypes> { TalentTypes.Briber, TalentTypes.Schemer, TalentTypes.Suave, TalentTypes.TowerOfMemories } }
        };
    }
}

using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Merchant : CareerBase
    {
        public Merchant(int level) : base(level) { }

        public override string Name => "Merchant";

        public override string Path => Level switch
        {
            1 => "Trader",
            2 => "Merchant",
            3 => "Master Merchant",
            4 => "Merchant Prince",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Gold;
        public override int Initiative => Bonus * Silver;
        public override int Agility => Bonus * Level;
        public override int Intelligence => Bonus * Brass;
        public override int Willpower => Bonus * Level;
        public override int Fellowship => Bonus * Level;

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.AnimalCare, SkillTypes.Bribery, SkillTypes.Charm, SkillTypes.ConsumeAlcohol, SkillTypes.Drive, SkillTypes.Gamble, SkillTypes.Gossip, SkillTypes.Haggle } },
            { 2, new List<SkillTypes> { SkillTypes.Evaluate, SkillTypes.Intuition, SkillTypes.LanguageAny, SkillTypes.LanguageGuilder, SkillTypes.LoreLocal, SkillTypes.Perception } },
            { 3, new List<SkillTypes> { SkillTypes.Cool, SkillTypes.LanguageClassical, SkillTypes.Navigation, SkillTypes.SecretSignsGuilder } },
            { 4, new List<SkillTypes> { SkillTypes.LoreAny, SkillTypes.Intimidate } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.Blather, TalentTypes.Dealmaker, TalentTypes.ReadWrite, TalentTypes.Suave } },
            { 2, new List<TalentTypes> { TalentTypes.Briber, TalentTypes.Embezzle, TalentTypes.EtiquetteGuilder, TalentTypes.Savvy } },
            { 3, new List<TalentTypes> { TalentTypes.CatTongued, TalentTypes.EtiquetteAny, TalentTypes.Numismatics, TalentTypes.Sharp } },
            { 4, new List<TalentTypes> { TalentTypes.IronWill, TalentTypes.Luck, TalentTypes.Schemer, TalentTypes.Wealthy } }
        };
    }
}

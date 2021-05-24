using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.AnimalCare, SkillType.Bribery, SkillType.Charm, SkillType.ConsumeAlcohol, SkillType.Drive, SkillType.Gamble, SkillType.Gossip, SkillType.Haggle } },
            { 2, new List<SkillType> { SkillType.Evaluate, SkillType.Intuition, SkillType.LanguageAny, SkillType.LanguageGuilder, SkillType.LoreLocal, SkillType.Perception } },
            { 3, new List<SkillType> { SkillType.Cool, SkillType.LanguageClassical, SkillType.Navigation, SkillType.SecretSignsGuilder } },
            { 4, new List<SkillType> { SkillType.LoreAny, SkillType.Intimidate } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.Blather, TalentType.Dealmaker, TalentType.ReadWrite, TalentType.Suave } },
            { 2, new List<TalentType> { TalentType.Briber, TalentType.Embezzle, TalentType.EtiquetteGuilder, TalentType.Savvy } },
            { 3, new List<TalentType> { TalentType.CatTongued, TalentType.EtiquetteAny, TalentType.Numismatics, TalentType.Sharp } },
            { 4, new List<TalentType> { TalentType.IronWill, TalentType.Luck, TalentType.Schemer, TalentType.Wealthy } }
        };
    }
}

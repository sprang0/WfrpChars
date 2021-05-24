using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WfrpChars.Data.Careers
{
    class Knight : CareerBase
    {
        public Knight(int level) : base(level)        {        }

        public override string Name => "Knight";

        public override string Path => Level switch
        {
            1 => "Squire",
            2 => "Knight",
            3 => "First Knight",
            4 => "Knight of the Inner Circle",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Brass;
        public override int Strength => Bonus * Level;
        public override int Initiative => Bonus * Level;
        public override int Agility => Bonus * Level;
        public override int Willpower => Bonus * Silver;
        public override int Fellowship => Bonus * Gold;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Athletics, SkillType.AnimalCare, SkillType.CharmAnimal, SkillType.Heal, SkillType.LoreHeraldry, SkillType.MeleeCavalry, SkillType.RideHorse, SkillType.TradeFarrier } },
            { 2, new List<SkillType> { SkillType.Cool, SkillType.Dodge, SkillType.Endurance, SkillType.Intimidate, SkillType.LanguageBattle, SkillType.MeleeAny } },
            { 3, new List<SkillType> { SkillType.Charm, SkillType.ConsumeAlcohol, SkillType.Leadership, SkillType.LoreWarfare } },
            { 4, new List<SkillType> { SkillType.LoreAny, SkillType.SecretSignsKnightlyOrder } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.EtiquetteAny, TalentType.Roughrider, TalentType.Sturdy, TalentType.WarriorBorn } },
            { 2, new List<TalentType> { TalentType.Menacing, TalentType.SeasonedTraveler, TalentType.Shieldsman, TalentType.StrikeMightyBlow } },
            { 3, new List<TalentType> { TalentType.FearlessAny, TalentType.StoutHearted, TalentType.Unshakable, TalentType.Warleader } },
            { 4, new List<TalentType> { TalentType.Disarm, TalentType.Inspiring, TalentType.IronWill, TalentType.StrikeToInjure } }
        };
    }
}

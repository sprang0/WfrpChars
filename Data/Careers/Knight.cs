using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Knight : CareerBase
    {
        public Knight(int level) : base(level) { }

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Athletics, SkillTypes.AnimalCare, SkillTypes.CharmAnimal, SkillTypes.Heal, SkillTypes.LoreHeraldry, SkillTypes.MeleeCavalry, SkillTypes.RideHorse, SkillTypes.TradeFarrier } },
            { 2, new List<SkillTypes> { SkillTypes.Cool, SkillTypes.Dodge, SkillTypes.Endurance, SkillTypes.Intimidate, SkillTypes.LanguageBattle, SkillTypes.MeleeAny } },
            { 3, new List<SkillTypes> { SkillTypes.Charm, SkillTypes.ConsumeAlcohol, SkillTypes.Leadership, SkillTypes.LoreWarfare } },
            { 4, new List<SkillTypes> { SkillTypes.LoreAny, SkillTypes.SecretSignsKnightlyOrder } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.EtiquetteAny, TalentTypes.Roughrider, TalentTypes.Sturdy, TalentTypes.WarriorBorn } },
            { 2, new List<TalentTypes> { TalentTypes.Menacing, TalentTypes.SeasonedTraveler, TalentTypes.Shieldsman, TalentTypes.StrikeMightyBlow } },
            { 3, new List<TalentTypes> { TalentTypes.FearlessAny, TalentTypes.StoutHearted, TalentTypes.Unshakeable, TalentTypes.Warleader } },
            { 4, new List<TalentTypes> { TalentTypes.Disarm, TalentTypes.Inspiring, TalentTypes.IronWill, TalentTypes.StrikeToInjure } }
        };
    }
}

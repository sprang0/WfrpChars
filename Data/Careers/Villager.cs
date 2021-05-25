using System;
using System.Collections.Generic;

namespace WfrpChars.Data.Careers
{
    class Villager : CareerBase
    {
        public Villager(int level) : base(level) { }

        public override string Name => "Villager";

        public override string Path => Level switch
        {
            1 => "Peasant",
            2 => "Villager",
            3 => "Councillor",
            4 => "Village Elder",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Brass;
        public override int Strength => Bonus * Level;
        public override int Toughness => Bonus * Level;
        public override int Agility => Bonus * Level;
        public override int Intelligence => Bonus * Gold;
        public override int Fellowship => Bonus * Silver;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.AnimalCare, SkillType.Athletics, SkillType.ConsumeAlcohol, SkillType.Endurance, SkillType.Gossip, SkillType.MeleeBrawling, SkillType.LoreLocal, SkillType.OutdoorSurvival } },
            { 2, new List<SkillType> { SkillType.Dodge, SkillType.Drive, SkillType.EntertainStorytelling, SkillType.Haggle, SkillType.MeleeBasic, SkillType.TradeAny } },
            { 3, new List<SkillType> { SkillType.Bribery, SkillType.Charm, SkillType.Intimidate, SkillType.Leadership } },
            { 4, new List<SkillType> { SkillType.Intuition, SkillType.LoreHistory } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.Rover, TalentType.StrongBack, TalentType.StrongMinded, TalentType.StoneSoup } },
            { 2, new List<TalentType> { TalentType.AnimalAffinity, TalentType.Hardy, TalentType.Tenacious, TalentType.VeryStrong } },
            { 3, new List<TalentType> { TalentType.CraftsmanAny, TalentType.Dealmaker, TalentType.StoutHearted, TalentType.VeryResilient } },
            { 4, new List<TalentType> { TalentType.MasterTradesmanAny, TalentType.NimbleFingered, TalentType.PublicSpeaker, TalentType.SavantLocal } }
        };
    }
}

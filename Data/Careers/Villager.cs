using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.AnimalCare, SkillTypes.Athletics, SkillTypes.ConsumeAlcohol, SkillTypes.Endurance, SkillTypes.Gossip, SkillTypes.MeleeBrawling, SkillTypes.LoreLocal, SkillTypes.OutdoorSurvival } },
            { 2, new List<SkillTypes> { SkillTypes.Dodge, SkillTypes.Drive, SkillTypes.EntertainStorytelling, SkillTypes.Haggle, SkillTypes.MeleeBasic, SkillTypes.TradeAny } },
            { 3, new List<SkillTypes> { SkillTypes.Bribery, SkillTypes.Charm, SkillTypes.Intimidate, SkillTypes.Leadership } },
            { 4, new List<SkillTypes> { SkillTypes.Intuition, SkillTypes.LoreHistory } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.Rover, TalentTypes.StrongBack, TalentTypes.StrongMinded, TalentTypes.StoneSoup } },
            { 2, new List<TalentTypes> { TalentTypes.AnimalAffinity, TalentTypes.Hardy, TalentTypes.Tenacious, TalentTypes.VeryStrong } },
            { 3, new List<TalentTypes> { TalentTypes.CraftsmanAny, TalentTypes.Dealmaker, TalentTypes.StoutHearted, TalentTypes.VeryResilient } },
            { 4, new List<TalentTypes> { TalentTypes.MasterTradesmanAny, TalentTypes.NimbleFingered, TalentTypes.PublicSpeaker, TalentTypes.SavantLocal } }
        };
    }
}

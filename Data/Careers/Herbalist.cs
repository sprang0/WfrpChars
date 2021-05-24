using System;
using System.Collections.Generic;

namespace WfrpChars.Data.Careers
{
    class Herbalist : CareerBase
    {
        public Herbalist(int level) : base(level) { }

        public override string Name => "Herbalist";

        public override string Path => Level switch
        {
            1 => "Herb Gatherer",
            2 => "Herbalist",
            3 => "Herb Master",
            4 => "Herbwise",
            _ => throw new Exception("No such Level")
        };

        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Level;
        public override int Agility => Bonus * Level;
        public override int Dexterity => Bonus * Brass;
        public override int Intelligence => Bonus * Gold;
        public override int Fellowship => Bonus * Silver;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.CharmAnimal, SkillType.Climb, SkillType.Endurance, SkillType.LoreHerbs, SkillType.OutdoorSurvival, SkillType.Perception, SkillType.Swim, SkillType.TradeHerbalist } },
            { 2, new List<SkillType> { SkillType.ConsumeAlcohol, SkillType.Cool, SkillType.Gossip, SkillType.Haggle, SkillType.Heal, SkillType.LoreLocal } },
            { 3, new List<SkillType> { SkillType.Intuition, SkillType.Leadership, SkillType.LoreMedicine, SkillType.TradePoisons } },
            { 4, new List<SkillType> { SkillType.Drive, SkillType.Navigation } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.AcuteSenseTaste, TalentType.Orientation, TalentType.Rover, TalentType.StriderAny } },
            { 2, new List<TalentType> { TalentType.Dealmaker, TalentType.NimbleFingered, TalentType.Sharp, TalentType.Sturdy } },
            { 3, new List<TalentType> { TalentType.CraftsmanHerbalist, TalentType.FieldDressing, TalentType.Hardy, TalentType.Savvy } },
            { 4, new List<TalentType> { TalentType.Concoct, TalentType.MasterTradesmanHerbalist, TalentType.ResistancePoison, TalentType.SavantHerbs } }
        };
    }
}

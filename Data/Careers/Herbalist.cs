using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.CharmAnimal, SkillTypes.Climb, SkillTypes.Endurance, SkillTypes.LoreHerbs, SkillTypes.OutdoorSurvival, SkillTypes.Perception, SkillTypes.Swim, SkillTypes.TradeHerbalist } },
            { 2, new List<SkillTypes> { SkillTypes.ConsumeAlcohol, SkillTypes.Cool, SkillTypes.Gossip, SkillTypes.Haggle, SkillTypes.Heal, SkillTypes.LoreLocal } },
            { 3, new List<SkillTypes> { SkillTypes.Intuition, SkillTypes.Leadership, SkillTypes.LoreMedicine, SkillTypes.TradePoisons } },
            { 4, new List<SkillTypes> { SkillTypes.Drive, SkillTypes.Navigation } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.AcuteSenseTaste, TalentTypes.Orientation, TalentTypes.Rover, TalentTypes.StriderAny } },
            { 2, new List<TalentTypes> { TalentTypes.Dealmaker, TalentTypes.NimbleFingered, TalentTypes.Sharp, TalentTypes.Sturdy } },
            { 3, new List<TalentTypes> { TalentTypes.CraftsmanHerbalist, TalentTypes.FieldDressing, TalentTypes.Hardy, TalentTypes.Savvy } },
            { 4, new List<TalentTypes> { TalentTypes.Concoct, TalentTypes.MasterTradesmanHerbalist, TalentTypes.ResistancePoison, TalentTypes.SavantHerbs } }
        };
    }
}

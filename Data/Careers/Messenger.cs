using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Messenger : CareerBase
    {
        public Messenger(int level) : base(level) { }

        public override string Name => "Messenger";

        public override string Path => Level switch
        {
            1 => "Runner",
            2 => "Messenger",
            3 => "Courier",
            4 => "Courier-Captain",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Brass;
        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Level;
        public override int Agility => Bonus * Level;
        public override int Willpower => Bonus * Silver;
        public override int Fellowship => Bonus * Gold;

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Athletics, SkillTypes.Climb, SkillTypes.Dodge, SkillTypes.Endurance, SkillTypes.Gossip, SkillTypes.Navigation, SkillTypes.Perception, SkillTypes.MeleeBrawling } },
            { 2, new List<SkillTypes> { SkillTypes.AnimalCare, SkillTypes.Charm, SkillTypes.Cool, SkillTypes.LoreLocal, SkillTypes.MeleeBasic, SkillTypes.RideHorse } },
            { 3, new List<SkillTypes> { SkillTypes.CharmAnimal, SkillTypes.Bribery, SkillTypes.ConsumeAlcohol, SkillTypes.OutdoorSurvival } },
            { 4, new List<SkillTypes> { SkillTypes.Intimidate, SkillTypes.Leadership } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.Flee, TalentTypes.FleetFooted, TalentTypes.Sprinter, TalentTypes.StepAside } },
            { 2, new List<TalentTypes> { TalentTypes.CrackTheWhip, TalentTypes.Criminal, TalentTypes.Orientation, TalentTypes.SeasonedTraveler } },
            { 3, new List<TalentTypes> { TalentTypes.NoseForTrouble, TalentTypes.Relentless, TalentTypes.Tenacious, TalentTypes.TrickRiding } },
            { 4, new List<TalentTypes> { TalentTypes.Dealmaker, TalentTypes.HatredOutlaws, TalentTypes.Kingpin, TalentTypes.VeryResilient } }
        };
    }
}

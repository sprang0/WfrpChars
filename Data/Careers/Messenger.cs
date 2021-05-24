using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Athletics, SkillType.Climb, SkillType.Dodge, SkillType.Endurance, SkillType.Gossip, SkillType.Navigation, SkillType.Perception, SkillType.MeleeBrawling } },
            { 2, new List<SkillType> { SkillType.AnimalCare, SkillType.Charm, SkillType.Cool, SkillType.LoreLocal, SkillType.MeleeBasic, SkillType.RideHorse } },
            { 3, new List<SkillType> { SkillType.CharmAnimal, SkillType.Bribery, SkillType.ConsumeAlcohol, SkillType.OutdoorSurvival } },
            { 4, new List<SkillType> { SkillType.Intimidate, SkillType.Leadership } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.Flee, TalentType.FleetFooted, TalentType.Sprinter, TalentType.StepAside } },
            { 2, new List<TalentType> { TalentType.CrackTheWhip, TalentType.Criminal, TalentType.Orientation, TalentType.SeasonedTraveler } },
            { 3, new List<TalentType> { TalentType.NoseForTrouble, TalentType.Relentless, TalentType.Tenacious, TalentType.TrickRiding } },
            { 4, new List<TalentType> { TalentType.Dealmaker, TalentType.HatredOutlaws, TalentType.Kingpin, TalentType.VeryResilient } }
        };
    }
}

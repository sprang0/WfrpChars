using System;
using System.Collections.Generic;

namespace WfrpChars.Data.Careers
{
    class RoadWarden : CareerBase
    {
        public RoadWarden(int level) : base(level) { }

        public override string Name => "Road Warden";

        public override string Path => Level switch
        {
            1 => "Toll Keeper",
            2 => "Road Warden",
            3 => "Road Sergeant",
            4 => "Road Captain",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Brass;
        public override int BallisticSkill => Bonus * Level;
        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Level;
        public override int Intelligence => Bonus * Gold;
        public override int Fellowship => Bonus * Silver;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Bribery, SkillType.ConsumeAlcohol, SkillType.Gamble, SkillType.Gossip, SkillType.Haggle, SkillType.MeleeBasic, SkillType.Perception, SkillType.RangedCrossbow } },
            { 2, new List<SkillType> { SkillType.AnimalCare, SkillType.Endurance, SkillType.Intimidate, SkillType.Intuition, SkillType.OutdoorSurvival, SkillType.RideHorse } },
            { 3, new List<SkillType> { SkillType.Athletics, SkillType.Charm, SkillType.Leadership, SkillType.RangedBlackpowder } },
            { 4, new List<SkillType> { SkillType.LoreEmpire, SkillType.Navigation } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.Coolheaded, TalentType.Embezzle, TalentType.Marksman, TalentType.Numismatics } },
            { 2, new List<TalentType> { TalentType.CrackTheWhip, TalentType.Criminal, TalentType.Roughrider, TalentType.SeasonedTraveler } },
            { 3, new List<TalentType> { TalentType.EtiquetteSoldiers, TalentType.FearlessOutlaws, TalentType.HatredAny, TalentType.NoseForTrouble } },
            { 4, new List<TalentType> { TalentType.CombatAware, TalentType.CommandingPresence, TalentType.Kingpin, TalentType.PublicSpeaker } }
        };
    }
}

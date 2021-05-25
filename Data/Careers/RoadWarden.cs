using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Bribery, SkillTypes.ConsumeAlcohol, SkillTypes.Gamble, SkillTypes.Gossip, SkillTypes.Haggle, SkillTypes.MeleeBasic, SkillTypes.Perception, SkillTypes.RangedCrossbow } },
            { 2, new List<SkillTypes> { SkillTypes.AnimalCare, SkillTypes.Endurance, SkillTypes.Intimidate, SkillTypes.Intuition, SkillTypes.OutdoorSurvival, SkillTypes.RideHorse } },
            { 3, new List<SkillTypes> { SkillTypes.Athletics, SkillTypes.Charm, SkillTypes.Leadership, SkillTypes.RangedBlackpowder } },
            { 4, new List<SkillTypes> { SkillTypes.LoreEmpire, SkillTypes.Navigation } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.Coolheaded, TalentTypes.Embezzle, TalentTypes.Marksman, TalentTypes.Numismatics } },
            { 2, new List<TalentTypes> { TalentTypes.CrackTheWhip, TalentTypes.Criminal, TalentTypes.Roughrider, TalentTypes.SeasonedTraveler } },
            { 3, new List<TalentTypes> { TalentTypes.EtiquetteSoldiers, TalentTypes.FearlessOutlaws, TalentTypes.HatredAny, TalentTypes.NoseForTrouble } },
            { 4, new List<TalentTypes> { TalentTypes.CombatAware, TalentTypes.CommandingPresence, TalentTypes.Kingpin, TalentTypes.PublicSpeaker } }
        };
    }
}

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

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Bribery, Types.Skills.ConsumeAlcohol, Types.Skills.Gamble, Types.Skills.Gossip, Types.Skills.Haggle, Types.Skills.MeleeBasic, Types.Skills.Perception, Types.Skills.RangedCrossbow } },
            { 2, new List<Skills> { Types.Skills.AnimalCare, Types.Skills.Endurance, Types.Skills.Intimidate, Types.Skills.Intuition, Types.Skills.OutdoorSurvival, Types.Skills.RideHorse } },
            { 3, new List<Skills> { Types.Skills.Athletics, Types.Skills.Charm, Types.Skills.Leadership, Types.Skills.RangedBlackpowder } },
            { 4, new List<Skills> { Types.Skills.LoreEmpire, Types.Skills.Navigation } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.Coolheaded, Types.Talents.Embezzle, Types.Talents.Marksman, Types.Talents.Numismatics } },
            { 2, new List<Talents> { Types.Talents.CrackTheWhip, Types.Talents.Criminal, Types.Talents.Roughrider, Types.Talents.SeasonedTraveler } },
            { 3, new List<Talents> { Types.Talents.EtiquetteSoldiers, Types.Talents.FearlessOutlaws, Types.Talents.HatredAny, Types.Talents.NoseForTrouble } },
            { 4, new List<Talents> { Types.Talents.CombatAware, Types.Talents.CommandingPresence, Types.Talents.Kingpin, Types.Talents.PublicSpeaker } }
        };
    }
}

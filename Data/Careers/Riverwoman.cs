using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Riverwoman : CareerBase
    {
        public Riverwoman(int level) : base(level) { }

        public override string Name => "Riverwoman";

        public override string Path => Level switch
        {
            1 => "Greenfish",
            2 => "Riverwoman",
            3 => "Riverwise",
            4 => "River Elder",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Brass;
        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Silver;
        public override int Agility => Bonus * Level;
        public override int Dexterity => Bonus * Level;
        public override int Fellowship => Bonus * Gold;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Athletics, Types.Skills.ConsumeAlcohol, Types.Skills.Dodge, Types.Skills.Endurance, Types.Skills.Gossip, Types.Skills.OutdoorSurvival, Types.Skills.Row, Types.Skills.Swim } },
            { 2, new List<Skills> { Types.Skills.Gamble, Types.Skills.LoreLocal, Types.Skills.LoreRiverways, Types.Skills.RangedEntangling, Types.Skills.RangedThrowing, Types.Skills.SetTrap } },
            { 3, new List<Skills> { Types.Skills.Charm, Types.Skills.Intuition, Types.Skills.MeleePolearm, Types.Skills.Perception } },
            { 4, new List<Skills> { Types.Skills.EntertainStorytelling, Types.Skills.LoreFolklore } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.Fisherman, Types.Talents.Gregarious, Types.Talents.StriderMarshes, Types.Talents.StrongSwimmer } },
            { 2, new List<Talents> { Types.Talents.CraftsmanBoatbuilder, Types.Talents.Rover, Types.Talents.StrongBack, Types.Talents.Waterman } },
            { 3, new List<Talents> { Types.Talents.SavantRiverways, Types.Talents.StoutHearted, Types.Talents.Tenacious, Types.Talents.VeryStrong } },
            { 4, new List<Talents> { Types.Talents.MasterCraftsmanBoatbuilder, Types.Talents.PublicSpeaker, Types.Talents.Sharp, Types.Talents.StrongMinded } }
        };
    }
}

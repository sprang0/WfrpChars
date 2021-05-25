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

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.AnimalCare, Types.Skills.Athletics, Types.Skills.ConsumeAlcohol, Types.Skills.Endurance, Types.Skills.Gossip, Types.Skills.MeleeBrawling, Types.Skills.LoreLocal, Types.Skills.OutdoorSurvival } },
            { 2, new List<Skills> { Types.Skills.Dodge, Types.Skills.Drive, Types.Skills.EntertainStorytelling, Types.Skills.Haggle, Types.Skills.MeleeBasic, Types.Skills.TradeAny } },
            { 3, new List<Skills> { Types.Skills.Bribery, Types.Skills.Charm, Types.Skills.Intimidate, Types.Skills.Leadership } },
            { 4, new List<Skills> { Types.Skills.Intuition, Types.Skills.LoreHistory } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.Rover, Types.Talents.StrongBack, Types.Talents.StrongMinded, Types.Talents.StoneSoup } },
            { 2, new List<Talents> { Types.Talents.AnimalAffinity, Types.Talents.Hardy, Types.Talents.Tenacious, Types.Talents.VeryStrong } },
            { 3, new List<Talents> { Types.Talents.CraftsmanAny, Types.Talents.Dealmaker, Types.Talents.StoutHearted, Types.Talents.VeryResilient } },
            { 4, new List<Talents> { Types.Talents.MasterTradesmanAny, Types.Talents.NimbleFingered, Types.Talents.PublicSpeaker, Types.Talents.SavantLocal } }
        };
    }
}

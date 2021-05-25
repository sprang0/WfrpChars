using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Flagellant : CareerBase
    {
        public Flagellant(int level) : base(level) { }

        public override string Name => "Flagellant";

        public override string Path => Level switch
        {
            1 => "Zealot",
            2 => "Flagellant",
            3 => "Penitent",
            4 => "Prophet of Doom",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Level;
        public override int Strength => Bonus * Level;
        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Silver;
        public override int Willpower => Bonus * Brass;
        public override int Fellowship => Bonus * Gold;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Dodge, Types.Skills.Endurance, Types.Skills.Heal, Types.Skills.Intimidate, Types.Skills.Intuition, Types.Skills.LoreSigmar, Types.Skills.MeleeFlail, Types.Skills.OutdoorSurvival } },
            { 2, new List<Skills> { Types.Skills.ArtIcons, Types.Skills.Athletics, Types.Skills.Cool, Types.Skills.LanguageClassical, Types.Skills.LoreEmpire, Types.Skills.RangedSling } },
            { 3, new List<Skills> { Types.Skills.Charm, Types.Skills.LanguageAny, Types.Skills.LoreTheology, Types.Skills.Perception } },
            { 4, new List<Skills> { Types.Skills.EntertainSpeeches, Types.Skills.Leadership } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.BerserkCharge, Types.Talents.Frenzy, Types.Talents.ReadWrite, Types.Talents.StoneSoup } },
            { 2, new List<Talents> { Types.Talents.Hardy, Types.Talents.HatredHeretics, Types.Talents.Flagellant, Types.Talents.Implacable } },
            { 3, new List<Talents> { Types.Talents.FieldDressing, Types.Talents.FuriousAssault, Types.Talents.Menacing, Types.Talents.SeasonedTraveler } },
            { 4, new List<Talents> { Types.Talents.BattleRage, Types.Talents.FearlessHeretics, Types.Talents.Frightening, Types.Talents.ImpassionedZeal } }
        };
    }
}

using System;
using System.Collections.Generic;

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

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Dodge, SkillType.Endurance, SkillType.Heal, SkillType.Intimidate, SkillType.Intuition, SkillType.LoreSigmar, SkillType.MeleeFlail, SkillType.OutdoorSurvival } },
            { 2, new List<SkillType> { SkillType.ArtIcons, SkillType.Athletics, SkillType.Cool, SkillType.LanguageClassical, SkillType.LoreEmpire, SkillType.RangedSling } },
            { 3, new List<SkillType> { SkillType.Charm, SkillType.LanguageAny, SkillType.LoreTheology, SkillType.Perception } },
            { 4, new List<SkillType> { SkillType.EntertainSpeeches, SkillType.Leadership } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.BerserkCharge, TalentType.Frenzy, TalentType.ReadWrite, TalentType.StoneSoup } },
            { 2, new List<TalentType> { TalentType.Hardy, TalentType.HatredHeretics, TalentType.Flagellant, TalentType.Implacable } },
            { 3, new List<TalentType> { TalentType.FieldDressing, TalentType.FuriousAssault, TalentType.Menacing, TalentType.SeasonedTraveler } },
            { 4, new List<TalentType> { TalentType.BattleRage, TalentType.FearlessHeretics, TalentType.Frightening, TalentType.ImpassionedZeal } }
        };
    }
}

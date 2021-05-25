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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Dodge, SkillTypes.Endurance, SkillTypes.Heal, SkillTypes.Intimidate, SkillTypes.Intuition, SkillTypes.LoreSigmar, SkillTypes.MeleeFlail, SkillTypes.OutdoorSurvival } },
            { 2, new List<SkillTypes> { SkillTypes.ArtIcons, SkillTypes.Athletics, SkillTypes.Cool, SkillTypes.LanguageClassical, SkillTypes.LoreEmpire, SkillTypes.RangedSling } },
            { 3, new List<SkillTypes> { SkillTypes.Charm, SkillTypes.LanguageAny, SkillTypes.LoreTheology, SkillTypes.Perception } },
            { 4, new List<SkillTypes> { SkillTypes.EntertainSpeeches, SkillTypes.Leadership } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.BerserkCharge, TalentTypes.Frenzy, TalentTypes.ReadWrite, TalentTypes.StoneSoup } },
            { 2, new List<TalentTypes> { TalentTypes.Hardy, TalentTypes.HatredHeretics, TalentTypes.Flagellant, TalentTypes.Implacable } },
            { 3, new List<TalentTypes> { TalentTypes.FieldDressing, TalentTypes.FuriousAssault, TalentTypes.Menacing, TalentTypes.SeasonedTraveler } },
            { 4, new List<TalentTypes> { TalentTypes.BattleRage, TalentTypes.FearlessHeretics, TalentTypes.Frightening, TalentTypes.ImpassionedZeal } }
        };
    }
}

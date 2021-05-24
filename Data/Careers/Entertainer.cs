using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WfrpChars.Data.Careers
{
    class Entertainer : CareerBase
    {
        public Entertainer(int level) : base(level) { }

        public override string Name => "Entertainer";

        public override string Path => Level switch
        {
            1 => "Busker",
            2 => "Entertainer",
            3 => "Troubadour",
            4 => "Troupe Leader",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Brass;
        public override int BallisticSkill => Bonus * Silver;
        public override int Toughness => Bonus * Gold;
        public override int Agility => Bonus * Level;
        public override int Dexterity => Bonus * Level;
        public override int Fellowship => Bonus * Level;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Athletics, SkillType.Charm, SkillType.EntertainAny, SkillType.Gossip, SkillType.Haggle, SkillType.PerformAny, SkillType.PlayAny, SkillType.SlightOfHand } },
            { 2, new List<SkillType> { SkillType.EntertainAny, SkillType.RideAny, SkillType.MeleeBasic, SkillType.PerformAny, SkillType.PlayAny, SkillType.RangedThrowing } },
            { 3, new List<SkillType> { SkillType.AnimalCare, SkillType.AnimalTrainingAny, SkillType.ArtWriting, SkillType.LanguageAny } },
            { 4, new List<SkillType> { SkillType.Drive, SkillType.Leadership } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.Attractive, TalentType.Mimic, TalentType.PublicSpeaker, TalentType.Suave } },
            { 2, new List<TalentType> { TalentType.Contortionist, TalentType.JumpUp, TalentType.Sharpshooter, TalentType.TrickRiding } },
            { 3, new List<TalentType> { TalentType.Blather, TalentType.MasterOfDisguise, TalentType.PerfectPitch, TalentType.ReadWrite } },
            { 4, new List<TalentType> { TalentType.Dealmaker, TalentType.EtiquetteAny, TalentType.SeasonedTraveler, TalentType.Sharp } }
        };
    }
}

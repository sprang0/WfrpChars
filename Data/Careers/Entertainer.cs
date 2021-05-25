using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Athletics, SkillTypes.Charm, SkillTypes.EntertainAny, SkillTypes.Gossip, SkillTypes.Haggle, SkillTypes.PerformAny, SkillTypes.PlayAny, SkillTypes.SleightOfHand } },
            { 2, new List<SkillTypes> { SkillTypes.EntertainAny, SkillTypes.RideAny, SkillTypes.MeleeBasic, SkillTypes.PerformAny, SkillTypes.PlayAny, SkillTypes.RangedThrowing } },
            { 3, new List<SkillTypes> { SkillTypes.AnimalCare, SkillTypes.AnimalTrainingAny, SkillTypes.ArtWriting, SkillTypes.LanguageAny } },
            { 4, new List<SkillTypes> { SkillTypes.Drive, SkillTypes.Leadership } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.Attractive, TalentTypes.Mimic, TalentTypes.PublicSpeaker, TalentTypes.Suave } },
            { 2, new List<TalentTypes> { TalentTypes.Contortionist, TalentTypes.JumpUp, TalentTypes.Sharpshooter, TalentTypes.TrickRiding } },
            { 3, new List<TalentTypes> { TalentTypes.Blather, TalentTypes.MasterOfDisguise, TalentTypes.PerfectPitch, TalentTypes.ReadWrite } },
            { 4, new List<TalentTypes> { TalentTypes.Dealmaker, TalentTypes.EtiquetteAny, TalentTypes.SeasonedTraveler, TalentTypes.Sharp } }
        };
    }
}

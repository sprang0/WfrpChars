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

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Athletics, Types.Skills.Charm, Types.Skills.EntertainAny, Types.Skills.Gossip, Types.Skills.Haggle, Types.Skills.PerformAny, Types.Skills.PlayAny, Types.Skills.SleightOfHand } },
            { 2, new List<Skills> { Types.Skills.EntertainAny, Types.Skills.RideAny, Types.Skills.MeleeBasic, Types.Skills.PerformAny, Types.Skills.PlayAny, Types.Skills.RangedThrowing } },
            { 3, new List<Skills> { Types.Skills.AnimalCare, Types.Skills.AnimalTrainingAny, Types.Skills.ArtWriting, Types.Skills.LanguageAny } },
            { 4, new List<Skills> { Types.Skills.Drive, Types.Skills.Leadership } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.Attractive, Types.Talents.Mimic, Types.Talents.PublicSpeaker, Types.Talents.Suave } },
            { 2, new List<Talents> { Types.Talents.Contortionist, Types.Talents.JumpUp, Types.Talents.Sharpshooter, Types.Talents.TrickRiding } },
            { 3, new List<Talents> { Types.Talents.Blather, Types.Talents.MasterOfDisguise, Types.Talents.PerfectPitch, Types.Talents.ReadWrite } },
            { 4, new List<Talents> { Types.Talents.Dealmaker, Types.Talents.EtiquetteAny, Types.Talents.SeasonedTraveler, Types.Talents.Sharp } }
        };
    }
}

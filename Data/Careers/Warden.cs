using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Warden : CareerBase
    {
        public Warden(int level) : base(level) { }

        public override string Name => "Warden";

        public override string Path => Level switch
        {
            1 => "Custodian",
            2 => "Warden",
            3 => "Seneschal",
            4 => "Governor",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Brass;
        public override int Strength => Bonus * Level;
        public override int Toughness => Bonus * Level;
        public override int Intelligence => Bonus * Gold;
        public override int Willpower => Bonus * Level;
        public override int Fellowship => Bonus * Silver;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Athletics, Types.Skills.CharmAnimal, Types.Skills.ConsumeAlcohol, Types.Skills.Cool, Types.Skills.Endurance, Types.Skills.Intuition, Types.Skills.LoreLocal, Types.Skills.Perception } },
            { 2, new List<Skills> { Types.Skills.AnimalCare, Types.Skills.MeleeBasic, Types.Skills.OutdoorSurvival, Types.Skills.RangedBow, Types.Skills.RideHorse, Types.Skills.Swim } },
            { 3, new List<Skills> { Types.Skills.Bribery, Types.Skills.Charm, Types.Skills.Gossip, Types.Skills.Leadership } },
            { 4, new List<Skills> { Types.Skills.Evaluate, Types.Skills.LanguageAny } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.Menacing, Types.Talents.NightVision, Types.Talents.Sharp, Types.Talents.StrikeToStun } },
            { 2, new List<Talents> { Types.Talents.AnimalAffinity, Types.Talents.EtiquetteServants, Types.Talents.StriderAny, Types.Talents.Rover } },
            { 3, new List<Talents> { Types.Talents.Embezzle, Types.Talents.Numismatics, Types.Talents.ReadWrite, Types.Talents.Supportive } },
            { 4, new List<Talents> { Types.Talents.CommandingPresence, Types.Talents.EtiquetteAny, Types.Talents.SavantLocal, Types.Talents.Suave } }
        };
    }
}

using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class RatCatcher : CareerBase
    {
        public RatCatcher(int level) : base(level) { }

        public override string Name => "Rat Catcher";

        public override string Path => Level switch
        {
            1 => "Rat Hunter",
            2 => "Rat Catcher",
            3 => "Sewer Jack",
            4 => "Exterminator",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Level;
        public override int BallisticSkill => Bonus * Level;
        public override int Strength => Bonus * Gold;
        public override int Toughness => Bonus * Brass;
        public override int Initiative => Bonus * Silver;
        public override int Willpower => Bonus * Level;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Athletics, Types.Skills.AnimalTrainingDog, Types.Skills.CharmAnimal, Types.Skills.ConsumeAlcohol, Types.Skills.Endurance, Types.Skills.MeleeBasic, Types.Skills.RangedSling } },
            { 2, new List<Skills> { Types.Skills.AnimalCare, Types.Skills.Gossip, Types.Skills.Haggle, Types.Skills.LorePoison, Types.Skills.Perception, Types.Skills.SetTrap } },
            { 3, new List<Skills> { Types.Skills.Climb, Types.Skills.Cool, Types.Skills.Dodge, Types.Skills.RangedCrossbowPistol } },
            { 4, new List<Skills> { Types.Skills.Leadership, Types.Skills.Track } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.NightVision, Types.Talents.ResistanceDisease, Types.Talents.StrikeMightyBlow, Types.Talents.StrikeToStun } },
            { 2, new List<Talents> { Types.Talents.EnclosedFighter, Types.Talents.EtiquetteGuilder, Types.Talents.FearlessRats, Types.Talents.VeryResilient } },
            { 3, new List<Talents> { Types.Talents.Hardy, Types.Talents.StoutHearted, Types.Talents.StrongLegs, Types.Talents.TunnelRat } },
            { 4, new List<Talents> { Types.Talents.FearlessSkaven, Types.Talents.Menacing, Types.Talents.Robust, Types.Talents.StrongMinded } }
        };
    }
}

using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Stevedore : CareerBase
    {
        public Stevedore(int level) : base(level) { }

        public override string Name => "Stevedore";

        public override string Path => Level switch
        {
            1 => "Dockhand",
            2 => "Stevedore",
            3 => "Foreman",
            4 => "Dock Master",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Level;
        public override int Strength => Bonus * Brass;
        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Level;
        public override int Intelligence => Bonus * Gold;
        public override int Willpower => Bonus * Silver;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Athletics, Types.Skills.Climb, Types.Skills.ConsumeAlcohol, Types.Skills.Dodge, Types.Skills.Endurance, Types.Skills.Gossip, Types.Skills.MeleeBasic, Types.Skills.Swim } },
            { 2, new List<Skills> { Types.Skills.Bribery, Types.Skills.EntertainStorytelling, Types.Skills.Gamble, Types.Skills.Intimidate, Types.Skills.Perception, Types.Skills.StealthUrban } },
            { 3, new List<Skills> { Types.Skills.Cool, Types.Skills.Evaluate, Types.Skills.Intuition, Types.Skills.Leadership } },
            { 4, new List<Skills> { Types.Skills.Charm, Types.Skills.LoreTaxes } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.DirtyFighting, Types.Talents.StrongBack, Types.Talents.Sturdy, Types.Talents.VeryStrong } },
            { 2, new List<Talents> { Types.Talents.Criminal, Types.Talents.EtiquetteGuilder, Types.Talents.StrongLegs, Types.Talents.Tenacious } },
            { 3, new List<Talents> { Types.Talents.Dealmaker, Types.Talents.Embezzle, Types.Talents.EtiquetteCriminals, Types.Talents.PublicSpeaker } },
            { 4, new List<Talents> { Types.Talents.Kingpin, Types.Talents.Menacing, Types.Talents.Numismatics, Types.Talents.ReadWrite } }
        };
    }
}

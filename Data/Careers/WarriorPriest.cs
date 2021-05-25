using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class WarriorPriest : CareerBase
    {
        public WarriorPriest(int level) : base(level) { }

        public override string Name => "Warrior Priest";

        public override string Path => Level switch
        {
            1 => "Novitiate",
            2 => "Warrior Priest",
            3 => "Priest Sergeant",
            4 => "Priest Captain",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Level;
        public override int Strength => Bonus * Brass;
        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Silver;
        public override int Willpower => Bonus * Level;
        public override int Fellowship => Bonus * Gold;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Cool, Types.Skills.Dodge, Types.Skills.Endurance, Types.Skills.Heal, Types.Skills.Leadership, Types.Skills.LoreTheology, Types.Skills.MeleeAny, Types.Skills.Pray } },
            { 2, new List<Skills> { Types.Skills.Charm, Types.Skills.EntertainSpeeches, Types.Skills.Intimidate, Types.Skills.LanguageBattle, Types.Skills.MeleeAny, Types.Skills.RangedAny } },
            { 3, new List<Skills> { Types.Skills.AnimalCare, Types.Skills.Intuition, Types.Skills.Perception, Types.Skills.RideHorse } },
            { 4, new List<Skills> { Types.Skills.ConsumeAlcohol, Types.Skills.LoreWarfare } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.BlessAny, Types.Talents.EtiquetteCultists, Types.Talents.ReadWrite, Types.Talents.StrongMinded } },
            { 2, new List<Talents> { Types.Talents.DualWielder, Types.Talents.Inspiring, Types.Talents.InvokeAny, Types.Talents.SeasonedTraveler } },
            { 3, new List<Talents> { Types.Talents.CombatAware, Types.Talents.HolyVisions, Types.Talents.PureSoul, Types.Talents.StoutHearted } },
            { 4, new List<Talents> { Types.Talents.FearlessAny, Types.Talents.FuriousAssault, Types.Talents.HolyHatred, Types.Talents.Warleader } }
        };
    }
}

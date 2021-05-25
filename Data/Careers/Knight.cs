using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Knight : CareerBase
    {
        public Knight(int level) : base(level) { }

        public override string Name => "Knight";

        public override string Path => Level switch
        {
            1 => "Squire",
            2 => "Knight",
            3 => "First Knight",
            4 => "Knight of the Inner Circle",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Brass;
        public override int Strength => Bonus * Level;
        public override int Initiative => Bonus * Level;
        public override int Agility => Bonus * Level;
        public override int Willpower => Bonus * Silver;
        public override int Fellowship => Bonus * Gold;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Athletics, Types.Skills.AnimalCare, Types.Skills.CharmAnimal, Types.Skills.Heal, Types.Skills.LoreHeraldry, Types.Skills.MeleeCavalry, Types.Skills.RideHorse, Types.Skills.TradeFarrier } },
            { 2, new List<Skills> { Types.Skills.Cool, Types.Skills.Dodge, Types.Skills.Endurance, Types.Skills.Intimidate, Types.Skills.LanguageBattle, Types.Skills.MeleeAny } },
            { 3, new List<Skills> { Types.Skills.Charm, Types.Skills.ConsumeAlcohol, Types.Skills.Leadership, Types.Skills.LoreWarfare } },
            { 4, new List<Skills> { Types.Skills.LoreAny, Types.Skills.SecretSignsKnightlyOrder } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.EtiquetteAny, Types.Talents.Roughrider, Types.Talents.Sturdy, Types.Talents.WarriorBorn } },
            { 2, new List<Talents> { Types.Talents.Menacing, Types.Talents.SeasonedTraveler, Types.Talents.Shieldsman, Types.Talents.StrikeMightyBlow } },
            { 3, new List<Talents> { Types.Talents.FearlessAny, Types.Talents.StoutHearted, Types.Talents.Unshakeable, Types.Talents.Warleader } },
            { 4, new List<Talents> { Types.Talents.Disarm, Types.Talents.Inspiring, Types.Talents.IronWill, Types.Talents.StrikeToInjure } }
        };
    }
}

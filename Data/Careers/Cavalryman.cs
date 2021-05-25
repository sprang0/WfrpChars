using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Cavalryman : CareerBase
    {
        public Cavalryman(int level) : base(level) { }

        public override string Name => "Cavalryman";

        public override string Path => Level switch
        {
            1 => "Horseman",
            2 => "Cavalryman",
            3 => "Cavalry Sergeant",
            4 => "Cavalry Officer",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Level;
        public override int BallisticSkill => Bonus * Brass;
        public override int Strength => Bonus * Level;
        public override int Initiative => Bonus * Silver;
        public override int Agility => Bonus * Level;
        public override int Fellowship => Bonus * Gold;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.AnimalCare, Types.Skills.CharmAnimal, Types.Skills.Endurance, Types.Skills.LanguageBattle, Types.Skills.MeleeBasic, Types.Skills.OutdoorSurvival, Types.Skills.Perception, Types.Skills.RideHorse } },
            { 2, new List<Skills> { Types.Skills.Charm, Types.Skills.ConsumeAlcohol, Types.Skills.Cool, Types.Skills.Gossip, Types.Skills.MeleeCavalry, Types.Skills.RangedBlackpowder } },
            { 3, new List<Skills> { Types.Skills.Intimidate, Types.Skills.Intuition, Types.Skills.Leadership, Types.Skills.LoreWarfare } },
            { 4, new List<Skills> { Types.Skills.Gamble, Types.Skills.LoreHeraldry } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.CombatAware, Types.Talents.CrackTheWhip, Types.Talents.LightningReflexes, Types.Talents.Roughrider } },
            { 2, new List<Talents> { Types.Talents.EtiquetteSoldiers, Types.Talents.Gunner, Types.Talents.SeasonedTraveler, Types.Talents.TrickRiding } },
            { 3, new List<Talents> { Types.Talents.CombatReflexes, Types.Talents.FastShot, Types.Talents.HatredAny, Types.Talents.Warleader } },
            { 4, new List<Talents> { Types.Talents.AccurateShot, Types.Talents.Inspiring, Types.Talents.ReactionStrike, Types.Talents.Robust } }
        };
    }
}

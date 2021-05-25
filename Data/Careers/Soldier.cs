using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Soldier : CareerBase
    {
        public Soldier(int level) : base(level) { }

        public override string Name => "Soldier";

        public override string Path => Level switch
        {
            1 => "Recruit",
            2 => "Soldier",
            3 => "Sergeant",
            4 => "Officer",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Level;
        public override int BallisticSkill => Bonus * Brass;
        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Silver;
        public override int Willpower => Bonus * Level;
        public override int Fellowship => Bonus * Gold;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Athletics, Types.Skills.Climb, Types.Skills.Cool, Types.Skills.Dodge, Types.Skills.Endurance, Types.Skills.LanguageBattle, Types.Skills.MeleeBasic, Types.Skills.PlayDrumOrFife } },
            { 2, new List<Skills> { Types.Skills.ConsumeAlcohol, Types.Skills.Gamble, Types.Skills.Gossip, Types.Skills.MeleeAny, Types.Skills.RangedAny, Types.Skills.OutdoorSurvival } },
            { 3, new List<Skills> { Types.Skills.Heal, Types.Skills.Intuition, Types.Skills.Leadership, Types.Skills.Perception } },
            { 4, new List<Skills> { Types.Skills.LoreWarfare, Types.Skills.Navigation } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.Diceman, Types.Talents.Marksman, Types.Talents.StrongBack, Types.Talents.WarriorBorn } },
            { 2, new List<Talents> { Types.Talents.Drilled, Types.Talents.EtiquetteSoldiers, Types.Talents.RapidReload, Types.Talents.Shieldsman } },
            { 3, new List<Talents> { Types.Talents.CombatAware, Types.Talents.EnclosedFighter, Types.Talents.Unshakeable, Types.Talents.Warleader } },
            { 4, new List<Talents> { Types.Talents.Inspiring, Types.Talents.PublicSpeaker, Types.Talents.SeasonedTraveler, Types.Talents.StoutHearted } }
        };
    }
}

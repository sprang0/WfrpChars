using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Watchman : CareerBase
    {
        public Watchman(int level) : base(level) { }

        public override string Name => "Watchman";

        public override string Path => Level switch
        {
            1 => "Watch Recruit",
            2 => "Watchman",
            3 => "Watch Sergeant",
            4 => "Watch Captain",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Level;
        public override int Strength => Bonus * Level;
        public override int Initiative => Bonus * Silver;
        public override int Intelligence => Bonus * Gold;
        public override int Willpower => Bonus * Brass;
        public override int Fellowship => Bonus * Level;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Athletics, Types.Skills.Climb, Types.Skills.ConsumeAlcohol, Types.Skills.Dodge, Types.Skills.Endurance, Types.Skills.Gamble, Types.Skills.MeleeAny, Types.Skills.Perception } },
            { 2, new List<Skills> { Types.Skills.Charm, Types.Skills.Cool, Types.Skills.Gossip, Types.Skills.Intimidate, Types.Skills.Intuition, Types.Skills.LoreLocal } },
            { 3, new List<Skills> { Types.Skills.EntertainStorytelling, Types.Skills.Haggle, Types.Skills.Leadership, Types.Skills.LoreLaw } },
            { 4, new List<Skills> { Types.Skills.LorePolitics, Types.Skills.RideHorse } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.Drilled, Types.Talents.Hardy, Types.Talents.StrikeToStun, Types.Talents.Tenacious } },
            { 2, new List<Talents> { Types.Talents.BreakAndEnter, Types.Talents.Criminal, Types.Talents.NightVision, Types.Talents.Sprinter } },
            { 3, new List<Talents> { Types.Talents.Disarm, Types.Talents.EtiquetteSoldiers, Types.Talents.FearlessCriminals, Types.Talents.NoseForTrouble } },
            { 4, new List<Talents> { Types.Talents.PublicSpeaker, Types.Talents.Robust, Types.Talents.Kingpin, Types.Talents.Schemer } }
        };
    }
}

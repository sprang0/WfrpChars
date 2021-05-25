using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class WitchHunter : CareerBase
    {
        public WitchHunter(int level) : base(level) { }

        public override string Name => "Witch Hunter";

        public override string Path => Level switch
        {
            1 => "Interrogator",
            2 => "Witch Hunter",
            3 => "Inquisitor",
            4 => "Witchfinder General",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Level;
        public override int BallisticSkill => Bonus * Brass;
        public override int Toughness => Bonus * Level;
        public override int Intelligence => Bonus * Gold;
        public override int Willpower => Bonus * Level;
        public override int Fellowship => Bonus * Silver;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Charm, Types.Skills.ConsumeAlcohol, Types.Skills.Heal, Types.Skills.Intimidate, Types.Skills.Intuition, Types.Skills.LoreTorture, Types.Skills.MeleeBrawling, Types.Skills.Perception } },
            { 2, new List<Skills> { Types.Skills.Cool, Types.Skills.Gossip, Types.Skills.MeleeBasic, Types.Skills.LoreWitches, Types.Skills.RangedAny, Types.Skills.RideHorse } },
            { 3, new List<Skills> { Types.Skills.Endurance, Types.Skills.Leadership, Types.Skills.LoreLaw, Types.Skills.LoreLocal } },
            { 4, new List<Skills> { Types.Skills.LoreChaos, Types.Skills.LorePolitics } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.Coolheaded, Types.Talents.Menacing, Types.Talents.ReadWrite, Types.Talents.Resolute } },
            { 2, new List<Talents> { Types.Talents.DualWielder, Types.Talents.Marksman, Types.Talents.SeasonedTraveler, Types.Talents.Shadow } },
            { 3, new List<Talents> { Types.Talents.FearlessWitches, Types.Talents.NoseForTrouble, Types.Talents.Relentless, Types.Talents.StrongMinded } },
            { 4, new List<Talents> { Types.Talents.Frightening, Types.Talents.IronWill, Types.Talents.MagicalSense, Types.Talents.PureSoul } }
        };
    }
}

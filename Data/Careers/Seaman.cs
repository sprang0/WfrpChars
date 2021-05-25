using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Seaman : CareerBase
    {
        public Seaman(int level) : base(level) { }

        public override string Name => "Seaman";

        public override string Path => Level switch
        {
            1 => "Landsman",
            2 => "Seaman",
            3 => "Boatswain",
            4 => "Ship's Master",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Brass;
        public override int Initiative => Bonus * Silver;
        public override int Agility => Bonus * Level;
        public override int Dexterity => Bonus * Level;
        public override int Intelligence => Bonus * Gold;
        public override int Fellowship => Bonus * Level;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Climb, Types.Skills.ConsumeAlcohol, Types.Skills.Gamble, Types.Skills.Gossip, Types.Skills.Row, Types.Skills.MeleeBrawling, Types.Skills.Sail, Types.Skills.Swim } },
            { 2, new List<Skills> { Types.Skills.Athletics, Types.Skills.Dodge, Types.Skills.Endurance, Types.Skills.EntertainSinging, Types.Skills.LanguageAny, Types.Skills.MeleeBasic } },
            { 3, new List<Skills> { Types.Skills.Cool, Types.Skills.Leadership, Types.Skills.Perception, Types.Skills.TradeCarpenter } },
            { 4, new List<Skills> { Types.Skills.Charm, Types.Skills.Navigation } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.Fisherman, Types.Talents.StriderCoastal, Types.Talents.StrongBack, Types.Talents.StrongSwimmer } },
            { 2, new List<Talents> { Types.Talents.Catfall, Types.Talents.SeaLegs, Types.Talents.SeasonedTraveler, Types.Talents.StrongLegs } },
            { 3, new List<Talents> { Types.Talents.OldSalt, Types.Talents.StrikeMightyBlow, Types.Talents.Tenacious, Types.Talents.VeryStrong } },
            { 4, new List<Talents> { Types.Talents.Orientation, Types.Talents.Pilot, Types.Talents.PublicSpeaker, Types.Talents.Savvy } }
        };
    }
}

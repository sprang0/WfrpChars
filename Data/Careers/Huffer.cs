using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Huffer : CareerBase
    {
        public Huffer(int level) : base(level) { }

        public override string Name => "Huffer";

        public override string Path => Level switch
        {
            1 => "Riverguide",
            2 => "Huffer",
            3 => "Pilot",
            4 => "Master Pilot",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Level;
        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Level;
        public override int Intelligence => Bonus * Silver;
        public override int Willpower => Bonus * Brass;
        public override int Fellowship => Bonus * Gold;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.ConsumeAlcohol, Types.Skills.Gossip, Types.Skills.Intuition, Types.Skills.LoreLocal, Types.Skills.LoreRiverways, Types.Skills.Perception, Types.Skills.Row, Types.Skills.Swim } },
            { 2, new List<Skills> { Types.Skills.Charm, Types.Skills.Cool, Types.Skills.EntertainStorytelling, Types.Skills.LanguageAny, Types.Skills.MeleeBasic, Types.Skills.Navigation } },
            { 3, new List<Skills> { Types.Skills.Haggle, Types.Skills.Intimidate, Types.Skills.LoreLocal, Types.Skills.LoreWrecks } },
            { 4, new List<Skills> { Types.Skills.Leadership, Types.Skills.Sail } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.Fisherman, Types.Talents.NightVision, Types.Talents.Orientation, Types.Talents.Waterman } },
            { 2, new List<Talents> { Types.Talents.Dealmaker, Types.Talents.EtiquetteGuilder, Types.Talents.NoseForTrouble, Types.Talents.RiverGuide } },
            { 3, new List<Talents> { Types.Talents.AcuteSenseSight, Types.Talents.Pilot, Types.Talents.SeaLegs, Types.Talents.VeryStrong } },
            { 4, new List<Talents> { Types.Talents.SixthSense, Types.Talents.Sharp, Types.Talents.StrongSwimmer, Types.Talents.Tenacious } }
        };
    }
}

using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Slayer : CareerBase
    {
        public Slayer(int level) : base(level) { }

        public override string Name => "Slayer";

        public override string Path => Level switch
        {
            1 => "Troll Slayer",
            2 => "Giant Slayer",
            3 => "Dragon Slayer",
            4 => "Daemon Slayer",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Level;
        public override int Strength => Bonus * Level;
        public override int Toughness => Bonus * Brass;
        public override int Initiative => Bonus * Gold;
        public override int Agility => Bonus * Silver;
        public override int Willpower => Bonus * Level;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.ConsumeAlcohol, Types.Skills.Cool, Types.Skills.Dodge, Types.Skills.Endurance, Types.Skills.Gamble, Types.Skills.Heal, Types.Skills.LoreTrolls, Types.Skills.MeleeBasic } },
            { 2, new List<Skills> { Types.Skills.Evaluate, Types.Skills.Intimidate, Types.Skills.LanguageBattle, Types.Skills.LoreGiants, Types.Skills.MeleeTwoHanded, Types.Skills.OutdoorSurvival } },
            { 3, new List<Skills> { Types.Skills.EntertainStorytelling, Types.Skills.LoreDragons, Types.Skills.Perception, Types.Skills.RangedThrowing } },
            { 4, new List<Skills> { Types.Skills.Intuition, Types.Skills.LoreChaos } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.DualWielder, Types.Talents.FearlessEverything, Types.Talents.Frenzy, Types.Talents.Slayer } },
            { 2, new List<Talents> { Types.Talents.Hardy, Types.Talents.Implacable, Types.Talents.Menacing, Types.Talents.Reversal } },
            { 3, new List<Talents> { Types.Talents.Ambidextrous, Types.Talents.FuriousAssault, Types.Talents.Relentless, Types.Talents.Robust } },
            { 4, new List<Talents> { Types.Talents.CombatMaster, Types.Talents.Frightening, Types.Talents.StrikeMightyBlow, Types.Talents.VeryStrong } }
        };
    }
}

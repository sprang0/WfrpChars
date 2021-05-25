using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Racketeer : CareerBase
    {
        public Racketeer(int level) : base(level) { }

        public override string Name => "Racketeer";

        public override string Path => Level switch
        {
            1 => "Thug",
            2 => "Racketeer",
            3 => "Gang Boss",
            4 => "Crime Lord",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Level;
        public override int Strength => Bonus * Level;
        public override int Toughness => Bonus * Level;
        public override int Intelligence => Bonus * Gold;
        public override int Willpower => Bonus * Silver;
        public override int Fellowship => Bonus * Brass;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.ConsumeAlcohol, Types.Skills.Cool, Types.Skills.Dodge, Types.Skills.Endurance, Types.Skills.Intimidate, Types.Skills.LoreLocal, Types.Skills.MeleeBrawling, Types.Skills.StealthUrban } },
            { 2, new List<Skills> { Types.Skills.Bribery, Types.Skills.Charm, Types.Skills.Evaluate, Types.Skills.Gossip, Types.Skills.LanguageEstalianOrTilean, Types.Skills.MeleeBasic } },
            { 3, new List<Skills> { Types.Skills.Intuition, Types.Skills.Leadership, Types.Skills.Perception, Types.Skills.RangedCrossbow } },
            { 4, new List<Skills> { Types.Skills.LoreLaw, Types.Skills.LorePolitics } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.Criminal, Types.Talents.EtiquetteCriminals, Types.Talents.Menacing, Types.Talents.StrikeMightyBlow } },
            { 2, new List<Talents> { Types.Talents.DirtyFighting, Types.Talents.Embezzle, Types.Talents.StrikeToStun, Types.Talents.WarriorBorn } },
            { 3, new List<Talents> { Types.Talents.FearlessWatchmen, Types.Talents.IronWill, Types.Talents.ResistancePoison, Types.Talents.Robust } },
            { 4, new List<Talents> { Types.Talents.CommandingPresence, Types.Talents.Kingpin, Types.Talents.Frightening, Types.Talents.Wealthy } }
        };
    }
}

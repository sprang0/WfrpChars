using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Guard : CareerBase
    {
        public Guard(int level) : base(level) { }

        public override string Name => "Guard";

        public override string Path => Level switch
        {
            1 => "Sentry",
            2 => "Guard",
            3 => "Honour Guard",
            4 => "Guard Officer",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Level;
        public override int Strength => Bonus * Silver;
        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Brass;
        public override int Agility => Bonus * Level;
        public override int Intelligence => Bonus * Gold;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.ConsumeAlcohol, Types.Skills.Endurance, Types.Skills.EntertainStorytelling, Types.Skills.Gamble, Types.Skills.Gossip, Types.Skills.Intuition, Types.Skills.MeleeBasic, Types.Skills.Perception } },
            { 2, new List<Skills> { Types.Skills.Athletics, Types.Skills.Cool, Types.Skills.Dodge, Types.Skills.Intimidate, Types.Skills.MeleePolearm, Types.Skills.RangedBow } },
            { 3, new List<Skills> { Types.Skills.Heal, Types.Skills.LanguageBattle, Types.Skills.LoreEtiquette, Types.Skills.MeleeTwoHanded } },
            { 4, new List<Skills> { Types.Skills.Leadership, Types.Skills.LoreWarfare } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.Diceman, Types.Talents.EtiquetteServants, Types.Talents.StrikeToStun, Types.Talents.Tenacious } },
            { 2, new List<Talents> { Types.Talents.Relentless, Types.Talents.Reversal, Types.Talents.Shieldsman, Types.Talents.StrikeMightyBlow } },
            { 3, new List<Talents> { Types.Talents.FearlessIntruders, Types.Talents.JumpUp, Types.Talents.StoutHearted, Types.Talents.Unshakeable } },
            { 4, new List<Talents> { Types.Talents.CombatMaster, Types.Talents.FuriousAssault, Types.Talents.IronWill, Types.Talents.Robust } }
        };
    }
}

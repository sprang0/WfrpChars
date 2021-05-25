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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.ConsumeAlcohol, SkillTypes.Endurance, SkillTypes.EntertainStorytelling, SkillTypes.Gamble, SkillTypes.Gossip, SkillTypes.Intuition, SkillTypes.MeleeBasic, SkillTypes.Perception } },
            { 2, new List<SkillTypes> { SkillTypes.Athletics, SkillTypes.Cool, SkillTypes.Dodge, SkillTypes.Intimidate, SkillTypes.MeleePolearm, SkillTypes.RangedBow } },
            { 3, new List<SkillTypes> { SkillTypes.Heal, SkillTypes.LanguageBattle, SkillTypes.LoreEtiquette, SkillTypes.MeleeTwoHanded } },
            { 4, new List<SkillTypes> { SkillTypes.Leadership, SkillTypes.LoreWarfare } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.Diceman, TalentTypes.EtiquetteServants, TalentTypes.StrikeToStun, TalentTypes.Tenacious } },
            { 2, new List<TalentTypes> { TalentTypes.Relentless, TalentTypes.Reversal, TalentTypes.Shieldsman, TalentTypes.StrikeMightyBlow } },
            { 3, new List<TalentTypes> { TalentTypes.FearlessIntruders, TalentTypes.JumpUp, TalentTypes.StoutHearted, TalentTypes.Unshakeable } },
            { 4, new List<TalentTypes> { TalentTypes.CombatMaster, TalentTypes.FuriousAssault, TalentTypes.IronWill, TalentTypes.Robust } }
        };
    }
}

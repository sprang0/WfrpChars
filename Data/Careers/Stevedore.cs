using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Stevedore : CareerBase
    {
        public Stevedore(int level) : base(level) { }

        public override string Name => "Stevedore";

        public override string Path => Level switch
        {
            1 => "Dockhand",
            2 => "Stevedore",
            3 => "Foreman",
            4 => "Dock Master",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Level;
        public override int Strength => Bonus * Brass;
        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Level;
        public override int Intelligence => Bonus * Gold;
        public override int Willpower => Bonus * Silver;

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Athletics, SkillTypes.Climb, SkillTypes.ConsumeAlcohol, SkillTypes.Dodge, SkillTypes.Endurance, SkillTypes.Gossip, SkillTypes.MeleeBasic, SkillTypes.Swim } },
            { 2, new List<SkillTypes> { SkillTypes.Bribery, SkillTypes.EntertainStorytelling, SkillTypes.Gamble, SkillTypes.Intimidate, SkillTypes.Perception, SkillTypes.StealthUrban } },
            { 3, new List<SkillTypes> { SkillTypes.Cool, SkillTypes.Evaluate, SkillTypes.Intuition, SkillTypes.Leadership } },
            { 4, new List<SkillTypes> { SkillTypes.Charm, SkillTypes.LoreTaxes } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.DirtyFighting, TalentTypes.StrongBack, TalentTypes.Sturdy, TalentTypes.VeryStrong } },
            { 2, new List<TalentTypes> { TalentTypes.Criminal, TalentTypes.EtiquetteGuilder, TalentTypes.StrongLegs, TalentTypes.Tenacious } },
            { 3, new List<TalentTypes> { TalentTypes.Dealmaker, TalentTypes.Embezzle, TalentTypes.EtiquetteCriminals, TalentTypes.PublicSpeaker } },
            { 4, new List<TalentTypes> { TalentTypes.Kingpin, TalentTypes.Menacing, TalentTypes.Numismatics, TalentTypes.ReadWrite } }
        };
    }
}

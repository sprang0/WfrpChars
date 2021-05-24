using System;
using System.Collections.Generic;

namespace WfrpChars.Data.Careers
{
    class Cavalryman : CareerBase
    {
        public Cavalryman(int level) : base(level) { }

        public override string Name => "Cavalryman";

        public override string Path => Level switch
        {
            1 => "Horseman",
            2 => "Cavalryman",
            3 => "Cavalry Sergeant",
            4 => "Cavalry Officer",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Level;
        public override int BallisticSkill => Bonus * Brass;
        public override int Strength => Bonus * Level;
        public override int Initiative => Bonus * Silver;
        public override int Agility => Bonus * Level;
        public override int Fellowship => Bonus * Gold;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.AnimalCare, SkillType.CharmAnimal, SkillType.Endurance, SkillType.LanguageBattle, SkillType.MeleeBasic, SkillType.OutdoorSurvival, SkillType.Perception, SkillType.RideHorse } },
            { 2, new List<SkillType> { SkillType.Charm, SkillType.ConsumeAlcohol, SkillType.Cool, SkillType.Gossip, SkillType.MeleeCavalry, SkillType.RangedBlackpowder } },
            { 3, new List<SkillType> { SkillType.Intimidate, SkillType.Intuition, SkillType.Leadership, SkillType.LoreWarfare } },
            { 4, new List<SkillType> { SkillType.Gamble, SkillType.LoreHeraldry } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.CombatAware, TalentType.CrackTheWhip, TalentType.LightningReflexes, TalentType.Roughrider } },
            { 2, new List<TalentType> { TalentType.EtiquetteSoldiers, TalentType.Gunner, TalentType.SeasonedTraveler, TalentType.TrickRiding } },
            { 3, new List<TalentType> { TalentType.CombatReflexes, TalentType.FastShot, TalentType.HatredAny, TalentType.Warleader } },
            { 4, new List<TalentType> { TalentType.AccurateShot, TalentType.Inspiring, TalentType.ReactionStrike, TalentType.Robust } }
        };
    }
}

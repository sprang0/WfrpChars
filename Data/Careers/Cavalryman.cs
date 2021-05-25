using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.AnimalCare, SkillTypes.CharmAnimal, SkillTypes.Endurance, SkillTypes.LanguageBattle, SkillTypes.MeleeBasic, SkillTypes.OutdoorSurvival, SkillTypes.Perception, SkillTypes.RideHorse } },
            { 2, new List<SkillTypes> { SkillTypes.Charm, SkillTypes.ConsumeAlcohol, SkillTypes.Cool, SkillTypes.Gossip, SkillTypes.MeleeCavalry, SkillTypes.RangedBlackpowder } },
            { 3, new List<SkillTypes> { SkillTypes.Intimidate, SkillTypes.Intuition, SkillTypes.Leadership, SkillTypes.LoreWarfare } },
            { 4, new List<SkillTypes> { SkillTypes.Gamble, SkillTypes.LoreHeraldry } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.CombatAware, TalentTypes.CrackTheWhip, TalentTypes.LightningReflexes, TalentTypes.Roughrider } },
            { 2, new List<TalentTypes> { TalentTypes.EtiquetteSoldiers, TalentTypes.Gunner, TalentTypes.SeasonedTraveler, TalentTypes.TrickRiding } },
            { 3, new List<TalentTypes> { TalentTypes.CombatReflexes, TalentTypes.FastShot, TalentTypes.HatredAny, TalentTypes.Warleader } },
            { 4, new List<TalentTypes> { TalentTypes.AccurateShot, TalentTypes.Inspiring, TalentTypes.ReactionStrike, TalentTypes.Robust } }
        };
    }
}

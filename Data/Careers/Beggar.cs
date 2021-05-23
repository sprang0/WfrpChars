using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WfrpChars.Data.Careers
{
    class Beggar : CareerBase
    {
        public Beggar(int level) : base(level) { }

        public override string Name => "Beggar";

        public override string Path => Level switch
        {
            1 => "Pauper",
            2 => "Beggar",
            3 => "Master Beggar",
            4 => "Beggar King",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Silver;
        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Gold;
        public override int Agility => Bonus * Level;
        public override int Willpower => Bonus * Brass;
        public override int Fellowship => Brass * Level;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Athletics, SkillType.Charm, SkillType.ConsumeAlcohol, SkillType.Cool, SkillType.Dodge, SkillType.Endurance, SkillType.Intuition, SkillType.StealthUrban } },
            { 2, new List<SkillType> { SkillType.EntertainActing, SkillType.EntertainAny, SkillType.Gossip, SkillType.Haggle, SkillType.Perception, SkillType.SlightOfHand } },
            { 3, new List<SkillType> { SkillType.CharmAnimal, SkillType.Leadership, SkillType.LoreLocal, SkillType.StreetSignsVagabond } },
            { 4, new List<SkillType> { SkillType.Bribery, SkillType.Intimidate } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.Panhandle, TalentType.ResistanceDisease, TalentType.StoneSoup, TalentType.VeryResilient } },
            { 2, new List<TalentType> { TalentType.AlleyCat, TalentType.BeneathNotice, TalentType.Criminal, TalentType.EtiquetteCriminals } },
            { 3, new List<TalentType> { TalentType.Blather, TalentType.DirtyFighting, TalentType.Hardy, TalentType.StepAside } },
            { 4, new List<TalentType> { TalentType.CatTongued, TalentType.FearlessWatchmen, TalentType.Kingpin, TalentType.Suave } }
        };
    }
}

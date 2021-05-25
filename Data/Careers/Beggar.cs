using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Athletics, SkillTypes.Charm, SkillTypes.ConsumeAlcohol, SkillTypes.Cool, SkillTypes.Dodge, SkillTypes.Endurance, SkillTypes.Intuition, SkillTypes.StealthUrban } },
            { 2, new List<SkillTypes> { SkillTypes.EntertainActing, SkillTypes.EntertainAny, SkillTypes.Gossip, SkillTypes.Haggle, SkillTypes.Perception, SkillTypes.SleightOfHand } },
            { 3, new List<SkillTypes> { SkillTypes.CharmAnimal, SkillTypes.Leadership, SkillTypes.LoreLocal, SkillTypes.StreetSignsVagabond } },
            { 4, new List<SkillTypes> { SkillTypes.Bribery, SkillTypes.Intimidate } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.Panhandle, TalentTypes.ResistanceDisease, TalentTypes.StoneSoup, TalentTypes.VeryResilient } },
            { 2, new List<TalentTypes> { TalentTypes.AlleyCat, TalentTypes.BeneathNotice, TalentTypes.Criminal, TalentTypes.EtiquetteCriminals } },
            { 3, new List<TalentTypes> { TalentTypes.Blather, TalentTypes.DirtyFighting, TalentTypes.Hardy, TalentTypes.StepAside } },
            { 4, new List<TalentTypes> { TalentTypes.CatTongued, TalentTypes.FearlessWatchmen, TalentTypes.Kingpin, TalentTypes.Suave } }
        };
    }
}

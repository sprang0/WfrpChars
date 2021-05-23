using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WfrpChars.Data.Careers
{
    class Agitator : CareerBase
    {
        public Agitator(int level) : base(level) { }

        public override string Name => "Agitator";

        public override string Path => Level switch
        {
            1 => "Pamphleteer",
            2 => "Agitator",
            3 => "Rabble Rouser",
            4 => "Demagogue",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Silver;
        public override int BallisticSkill => Bonus * Level;
        public override int Initiative => Bonus * Gold;
        public override int Agility => Bonus * Brass;
        public override int Intelligence => Bonus * Level;
        public override int Fellowship => Bonus * Level;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.ArtWriting, SkillType.Bribery, SkillType.Charm, SkillType.ConsumeAlcohol, SkillType.Gossip, SkillType.Haggle, SkillType.LorePolitics, SkillType.TradePrinting } },
            { 2, new List<SkillType> { SkillType.Cool, SkillType.Dodge, SkillType.EntertainStorytelling, SkillType.Gamble, SkillType.Intuition, SkillType.Leadership } },
            { 3, new List<SkillType> { SkillType.Athletics, SkillType.Intimidate, SkillType.MeleeBrawling, SkillType.Perception } },
            { 4, new List<SkillType> { SkillType.LoreHeraldry, SkillType.RideHorse } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.Blather, TalentType.Gregarious, TalentType.Panhandle, TalentType.ReadWrite } },
            { 2, new List<TalentType> { TalentType.AlleyCat, TalentType.Argumentative, TalentType.ImpassionedZeal, TalentType.PublicSpeaker } },
            { 3, new List<TalentType> { TalentType.CatTongued, TalentType.DirtyFighting, TalentType.Flee, TalentType.StepAside } },
            { 4, new List<TalentType> { TalentType.EtiquetteAny, TalentType.MasterOrator, TalentType.Schemer, TalentType.Suave } }
        };
    }
}

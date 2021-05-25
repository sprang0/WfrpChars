using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.ArtWriting, SkillTypes.Bribery, SkillTypes.Charm, SkillTypes.ConsumeAlcohol, SkillTypes.Gossip, SkillTypes.Haggle, SkillTypes.LorePolitics, SkillTypes.TradePrinting } },
            { 2, new List<SkillTypes> { SkillTypes.Cool, SkillTypes.Dodge, SkillTypes.EntertainStorytelling, SkillTypes.Gamble, SkillTypes.Intuition, SkillTypes.Leadership } },
            { 3, new List<SkillTypes> { SkillTypes.Athletics, SkillTypes.Intimidate, SkillTypes.MeleeBrawling, SkillTypes.Perception } },
            { 4, new List<SkillTypes> { SkillTypes.LoreHeraldry, SkillTypes.RideHorse } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.Blather, TalentTypes.Gregarious, TalentTypes.Panhandle, TalentTypes.ReadWrite } },
            { 2, new List<TalentTypes> { TalentTypes.AlleyCat, TalentTypes.Argumentative, TalentTypes.ImpassionedZeal, TalentTypes.PublicSpeaker } },
            { 3, new List<TalentTypes> { TalentTypes.CatTongued, TalentTypes.DirtyFighting, TalentTypes.Flee, TalentTypes.StepAside } },
            { 4, new List<TalentTypes> { TalentTypes.EtiquetteAny, TalentTypes.MasterOrator, TalentTypes.Schemer, TalentTypes.Suave } }
        };
    }
}

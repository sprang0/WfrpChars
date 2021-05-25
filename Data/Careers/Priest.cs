using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Priest : CareerBase
    {
        public Priest(int level) : base(level) { }

        public override string Name => "Priest";

        public override string Path => Level switch
        {
            1 => "Initiate",
            2 => "Priest",
            3 => "High Priest",
            4 => "Lector",
            _ => throw new Exception("No such Level")
        };

        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Gold;
        public override int Agility => Bonus * Level;
        public override int Intelligence => Bonus * Silver;
        public override int Willpower => Bonus * Level;
        public override int Fellowship => Bonus * Brass;

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Athletics, SkillTypes.Cool, SkillTypes.Endurance, SkillTypes.Intuition, SkillTypes.LoreTheology, SkillTypes.Perception, SkillTypes.Pray, SkillTypes.Research } },
            { 2, new List<SkillTypes> { SkillTypes.Charm, SkillTypes.EntertainStorytelling, SkillTypes.Gossip, SkillTypes.Heal, SkillTypes.Intimidate, SkillTypes.MeleeBasic } },
            { 3, new List<SkillTypes> { SkillTypes.ArtWriting, SkillTypes.EntertainSpeeches, SkillTypes.Leadership, SkillTypes.LoreHeraldry } },
            { 4, new List<SkillTypes> { SkillTypes.LanguageAny, SkillTypes.LorePolitics } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.BlessAny, TalentTypes.HolyVisions, TalentTypes.ReadWrite, TalentTypes.Suave } },
            { 2, new List<TalentTypes> { TalentTypes.Blather, TalentTypes.Bookish, TalentTypes.EtiquetteCultists, TalentTypes.InvokeAny } },
            { 3, new List<TalentTypes> { TalentTypes.AcuteSenseAny, TalentTypes.HatredAny, TalentTypes.ImpassionedZeal, TalentTypes.StrongMinded } },
            { 4, new List<TalentTypes> { TalentTypes.MasterOrator, TalentTypes.PureSoul, TalentTypes.ResistanceAny, TalentTypes.SavantTheology } }
        };
    }
}

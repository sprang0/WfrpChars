using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Athletics, SkillType.Cool, SkillType.Endurance, SkillType.Intuition, SkillType.LoreTheology, SkillType.Perception, SkillType.Pray, SkillType.Research } },
            { 2, new List<SkillType> { SkillType.Charm, SkillType.EntertainStorytelling, SkillType.Gossip, SkillType.Heal, SkillType.Intimidate, SkillType.MeleeBasic } },
            { 3, new List<SkillType> { SkillType.ArtWriting, SkillType.EntertainSpeeches, SkillType.Leadership, SkillType.LoreHeraldry } },
            { 4, new List<SkillType> { SkillType.LanguageAny, SkillType.LorePolitics } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.BlessAny, TalentType.HolyVisions, TalentType.ReadWrite, TalentType.Suave } },
            { 2, new List<TalentType> { TalentType.Blather, TalentType.Bookish, TalentType.EtiquetteCultists, TalentType.InvokeAny } },
            { 3, new List<TalentType> { TalentType.AcuteSenseAny, TalentType.HatredAny, TalentType.ImpassionedZeal, TalentType.StrongMinded } },
            { 4, new List<TalentType> { TalentType.MasterOrator, TalentType.PureSoul, TalentType.ResistanceAny, TalentType.SavantTheology } }
        };
    }
}

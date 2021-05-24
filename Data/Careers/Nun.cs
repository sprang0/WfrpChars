using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WfrpChars.Data.Careers
{
    class Nun : CareerBase
    {
        public Nun(int level) : base(level) { }

        public override string Name => "Nun";

        public override string Path => Level switch
        {
            1 => "Novitiate",
            2 => "Nun",
            3 => "Abbess",
            4 => "Prioress General",
            _ => throw new Exception("No such Level")
        };

        public override int Toughness => Bonus * Gold;
        public override int Initiative => Bonus * Silver;
        public override int Dexterity => Bonus * Level;
        public override int Intelligence => Bonus * Level;
        public override int Willpower => Bonus * Brass;
        public override int Fellowship => Bonus * Level;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.ArtCalligraphy, SkillType.Cool, SkillType.Endurance, SkillType.EntertainStorytelling, SkillType.Gossip, SkillType.Heal, SkillType.LoreTheology, SkillType.Pray } },
            { 2, new List<SkillType> { SkillType.Charm, SkillType.MeleeAny, SkillType.Research, SkillType.TradeBrewer, SkillType.TradeHerbalist, SkillType.TradeVintner } },
            { 3, new List<SkillType> { SkillType.Leadership, SkillType.LoreLocal, SkillType.LorePolitics, SkillType.Perception } },
            { 4, new List<SkillType> { SkillType.LanguageAny, SkillType.LoreAny } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.BlessAny, TalentType.StoneSoup, TalentType.Panhandle, TalentType.ReadWrite } },
            { 2, new List<TalentType> { TalentType.EtiquetteCultists, TalentType.FieldDressing, TalentType.HolyVisions, TalentType.InvokeAny } },
            { 3, new List<TalentType> { TalentType.ResistanceAny, TalentType.Robust, TalentType.SavantTheology, TalentType.StoutHearted } },
            { 4, new List<TalentType> { TalentType.CommandingPresence, TalentType.IronWill, TalentType.PureSoul, TalentType.StrongMinded } }
        };
    }
}

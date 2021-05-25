using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.ArtCalligraphy, SkillTypes.Cool, SkillTypes.Endurance, SkillTypes.EntertainStorytelling, SkillTypes.Gossip, SkillTypes.Heal, SkillTypes.LoreTheology, SkillTypes.Pray } },
            { 2, new List<SkillTypes> { SkillTypes.Charm, SkillTypes.MeleeAny, SkillTypes.Research, SkillTypes.TradeBrewer, SkillTypes.TradeHerbalist, SkillTypes.TradeVintner } },
            { 3, new List<SkillTypes> { SkillTypes.Leadership, SkillTypes.LoreLocal, SkillTypes.LorePolitics, SkillTypes.Perception } },
            { 4, new List<SkillTypes> { SkillTypes.LanguageAny, SkillTypes.LoreAny } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.BlessAny, TalentTypes.StoneSoup, TalentTypes.Panhandle, TalentTypes.ReadWrite } },
            { 2, new List<TalentTypes> { TalentTypes.EtiquetteCultists, TalentTypes.FieldDressing, TalentTypes.HolyVisions, TalentTypes.InvokeAny } },
            { 3, new List<TalentTypes> { TalentTypes.ResistanceAny, TalentTypes.Robust, TalentTypes.SavantTheology, TalentTypes.StoutHearted } },
            { 4, new List<TalentTypes> { TalentTypes.CommandingPresence, TalentTypes.IronWill, TalentTypes.PureSoul, TalentTypes.StrongMinded } }
        };
    }
}

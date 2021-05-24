using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WfrpChars.Data.Careers
{
    class Fence : CareerBase
    {
        public Fence(int level) : base(level) { }

        public override string Name => "Fence";

        public override string Path => Level switch
        {
            1 => "Broker",
            2 => "Fence",
            3 => "Master Fence",
            4 => "Black Marketeer",
            _ => throw new Exception("No such Level")
        };

        public override int Initiative => Bonus * Level;
        public override int Agility => Bonus * Level;
        public override int Dexterity => Bonus * Brass;
        public override int Intelligence => Bonus * Silver;
        public override int Willpower => Bonus * Gold;
        public override int Fellowship => Bonus * Level;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Charm, SkillType.ConsumeAlcohol, SkillType.Dodge, SkillType.Evaluate, SkillType.Gamble, SkillType.Gossip, SkillType.Haggle, SkillType.MeleeBasic } },
            { 2, new List<SkillType> { SkillType.Cool, SkillType.Intimidate, SkillType.Intuition, SkillType.Perception, SkillType.SecretSignsThief, SkillType.TradeEngraver } },
            { 3, new List<SkillType> { SkillType.Bribery, SkillType.EntertainStorytelling, SkillType.LoreArt, SkillType.LoreLocal } },
            { 4, new List<SkillType> { SkillType.LoreHeraldry, SkillType.Research } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.AlleyCat, TalentType.Cardsharp, TalentType.Dealmaker, TalentType.Gregarious } },
            { 2, new List<TalentType> { TalentType.Criminal, TalentType.EtiquetteCriminals, TalentType.Numismatics, TalentType.Savvy } },
            { 3, new List<TalentType> { TalentType.Kingpin, TalentType.StrikeToStun, TalentType.Suave, TalentType.SuperNumerate } },
            { 4, new List<TalentType> { TalentType.DirtyFighting, TalentType.IronWill, TalentType.Menacing, TalentType.Briber } }
        };
    }
}

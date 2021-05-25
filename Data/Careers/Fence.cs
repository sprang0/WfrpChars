using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Charm, SkillTypes.ConsumeAlcohol, SkillTypes.Dodge, SkillTypes.Evaluate, SkillTypes.Gamble, SkillTypes.Gossip, SkillTypes.Haggle, SkillTypes.MeleeBasic } },
            { 2, new List<SkillTypes> { SkillTypes.Cool, SkillTypes.Intimidate, SkillTypes.Intuition, SkillTypes.Perception, SkillTypes.SecretSignsThief, SkillTypes.TradeEngraver } },
            { 3, new List<SkillTypes> { SkillTypes.Bribery, SkillTypes.EntertainStorytelling, SkillTypes.LoreArt, SkillTypes.LoreLocal } },
            { 4, new List<SkillTypes> { SkillTypes.LoreHeraldry, SkillTypes.Research } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.AlleyCat, TalentTypes.Cardsharp, TalentTypes.Dealmaker, TalentTypes.Gregarious } },
            { 2, new List<TalentTypes> { TalentTypes.Criminal, TalentTypes.EtiquetteCriminals, TalentTypes.Numismatics, TalentTypes.Savvy } },
            { 3, new List<TalentTypes> { TalentTypes.Kingpin, TalentTypes.StrikeToStun, TalentTypes.Suave, TalentTypes.SuperNumerate } },
            { 4, new List<TalentTypes> { TalentTypes.DirtyFighting, TalentTypes.IronWill, TalentTypes.Menacing, TalentTypes.Briber } }
        };
    }
}

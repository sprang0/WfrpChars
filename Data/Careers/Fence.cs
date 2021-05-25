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

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Charm, Types.Skills.ConsumeAlcohol, Types.Skills.Dodge, Types.Skills.Evaluate, Types.Skills.Gamble, Types.Skills.Gossip, Types.Skills.Haggle, Types.Skills.MeleeBasic } },
            { 2, new List<Skills> { Types.Skills.Cool, Types.Skills.Intimidate, Types.Skills.Intuition, Types.Skills.Perception, Types.Skills.SecretSignsThief, Types.Skills.TradeEngraver } },
            { 3, new List<Skills> { Types.Skills.Bribery, Types.Skills.EntertainStorytelling, Types.Skills.LoreArt, Types.Skills.LoreLocal } },
            { 4, new List<Skills> { Types.Skills.LoreHeraldry, Types.Skills.Research } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.AlleyCat, Types.Talents.Cardsharp, Types.Talents.Dealmaker, Types.Talents.Gregarious } },
            { 2, new List<Talents> { Types.Talents.Criminal, Types.Talents.EtiquetteCriminals, Types.Talents.Numismatics, Types.Talents.Savvy } },
            { 3, new List<Talents> { Types.Talents.Kingpin, Types.Talents.StrikeToStun, Types.Talents.Suave, Types.Talents.SuperNumerate } },
            { 4, new List<Talents> { Types.Talents.DirtyFighting, Types.Talents.IronWill, Types.Talents.Menacing, Types.Talents.Briber } }
        };
    }
}
